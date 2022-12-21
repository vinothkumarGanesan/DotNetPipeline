namespace DotNetPipeline
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5655);
        public int number { get; set; }

        //summary about the weather
        //testing the ci/cd

        public string? Summary { get; set; }
    }
}