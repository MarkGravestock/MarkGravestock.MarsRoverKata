using System;

namespace MarkGravestock.MarsRoverKata
{
    public class North : IDirection
    {
        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new East();
        }
    }

    public class East : IDirection
    {
        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return new South();
        }
    }

    public class West : IDirection
    {
        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new North();
        }
    }

    public class South : IDirection
    {
        public IDirection TurnLeft()
        {
            return new East();
        }

        public IDirection TurnRight()
        {
            return new West();
        }
    }

    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();
    }

    public class MarsRover
    {
        private readonly Grid grid;
        
        private IDirection _direction = new North();
        
        private readonly Direction direction = new Direction();
        
        private readonly Position position = new Position();

        public MarsRover() : this(new Grid())
        {
        }
        
        public MarsRover(Grid grid)
        {
            this.grid = grid;
        }

        private string Result => $"{position.XOffset}:{position.YOffset}:{direction.GetDirection()}";

        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'L')
                {
                    _direction = _direction.TurnLeft();
                    direction.TurnLeft();
                }
                else if (command == 'R')
                {
                    _direction = _direction.TurnRight();
                    direction.TurnRight();
                }
                else if (command == 'M')
                {
                    var previousPosition = Result;
                    
                    MoveInDirection();

                    if (grid.HasObstructionAt(position))
                    {
                        return $"O:{previousPosition}";
                    }
                }
            }

            return Result;
        }

        private void MoveInDirection()
        {
            //state.Move()
            if (_direction is North)
            {
                position.MoveNorth();
            }
            else if (_direction is South)
            {
                position.MoveSouth();
            }
            else if (_direction is West)
            {
                position.MoveWest();
            }
            else
            {
                position.MoveEast();
            }
        }
    }
}