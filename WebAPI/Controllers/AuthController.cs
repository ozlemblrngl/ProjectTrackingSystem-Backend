﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Auth.Requests;
using Business.Dtos.User.Requests;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Security.Hashing;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IMapper _mapper;
        private IUserService _userService;
        public AuthController(IAuthService authService, IUserService userService, IMapper mapper)
        {
            _authService = authService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginAuthRequest request)
        {
            var userToLogin = await _authService.Login(request);
            var result = _authService.CreateAccessToken(userToLogin);
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterAuthRequest request)
        {
            await _authService.UserExists(request.Email);
            var registerResult = await _authService.Register(request, request.Password);
            var result = _authService.CreateAccessToken(registerResult);
            if (result != null)
            {
                return Ok(result);
            }
            return Ok(registerResult);
        }


        [HttpPost("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword([FromBody] UploadPasswordRequest request)
        {
            if (request.ReNewPassword != request.NewPassword)
            {
                throw new BusinessException("Şifreler Eşleşmiyor");
            }
            var userResult = await _userService.Get(request.UserId);
            var loginResult = await _authService.Login(new LoginAuthRequest { Email = userResult.Email, Password = request.Password });
            if (loginResult != null || userResult != null)
            {
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(request.NewPassword, out passwordHash, out passwordSalt);
                userResult.PasswordHash = passwordHash;
                userResult.PasswordSalt = passwordSalt;
                var updateRequest = _mapper.Map<UpdateUserRequest>(userResult);
                _userService.Update(updateRequest);
            }
            else
            {
                throw new BusinessException("Eski şifre doğrulanamadı.");
            }
            return Ok();
        }
    }
}
