using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JournalApp.Core
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Follow { get; set; }
        public DateTime DateOfBirth { get; set; }
        private ICollection<User> _following;

        public ICollection<User> Following
        {
            get { return _following; }
            set { _following = value;}
        }

        public Gender Gender { get; set; }
        public User()
        {
            
        }
    }
}
