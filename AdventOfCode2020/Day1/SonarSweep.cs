using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day1
{
    public class SonarSweep
    {
        public int CountDepthMeasurementIncreases(List<int> data)
        {
            var numberOfIncreases = 0;
            var previousMeasurement = data.First();

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
    }
}
