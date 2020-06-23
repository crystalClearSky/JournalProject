using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Core
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentString { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
