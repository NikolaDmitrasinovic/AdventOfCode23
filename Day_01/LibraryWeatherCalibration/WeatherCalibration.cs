namespace LibraryWeatherCalibration
{
    public class WeatherCalibration
    {
        public static int Calibrate(string calibrateString)
        {
            string result = "0";

            foreach (var item in calibrateString)
            {
                if (int.TryParse(item.ToString(), out int value))
                {
                    result += item;
                    break;
                }                    
            }

            for (int i = calibrateString.Length; i > 0; i--)
            {
                if (int.TryParse(calibrateString[i-1].ToString(), out int value))
                {
                    result += value;
                    break;
                }                    
            }

            return int.Parse(result);
        }
    }
}