namespace MarkGravestock.MarsRoverKata
{
    public class MarsRover
    {
        private readonly Grid grid;

        public MarsRover() : this(new Grid())
        {
        }
        
        public MarsRover(Grid grid)
        {
            Direction = new North(this);
            this.grid = grid;
        }

        private string Result => $"{Position.XOffset}:{Position.YOffset}:{Direction.GetType().Name.Substring(0, 1)}";

        public Direction Direction { get; set; }

        public Position Position { get; } = new Position();

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
                    
                    Direction.Move();

                    if (grid.HasObstructionAt(Position))
                    {
                        return $"O:{previousPosition}";
                    }
                }
            }

            return Result;
        }
    }
}