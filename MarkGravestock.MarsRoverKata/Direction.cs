namespace MarkGravestock.MarsRoverKata
{
    public abstract class Direction // State
    {
        protected Direction(MarsRover marsRover)
        {
            MarsRover = marsRover;
        }

        // Context from GOF Pattern
        protected MarsRover MarsRover { get; }

        public abstract void TurnLeft();

        public abstract void TurnRight();

        public abstract void Move();
    }
}