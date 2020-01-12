using MarsRoverCase.Concrete;
using MarsRoverCase.Constants;
using MarsRoverCase.Exceptions;
using MarsRoverCase.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> platueBoundries = new List<string>();
            int startX, startY,secondStartX,secondStartY;
            MarsRoverInput firstMarsRoverInput = new MarsRoverInput();
            MarsRoverInput secondMarsRoverInput = new MarsRoverInput();
            List<string> results = new List<string>(); ;
            int boundryUpperX, boundryUpperY;

            try
            {
                platueBoundries = Console.ReadLine().Trim().Split(' ').Take(2).ToList();

                if (platueBoundries != null && int.TryParse(platueBoundries[0], out boundryUpperX) && int.TryParse(platueBoundries[1], out boundryUpperY)) //Check if upper boundries not null and parsable to int
                {
                    if(boundryUpperX > 0 && boundryUpperY > 0) //Check if upper boundries greather than zero otherwise rovers cant move
                    {
                        firstMarsRoverInput.StartInformations = Console.ReadLine().Trim().Split(' ');
                        Plateau plateau = new Plateau(boundryUpperX, boundryUpperY); // Set plateau upper boundries

                        // Check if entered start position of rover valid for x and y coordinates which must be integer and start direction not null or empty
                        if (int.TryParse(firstMarsRoverInput.StartInformations[0].Trim(), out startX) && int.TryParse(firstMarsRoverInput.StartInformations[1].Trim(), out startY) && !string.IsNullOrEmpty(firstMarsRoverInput.StartInformations[2].Trim()))
                        {
                            MarsRover marsRover = new MarsRover(startX, startY, plateau);
                            if(marsRover.CheckCoordinatesCompatibility()) // Check if start position of rover is inside boundries
                            {
                                firstMarsRoverInput.StartDirection = firstMarsRoverInput.StartInformations[2].Trim().ToUpper().First();
                                marsRover.SetDirection(firstMarsRoverInput.StartDirection); // Set the entered direction char to valid enum, if it is not valid throw exception
                                firstMarsRoverInput.MoveDirections = Console.ReadLine().ToUpper().ToCharArray().ToList();
                                foreach (var direction in firstMarsRoverInput.MoveDirections)
                                {
                                    marsRover.Move(direction);
                                }

                                results.Add(string.Format(Messages.CurrentCoordinateResult, marsRover.PositionX,marsRover.PositionY,marsRover.GetCurrentDirection()));
                                secondMarsRoverInput.StartInformations = Console.ReadLine().Trim().Split(' ');
                            }
                        }
                        else
                        {
                            throw new InvalidCoordinateException(Messages.InvalidStartCoordinate);
                        }

                        //Same validations for second mars rover inputs
                        if (int.TryParse(secondMarsRoverInput.StartInformations[0].Trim(), out secondStartX) && int.TryParse(secondMarsRoverInput.StartInformations[1].Trim(), out secondStartY) && !string.IsNullOrEmpty(secondMarsRoverInput.StartInformations[2].Trim()))
                        {
                            MarsRover secondMarsRover = new MarsRover(secondStartX, secondStartY, plateau);
                            if (secondMarsRover.CheckCoordinatesCompatibility())
                            {
                                secondMarsRoverInput.StartDirection = secondMarsRoverInput.StartInformations[2].Trim().ToUpper().First();
                                secondMarsRover.SetDirection(secondMarsRoverInput.StartDirection);
                                secondMarsRoverInput.MoveDirections = Console.ReadLine().ToUpper().ToCharArray().ToList();
                                foreach (var direction in secondMarsRoverInput.MoveDirections)
                                {
                                    secondMarsRover.Move(direction);
                                }
                                results.Add(string.Format(Messages.CurrentCoordinateResult, secondMarsRover.PositionX, secondMarsRover.PositionY, secondMarsRover.GetCurrentDirection()));
                            }
                        }
                        else
                        {
                            throw new InvalidCoordinateException(Messages.InvalidStartCoordinate);
                        }

                        results.ForEach(x => Console.WriteLine(x));
                    }
                    else
                    {
                        throw new InvalidCoordinateException(Messages.UpperLimitsMustBeGreaterThanZero);
                    }

                }
                else
                {
                    throw new InvalidCoordinateException(Messages.UpperLimitsMustBeGreaterThanZero);
                }
            }
            catch (InvalidCoordinateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Messages.AnErrorOccured);
            }            
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
