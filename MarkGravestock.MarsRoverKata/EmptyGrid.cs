namespace MarkGravestock.MarsRoverKata
{
    public class EmptyGrid : Grid
    {
        public override bool HasObstructionAt(Position position)
        {
            return false;
        }
    }
}