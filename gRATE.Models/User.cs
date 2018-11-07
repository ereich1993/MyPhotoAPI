using System;
using System.Collections.Generic;
using System.Text;

namespace gRATE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreditCount { get; set; }
        public string Email { get; set; }
    }
}