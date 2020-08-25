namespace MarkGravestock.MarsRoverKata
{
    public class Axis
    {
        private const int MaximumGridValue = 10;
        
        private readonly ConstrainedValue constrainedValue = new ConstrainedValue(MaximumGridValue);

        public int Offset => constrainedValue.Offset;

        public void MoveDownAxis()
        {
            constrainedValue.Decrement();
        }

        public void MoveUpAxis()
        {
            constrainedValue.Increment();
        }
    }
}