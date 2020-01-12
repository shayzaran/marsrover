using MarsRoverCase.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Abstact
{
    public abstract class RoverBase:IRover
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Direction Direction { get; set; }

        public abstract char GetCurrentDirection();
        public abstract void HandleMovement(char moveDirection);
        public abstract void Move(char moveDirection);
        public abstract void MoveForward();
        public abstract void RotateLeft();
        public abstract void RotateRight();
        public abstract void SetDirection(char direction);
    }
}
