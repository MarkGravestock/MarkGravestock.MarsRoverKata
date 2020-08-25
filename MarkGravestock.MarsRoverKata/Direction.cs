namespace MarkGravestock.MarsRoverKata
{
    public class Direction
    {
        private const int MaximumDirectionValue = 4;
        
        private readonly string[] directions = { "N", "W", "S", "E" };

        private readonly ConstrainedValue directionOffset = new ConstrainedValue(MaximumDirectionValue);

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