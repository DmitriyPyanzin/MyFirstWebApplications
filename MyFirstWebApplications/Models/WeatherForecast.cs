namespace MyFirstWebApplications.Models
{
    /// <summary>
    /// Прогноз погоды Forecast
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Дата измерения
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Время изменения
        /// </summary>
        public TimeOnly time { get; set; }

        /// <summary>
        /// Температура в градусах Цельсия
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Температура в градусах Форенгейта
        /// </summary>
        public int TemperatureF
        {
            get { return 32 + (int)(TemperatureC / 0.5556); }
        }

        /// <summary>
        /// Температура в градусах Реомюра
        /// </summary>
        public int TemperatureR
        {
            get { return (int)(TemperatureC * 0.8); }
        }

        /// <summary>
        /// Температура в градусах Кельвина
        /// </summary>
        public int TemperatureK
        {
            get { return (int)(TemperatureC + 273.15); }
        }
    }
}
