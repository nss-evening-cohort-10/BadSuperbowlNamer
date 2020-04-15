using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class int_to_roman_numerals
    {
        [Fact]
        public void translating_1_results_in_I()
        {
            //Arrange
            var number = 1;
            var expectedResult = "I";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void translating_5_results_in_V()
        {
            //Arrange
            var number = 5;
            var expectedResult = "V";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void translating_9_results_in_IX()
        {
            //Arrange
            var number = 9;
            var expectedResult = "IX";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void translating_3_results_in_III()
        {
            //Arrange
            var number = 3;
            var expectedResult = "III";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void translating_12_results_in_XII()
        {
            //Arrange
            var number = 12;
            var expectedResult = "XII";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void translating_14_results_in_XIV()
        {
            //Arrange
            var number = 14;
            var expectedResult = "XIV";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult,actualResult);
        }
    }
}
