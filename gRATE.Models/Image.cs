﻿using System;

namespace gRATE.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Category Category { get; set; }
        public DesiredVoteCount DesiredVoteCount { get; set; }
        public User Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime UploadedOn { get; set; }
    }
}