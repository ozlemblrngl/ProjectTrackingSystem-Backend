
using Business.Abstracts;
using Business.Concretes;
using Business.Rules;
using Core.Utilities.Security.Jwt;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class BusinessServiceRegistration
    {

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IProjectService, ProjectManager>();
            services.AddScoped<IAssignmentService, AssignmentManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();

            services.AddScoped<UserBusinessRules>();
            services.AddScoped<ProjectBusinessRules>();
            services.AddScoped<AssignmentBusinessRules>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            return services;
        }
    }
}
