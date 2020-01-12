using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Concrete
{
    public class MarsRoverInput
    {
        public string[] StartInformations { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public char StartDirection { get; set; }
        public List<char> MoveDirections { get; set; }

        public MarsRoverInput()
        {
            StartInformations = new string[3];
            MoveDirections = new List<char>();
        }
    }
}
