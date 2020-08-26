namespace MarkGravestock.MarsRoverKata
{
    public class South : Direction
    {
        public South(MarsRover marsRover) : base(marsRover)
        {
        }
        public override void TurnLeft()
        {
            MarsRover.Direction = new East(MarsRover);
        }

        public override void TurnRight()
        {
            MarsRover.Direction = new West(MarsRover);
        }

        public override void Move()
        {
            MarsRover.Position.MoveSouth();
        }
    }
}