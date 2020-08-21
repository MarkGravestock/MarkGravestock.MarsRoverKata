namespace MarkGravestock.MarsRoverKata
{
    // TODO: Assuming start point is 0:0:N Input M Output
    // TODO: Input "M", Output "2:0:N" 

    public class Direction
    {
        private readonly string[] directions = { "N", "W", "S", "E" };
        private int directionOffset = 0;

        public string GetDirection()
        {
            return directions[directionOffset];
        }

        public void TurnRight()
        {
            if (directionOffset == 0)
            {
                directionOffset = 3;
            }
            else
            {
                directionOffset = (directionOffset - 1) % 4;
            }
        }

        public void TurnLeft()
        {
            directionOffset = (directionOffset + 1) % 4;
        }
    }

    public class MarsRover
    {
        private int x = 0;

        private readonly Direction direction = new Direction();

        public string Result => $"{x}:0:{direction.GetDirection()}";

        public void Command(string commands)
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
        }

        private void MoveInDirection()
        {
            x++;
        }
    }
}