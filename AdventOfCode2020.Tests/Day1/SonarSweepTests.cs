using System.Collections.Generic;
using AdventOfCode2020.Day1;
using Xunit;
using xUnitHelpers;

namespace AdventOfCode2020.Tests.Day1
{
    public class SonarSweepTests
    {
        private readonly SonarSweep _sonarSweep;

        public SonarSweepTests()
        {
            _sonarSweep = new SonarSweep();
        }

        [Theory]
        [JsonFileData("Day1/testData.json", "Part1", typeof(List<int>), typeof(int))]
        public void GetTotalFuelRequirementReturnCorrectTotalFuelRequirement(List<int> data, int expectedResult)
        {
            var result = _sonarSweep.CountDepthMeasurementIncreases(data);
            Assert.Equal(expectedResult, result);
        }
    }
}
