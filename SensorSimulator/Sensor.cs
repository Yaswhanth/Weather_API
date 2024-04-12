using System;

namespace SensorSimulator
{
	public static class Sensor
	{
		private static readonly Random random = new Random();

		public static double GetTemperature()
		{
			return Math.Round(random.NextDouble() * (39 -(-20)) + (-20), 2);
		}

		public static double GetRainfall()
		{
			return Math.Round(random.NextDouble() *(40 -0) + 0, 2);		
		}

		public static double GetHumidity()
		{
			return Math.Round(random.NextDouble() * (100 -0) + 0, 2);
		}

		public static double GetAirPollution()
		{
			return Math.Round(random.NextDouble() *(10-1) + 1, 2);
		}

		public static double GetCO2Emission()
		{
			return Math.Round(random.NextDouble()* (100 -1)  + 1, 2);
		}
	}
}
