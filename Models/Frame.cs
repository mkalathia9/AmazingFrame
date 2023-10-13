using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingFrame.Models
{
    public class Frame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public int Price { get; set; }

        public int Rating { get; set; }
    }
}
