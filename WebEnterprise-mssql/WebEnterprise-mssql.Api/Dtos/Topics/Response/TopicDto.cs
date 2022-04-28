﻿using System;

namespace WebEnterprise_mssql.Dtos.Topics
{
    public class TopicDto
    {
        public string TopicName { get; set; }
        public string TopicDesc { get; set; }
        public DateTimeOffset ClosureDate { get; set; }
        public DateTimeOffset FinalClosureDate { get; set; }
        public string Status { get; set; }
    }
}
