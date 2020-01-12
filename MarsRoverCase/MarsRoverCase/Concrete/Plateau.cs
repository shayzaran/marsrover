using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Concrete
{
    public class Plateau
    {
        public int BoundryUpperX { get; set; }
        public int BoundryUpperY { get; set; }
        public int BoundryLowerX { get; } = 0;
        public int BoundryLowerY { get; } = 0;
        public Plateau(int BoundryUpperX, int BoundryUpperY)
        {
            this.BoundryUpperX = BoundryUpperX;
            this.BoundryUpperY = BoundryUpperY;
        }
    }
}
