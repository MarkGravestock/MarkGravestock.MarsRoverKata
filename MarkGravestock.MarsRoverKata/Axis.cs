namespace MarkGravestock.MarsRoverKata
{
    public class Axis
    {
        private readonly ConstrainedValue constrainedValue = new ConstrainedValue(10);

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