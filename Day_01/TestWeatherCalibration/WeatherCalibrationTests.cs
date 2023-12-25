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
        [InlineData("1", 1)]
        [InlineData("12", 12)]
        public void ShouldReturnNumber_ForInputNumberInStringFormat(string input, int result)
        {
            // Arrange

            // Act
            var calibrationResult = WeatherCalibration.Calibrate(input);

            // Assert
            calibrationResult.Should().Be(result);
        }
    }
}