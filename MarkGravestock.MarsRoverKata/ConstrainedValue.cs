namespace MarkGravestock.MarsRoverKata
{
    public class ConstrainedValue
    {
        public ConstrainedValue(int maximumValue)
        {
            maximumOffset = maximumValue;
        }
        
        private readonly int maximumOffset;

        private int offset = 0;
        public int Offset => offset;

        public void Decrement()
        {
            if (offset == 0)
            {
                offset = maximumOffset;
            }

            offset = Offset - 1;
        }

        public void Increment()
        {
            offset = (Offset + 1) % maximumOffset;
        }
    }
}