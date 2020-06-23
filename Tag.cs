using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp.Core
{
    public class Tag
    {
        public int Id { get; set; }
        public string LocationTag { get; set; }
        public User UserTag { get; set; }
        public string TagText { get; set; }
    }
}
