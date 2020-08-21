namespace MarkGravestock.MarsRoverKata
{
    public class Grid
    {
        public virtual bool HasObstructionAt(Position position)
        {
            return (position.XOffset == 0) && (position.YOffset == 3);
        }
    }
}