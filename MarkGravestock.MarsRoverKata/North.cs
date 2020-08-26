namespace MarkGravestock.MarsRoverKata
{
    public class North : Direction
    {
        public North(MarsRover marsRover) : base(marsRover)
        {
        }

        public override void TurnLeft()
        {
            MarsRover.Direction = new West(MarsRover);
        }

        public override void TurnRight()
        {
            MarsRover.Direction = new East(MarsRover);
        }

        public override void Move()
        {
            MarsRover.Position.MoveNorth();
        }
    }
}