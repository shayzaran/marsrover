using MarsRoverCase.Abstact;
using MarsRoverCase.Constants;
using MarsRoverCase.Enums;
using MarsRoverCase.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Concrete
{
    public class MarsRover :RoverBase
    {
        public Plateau Plateau { get; set; }
        public MarsRover(int PositionX, int PositionY, Plateau plateau)
        {
            this.PositionX = PositionX;
            this.PositionY = PositionY;
            this.Plateau = plateau;
        }

        public override void MoveForward()
        {
            switch (Direction)
            {
                case Direction.North:                      
                    if (PositionY < Plateau.BoundryUpperY) PositionY++;
                    break;
                case Direction.East:
                    if (PositionX < Plateau.BoundryUpperX) PositionX++;
                    break;
                case Direction.South:
                    if (PositionY > Plateau.BoundryLowerY) PositionY--;
                    break;
                case Direction.West:
                    if (PositionX > Plateau.BoundryLowerX) PositionX--;
                    break;
                default:
                    break;
            }
        }

        public override void RotateLeft()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.West;
                    break;
                case Direction.East:
                    Direction = Direction.North;
                    break;
                case Direction.South:
                    Direction = Direction.East;
                    break;
                case Direction.West:
                    Direction = Direction.South;
                    break;
                default:
                    throw new InvalidCoordinateException(Messages.InvalidRotationDirection);
            }
        }

        public override void RotateRight()
        {
            switch (Direction)
            {
                case Direction.North:
                    Direction = Direction.East;
                    break;
                case Direction.East:
                    Direction = Direction.South;
                    break;
                case Direction.South:
                    Direction = Direction.West;
                    break;
                case Direction.West:
                    Direction = Direction.North;
                    break;
                default:
                    throw new InvalidCoordinateException(Messages.InvalidRotationDirection);
            }
        }

        public override void Move(char moveDirection)
        {
            HandleMovement(moveDirection);
        }

        public override void HandleMovement(char moveDirection)
        {
            switch (moveDirection)
            {
                case 'L':
                    RotateLeft();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'M':
                    MoveForward();
                    break;
                default:
                    throw new InvalidCoordinateException(Messages.InvalidRotationDirection);
            }
        }

        public override void SetDirection(char direction)
        {
            switch (direction)
            {
                case 'N':
                    Direction = Enums.Direction.North;
                    break;
                case 'E':
                    Direction = Enums.Direction.East;
                    break;
                case 'S':
                    Direction = Enums.Direction.South;
                    break;
                case 'W':
                    Direction = Enums.Direction.West;
                    break;
                default:
                    throw new InvalidCoordinateException(Messages.InvalidStartCoordinate);
            }
        }

        public override char GetCurrentDirection()
        {
            char result;
            switch (Direction)
            {
                case Direction.North:
                    result = 'N';
                    break;
                case Direction.East:
                    result = 'E';
                    break;
                case Direction.South:
                    result  = 'S';
                    break;
                case Direction.West:
                    result = 'W';
                    break;
                default:
                    throw new InvalidCoordinateException(Messages.InvalidStartCoordinate);
            }

            return result;
        }


    }
}
