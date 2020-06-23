using System;
using System.Collections.Generic;
using System.Text;

namespace JournalApp.Core
{
    public class Likes
    {
        public int Id { get; set; }
        public List<User> Likers { get; set; }
        public int LikeCount { get; set; }
        public Likes()
        {
            Likers = new List<User>();
        }
    }
}
