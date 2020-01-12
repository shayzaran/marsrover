using MarsRoverCase.Concrete;
using MarsRoverCase.Constants;
using MarsRoverCase.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Utilities.Extensions
{
    public static class MarsRoverExtensions
    {
        public static bool CheckCoordinatesCompatibility(this MarsRover marsRover)
        {
            if (marsRover.PositionX > marsRover.Plateau.BoundryUpperX || marsRover.PositionY > marsRover.Plateau.BoundryUpperY || marsRover.PositionX < marsRover.Plateau.BoundryLowerX || marsRover.PositionY < marsRover.Plateau.BoundryLowerY)
            {
                throw new InvalidCoordinateException(Messages.OutOfBoundriesPlateauCoordinates);
            }
            return true;
        }
    }
}
