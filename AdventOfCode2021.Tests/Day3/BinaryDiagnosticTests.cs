using System.Collections.Generic;
using AdventOfCode2021.Day3;
using Xunit;
using xUnitHelpers;

namespace AdventOfCode2021.Tests.Day3
{
    public class BinaryDiagnosticTests
    {
        private readonly BinaryDiagnostic _binaryDiagnostic;

        public BinaryDiagnosticTests()
        {
            _binaryDiagnostic = new BinaryDiagnostic();
        }

        [Theory]
        [JsonFileData(
            "Day3/testData.json",
            "Part1",
            typeof(List<string>),
            typeof(int))]
        public void GetPowerConsumption(List<string> data, int expectedResult)
        {
            var result = _binaryDiagnostic.GetPowerConsumption(data);
            Assert.Equal(expectedResult, result);
        }
    }
}
