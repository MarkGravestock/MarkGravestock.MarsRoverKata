namespace MarkGravestock.MarsRoverKata
{
    // TODO Obstacles

    public class MarsRover
    {
        private readonly Direction direction = new Direction();

        private readonly Position position = new Position();

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
                else
                {
                    MoveInDirection();
                }
            }

            return Result;
        }

        private void MoveInDirection()
        {
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