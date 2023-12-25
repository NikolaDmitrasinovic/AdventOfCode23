namespace TestWeatherCalibration
{
    public class WeatherCalibrationTests
    {
        [Fact]
        public void ShouldReturn0_ForEmptyString()
        {
            // Arrange

            // Act
            var calibrationResult = WeatherCalibration.Calibrate("");

            // Assert
            calibrationResult.Should().Be(0);
        }

        [Theory]
        [InlineData("1", 11)]
        [InlineData("12", 12)]
        public void ShouldReturnNumber_ForInputNumberInStringFormat(string input, int result)
        {
            // Arrange

            // Act
            var calibrationResult = WeatherCalibration.Calibrate(input);

            // Assert
            calibrationResult.Should().Be(result);
        }

        [Theory]
        [InlineData("1abc2", 12)]
        [InlineData("pqr3stu8vwx", 38)]
        [InlineData("a1b2c3d4e5f", 15)]
        [InlineData("treb7uchet", 77)]
        public void ShouldReturnNumber_FromInputString(string input, int result)
        {
            // Arrange

            // Act
            var calibrationResult = WeatherCalibration.Calibrate(input);

            // Assert
            calibrationResult.Should().Be(result);
        }
    }
}