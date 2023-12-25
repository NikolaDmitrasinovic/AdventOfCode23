namespace LibraryWeatherCalibration
{
    public class WeatherCalibration
    {
        public static int Calibrate(string calibrateString)
        {
            return int.TryParse(calibrateString, out int calibrationResult) ? calibrationResult : 0;
        }
    }
}