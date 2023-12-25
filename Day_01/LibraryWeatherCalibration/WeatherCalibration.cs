namespace LibraryWeatherCalibration
{
    public class WeatherCalibration
    {
        public static int Calibrate(string calibrateString)
        {
            return int.Parse(FindFirstNumber(calibrateString) + FindLastNumber(calibrateString));
        }

        private static string FindLastNumber(string calibrateString)
        {
            for (int i = calibrateString.Length; i > 0; i--)
            {
                if (int.TryParse(calibrateString[i - 1].ToString(), out int value))
                {
                    return value.ToString();
                }
            }

            return "0";
        }

        private static string FindFirstNumber(string calibrateString)
        {
            foreach (var item in calibrateString)
            {
                if (int.TryParse(item.ToString(), out int value))
                {
                    return item.ToString();
                }
            }

            return "0";
        }
    }
}