using System;
using FluentAssertions;
using Xunit;

namespace RefactoringChallenge.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Adding_3_plus_2_should_be_5()
        {
            var calc = new Calc();

            var result = calc.Execute(3, "+", 2);

            result.Should().Be(5);
        }

        [Fact]
        public void Substracting_2_from_3_should_be_1()
        {
            var calc = new Calc();

            var result = calc.Execute(3, "-", 2);

            result.Should().Be(1);
        }

        [Fact]
        public void Multiplying_3_by_2_should_be_6()
        {
            var calc = new Calc();

            var result = calc.Execute(3, "*", 2);

            result.Should().Be(6);
        }

        [Fact]
        public void Dividing_6_by_2_should_be_3()
        {
            var calc = new Calc();

            var result = calc.Execute(6, "/", 2);

            result.Should().Be(3);
        }
    }
}
