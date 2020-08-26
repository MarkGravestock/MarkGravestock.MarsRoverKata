using System;

namespace MarkGravestock.MarsRoverKata
{
    public class North : DirectionState
    {
        public North(MarsRover marsRover) : base(marsRover)
        {
        }

        public override void TurnLeft()
        {
            MarsRover.Direction = new West(MarsRover);
        }

        public override void TurnRight()
        {
            MarsRover.Direction = new East(MarsRover);
        }
    }

    public class East : DirectionState
    {
        public East(MarsRover marsRover) : base(marsRover)
        {
        }

        public override void TurnLeft()
        {
            MarsRover.Direction = new North(MarsRover);
        }

        public override void TurnRight()
        {
            MarsRover.Direction = new South(MarsRover);
        }
    }

    public class West : DirectionState
    {
        public West(MarsRover marsRover) : base(marsRover)
        {
        }

        public override void TurnLeft()
        {
            MarsRover.Direction = new South(MarsRover);
        }

        public override void TurnRight()
        {
            MarsRover.Direction = new North(MarsRover);
        }

    }

    public class South : DirectionState
    {
        public override void TurnLeft()
        {
            MarsRover.Direction = new East(MarsRover);
        }

        public override void TurnRight()
        {
            MarsRover.Direction = new West(MarsRover);
        }

        public South(MarsRover marsRover) : base(marsRover)
        {
        }
    }

    public abstract class DirectionState // State
    {
        protected DirectionState(MarsRover marsRover)
        {
            this.MarsRover = marsRover;
        }

        // Context from GOF Patter
        protected MarsRover MarsRover { get; }

        public abstract void TurnLeft();

        public abstract void TurnRight();
    }

    public class MarsRover
    {
        private readonly Grid grid;
        
        public DirectionState _direction;
        
        public readonly Position position = new Position();

        public MarsRover() : this(new Grid())
        {
        }
        
        public MarsRover(Grid grid)
        {
            Direction = new North(this);
            this.grid = grid;
        }

        private string Result => $"{position.XOffset}:{position.YOffset}:{Direction.GetType().Name.Substring(0, 1)}";

        public DirectionState Direction
        {
            get => _direction;
            set => _direction = value;
        }

        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'L')
                {
                    Direction.TurnLeft();
                }
                else if (command == 'R')
                {
                    Direction.TurnRight();
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
            if (Direction is North)
            {
                position.MoveNorth();
            }
            else if (Direction is South)
            {
                position.MoveSouth();
            }
            else if (Direction is West)
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