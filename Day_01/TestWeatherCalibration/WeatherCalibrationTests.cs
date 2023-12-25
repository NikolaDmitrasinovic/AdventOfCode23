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
    }
}