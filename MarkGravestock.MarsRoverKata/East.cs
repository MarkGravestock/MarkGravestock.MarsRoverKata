namespace MarkGravestock.MarsRoverKata
{
    public class East : Direction
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

        public override void Move()
        {
            MarsRover.Position.MoveEast();
        }
    }
}