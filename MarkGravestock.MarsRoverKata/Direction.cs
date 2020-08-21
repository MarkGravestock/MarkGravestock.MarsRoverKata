namespace MarkGravestock.MarsRoverKata
{
    public class Direction
    {
        private readonly string[] directions = { "N", "W", "S", "E" };

        private readonly ConstrainedValue directionOffset = new ConstrainedValue(4);

        public string GetDirection()
        {
            return directions[directionOffset.Offset];
        }

        public void TurnRight()
        {
            directionOffset.Decrement();
        }

        public void TurnLeft()
        {
            directionOffset.Increment();
        }
    }
}