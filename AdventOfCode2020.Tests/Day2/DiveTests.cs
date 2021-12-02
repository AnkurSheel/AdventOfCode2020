using System.Collections.Generic;
using AdventOfCode2020.Day2;
using Xunit;
using xUnitHelpers;

namespace AdventOfCode2020.Tests.Day2
{
    public class DiveTests
    {
        private readonly Dive _dive;

        public DiveTests()
        {
            _dive = new Dive();
        }

        [Theory]
        [JsonFileData("Day2/testData.json", "Part1", typeof(List<string>), typeof(int))]
        public void GetPositionMultiplicationResult(List<string> data, int expectedResult)
        {
            var result = _dive.GetPositionMultiplicationResult(data);
            Assert.Equal(expectedResult, result);
        }
    }
}
