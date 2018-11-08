using System;

namespace gRATE.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
    }
}