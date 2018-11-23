using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaka_Project.Models
{
    public class Coordinate
    {
        public int Max_X { get; set; }
        public int Max_Y { get; set; }

        public override string ToString()
        {
            return this.Max_X + " " + this.Max_Y;
        }
    }
}
