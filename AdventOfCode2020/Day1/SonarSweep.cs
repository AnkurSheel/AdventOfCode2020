using System.Collections.Generic;

namespace AdventOfCode2020.Day1
{
    public class SonarSweep
    {
        public int CountDepthMeasurementIncreases(List<int> data)
        {
            var numberOfIncreases = 0;
            var previousMeasurement = data[0];

            for (var i = 1; i < data.Count; i++)
            {
                var currentMeasurement = data[i];

                if (currentMeasurement > previousMeasurement)
                {
                    numberOfIncreases++;
                }

                previousMeasurement = currentMeasurement;
            }

            return numberOfIncreases;
        }

        public int CountDepthSlidingSumMeasurementIncreases(List<int> data)
        {
            var numberOfIncreases = 0;
            var previousMeasurement = data[0] + data[1] + data[2];

            for (var i = 3; i < data.Count; i++)
            {
                var currentMeasurement = data[i] + data[i - 1] + data[i - 2];

                if (currentMeasurement > previousMeasurement)
                {
                    numberOfIncreases++;
                }

                previousMeasurement = currentMeasurement;
            }

            return numberOfIncreases;
        }
    }
}
