namespace LibraryWeatherCalibration
{
    public class WeatherCalibration
    {
        public static int Calibrate(string calibrateString)
        {
            if (string.IsNullOrEmpty(calibrateString))
                return 0;

            return int.Parse(calibrateString);
        }
    }
}