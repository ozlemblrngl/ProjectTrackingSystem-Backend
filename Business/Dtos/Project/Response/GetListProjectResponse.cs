﻿namespace Business.Dtos.Project.Response
{
    public class GetListProjectResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
