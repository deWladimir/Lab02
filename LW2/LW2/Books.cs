using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2
{
    class Books
    {
        public string Author { get; set; }
        public string Genre  { get; set; }
        public string Pages { get; set; }
        public string Overwhelm { get; set; }
        public string Price { get; set; }
        public string Edition { get; set; }
        public string Name { get; set; }

        public Books()
        {
            Author = "";
            Genre = "";
            Pages = "";
            Overwhelm = "";
            Price = "";
            Edition = "";
            Name = "";
        }
    }
}
