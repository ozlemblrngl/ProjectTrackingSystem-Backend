﻿using Entities.Enums;

namespace Business.Dtos.Assignment.Response
{
    public class GetAssignmentResponse
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public Status Status { get; set; }
    }
}
