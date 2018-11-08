using gRATE.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace gRATE.ViewModels
{
    public class VoteViewModel
    {
        public int ImageId { get; set; }
        public int UserId { get; set; }
        public int VoteValue { get; set; }
    }
}