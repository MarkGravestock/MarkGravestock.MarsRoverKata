namespace MarkGravestock.MarsRoverKata
{
    public class Position
    {
        private readonly Axis x = new Axis();
        private readonly Axis y = new Axis();

        public int XOffset => x.Offset;
        public int YOffset => y.Offset;

        public void MoveNorth()
        {
            y.MoveUpAxis();
        }

        public void MoveSouth()
        {
            y.MoveDownAxis();
        }

        public void MoveWest()
        {
            x.MoveDownAxis();
        }

        public void MoveEast()
        {
            x.MoveUpAxis();
        }
    }
}