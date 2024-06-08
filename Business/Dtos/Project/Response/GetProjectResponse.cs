﻿namespace Business.Dtos.Project.Response
{
    public class GetProjectResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
