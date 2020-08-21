namespace MarkGravestock.MarsRoverKata
{
    // TODO: Assuming start point is 0:0:N Input M Output
    // TODO: Input "M", Output "2:0:N" 

    public class MarsRover
    {
        private string result = "1:0:N";
        public string Result => result;

        public void Command(string command)
        {
            result = command.Length + ":0:N";
        }
    }
}