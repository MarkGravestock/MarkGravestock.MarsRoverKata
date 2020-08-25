using System.Collections.Generic;
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
        [InlineData("RM", "1:0:E")]
        [InlineData("MRRM", "0:0:S")]
        [InlineData("MMRMMLM", "2:3:N")]
        [InlineData("RMMLM", "2:1:N")]
        public void rover_should_move_in_expected_direction(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            
            Assert.Equal(expectedOutput, sut.Execute(command));
        }

        [Theory]
        [InlineData("LLM", "0:9:S")]
        [InlineData("LM", "9:0:W")]
        [InlineData("LMMMMMMMMMM", "0:0:W")]
        public void rover_should_wrap_round_edges_of_grid(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            
            Assert.Equal(expectedOutput, sut.Execute(command));
        }

        [Theory]
        [InlineData("L", "0:0:W")]
        [InlineData("LL", "0:0:S")]
        [InlineData("LLL", "0:0:E")]
        [InlineData("LLLL", "0:0:N")]
        public void rover_should_turn_left(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            
            Assert.Equal(expectedOutput, sut.Execute(command));
        }

        [Theory]
        [InlineData("R", "0:0:E")]
        [InlineData("RR", "0:0:S")]
        [InlineData("RRRR", "0:0:N")]
        public void rover_should_turn_right(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            
            Assert.Equal(expectedOutput, sut.Execute(command));
        }

        [Theory]
        [InlineData("LXLYMZ", "0:9:S")]
        public void rover_should_ignore_invalid_commands(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            
            Assert.Equal(expectedOutput, sut.Execute(command));
        }

        [Fact]
        public void when_the_rover_move_to_a_position_that_is_occupied_the_last_empty_position_is_returned()
        {
            var sut = new MarsRover(new Grid(new List<Coordinates>() {new Coordinates {X = 0, Y = 3}}));
            Assert.Equal("O:0:2:N", sut.Execute("MMMM"));
        }
    }
}