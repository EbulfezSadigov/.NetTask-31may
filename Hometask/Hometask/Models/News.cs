using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hometask.Models
{
    public class News :BaseEntity
    {
        public DateTime date { get; set; }
        public string Subtitle { get; set; }
        public string Text { get; set; }
    }
}
