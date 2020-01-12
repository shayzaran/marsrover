using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Abstact
{
    public interface IRover
    {
        void Move(char moveDirection);
        void MoveForward();
        void RotateLeft();
        void RotateRight();
        void HandleMovement(char moveDirection);
        void SetDirection(char direction);
        char GetCurrentDirection();
    }
}
