using gRATE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gRATE.ViewModels
{
    public class ImageViewModel
    {
        public string Path { get; set; }
        public Category Category { get; set; }
        public DesiredVoteCount DesiredVoteCount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}