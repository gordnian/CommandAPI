using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        private Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Act
            testCommand.Platform = "xUnit";
            
            //Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Act
            testCommand.CommandLine = "dotnet test";
            
            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }

        public void Dispose()
        {
            testCommand = null;
        }
    }
}