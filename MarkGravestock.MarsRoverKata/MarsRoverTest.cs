using System.Security.Principal;
using Xunit;

namespace MarkGravestock.MarsRoverKata
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData("M", "0:1:N")]
        [InlineData("MM", "0:2:N")]
        [InlineData("MMM", "0:3:N")]
        [InlineData("MMML", "0:3:W")]
        [InlineData("L", "0:0:W")]
        [InlineData("LL", "0:0:S")]
        [InlineData("LLL", "0:0:E")]
        [InlineData("LLLL", "0:0:N")]
        [InlineData("R", "0:0:E")]
        [InlineData("RR", "0:0:S")]
        [InlineData("RRRR", "0:0:N")]
        [InlineData("RM", "1:0:E")]
        [InlineData("MRRM", "0:0:S")]
        [InlineData("LLM", "0:9:S")]
        [InlineData("LM", "9:0:W")]
        [InlineData("MMRMMLM", "2:3:N")]
        [InlineData("RMMLM", "2:1:N")]
        [InlineData("LMMMMMMMMMM", "0:0:W")]
        public void when_the_rover_executes_a_command_the_output_is_correct(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            
            Assert.Equal(expectedOutput, sut.Execute(command));
        }

        [Fact]
        public void when_the_rover_move_to_a_position_that_is_occupied_the_last_empty_position_is_returned()
        {
            var sut = new MarsRover(new Grid());
            Assert.Equal("O:0:2:N", sut.Execute("MMMM"));
        }
    }
}