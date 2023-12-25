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

        [Fact]
        public void ShouldReturnNumber_ForInputString()
        {
            // Arrange

            // Act
            var calibrationResult = WeatherCalibration.Calibrate("1");

            // Assert
            calibrationResult.Should().Be(1);
        }
    }    
}