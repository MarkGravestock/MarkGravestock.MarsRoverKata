﻿using Xunit;

namespace MarkGravestock.MarsRoverKata
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData("M", "1:0:N")]
        [InlineData("MM", "2:0:N")]
        [InlineData("MMM", "3:0:N")]
        [InlineData("MMML", "3:0:W")]
        [InlineData("L", "0:0:W")]
        [InlineData("LL", "0:0:S")]
        [InlineData("LLL", "0:0:E")]
        [InlineData("LLLL", "0:0:N")]
        [InlineData("R", "0:0:E")]
        [InlineData("RR", "0:0:S")]
        [InlineData("RRRR", "0:0:N")]

        public void when_the_rover_executes_a_command_the_output_is_correct(string command, string expectedOutput)
        {
            var sut = new MarsRover();
            sut.Command(command);
            Assert.Equal(expectedOutput, sut.Result);
        }
    }
}