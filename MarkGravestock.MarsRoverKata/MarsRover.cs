namespace MarkGravestock.MarsRoverKata
{
    public class MarsRover
    {
        private readonly Grid grid;
        
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
                    direction.TurnLeft();
                }
                else if (command == 'R')
                {
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
            if (direction.GetDirection() == "N")
            {
                position.MoveNorth();
            }
            else if (direction.GetDirection() == "S")
            {
                position.MoveSouth();
            }
            else if (direction.GetDirection() == "W")
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