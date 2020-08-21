namespace MarkGravestock.MarsRoverKata
{
    // TODO Obstacles

    public class MarsRover
    {
        private readonly Direction direction = new Direction();

        private readonly Axis x = new Axis();
        private readonly Axis y = new Axis();

        private string Result => $"{x.Offset}:{y.Offset}:{direction.GetDirection()}";

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
                y.MoveUpAxis();
            }
            else if (direction.GetDirection() == "S")
            {
                y.MoveDownAxis();
            }
            else if (direction.GetDirection() == "W")
            {
                x.MoveDownAxis();
            }
            else
            {
                x.MoveUpAxis();
            }
        }
    }
}