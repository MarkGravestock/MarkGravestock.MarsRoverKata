using System.Collections.Generic;

namespace MarkGravestock.MarsRoverKata
{
    public class Grid
    {
        private readonly List<Coordinates> obstructions;

        public Grid() : this(new List<Coordinates>())
        {
        }

        public Grid(List<Coordinates> obstructions)
        {
            this.obstructions = obstructions;
        }
        
        public virtual bool HasObstructionAt(Position position)
        {
            foreach (var obstruction in obstructions)
            {
                if ((position.XOffset == obstruction.X) && (position.YOffset == obstruction.Y))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public struct Coordinates
    {
        public int X;
        public int Y;
    }
}