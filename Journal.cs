using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Core
{
    public class Journal : Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Like { get; set; }
        public int TagCount { get; set; }
        
        public Journal()
        {
            
        }

    }
}
