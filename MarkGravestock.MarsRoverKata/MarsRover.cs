namespace MarkGravestock.MarsRoverKata
{
    // TODO: Assuming start point is 0:0:N Input M Output
    // TODO: Input "M", Output "2:0:N" 

    public class MarsRover
    {
        private int x = 0;
        private string direction = "N";
        
        public string Result => $"{x}:0:{direction}";

        public void Command(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'L')
                { 
                    direction = "W";
                    return;
                }

                x++;
            }
        }
    }
}