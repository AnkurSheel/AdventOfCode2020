using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2021.Day3
{
    public class BinaryDiagnostic
    {
        public int GetPowerConsumption(IReadOnlyList<string> data)
        {
            var numberOfBits = data[0].Length;
            var numberOfZeros = new int[numberOfBits];
            var numberOfOnes = new int[numberOfBits];

            foreach (var binaryNumber in data)
            {
                for (var i = 0; i < binaryNumber.Length; i++)
                {
                    switch (binaryNumber[i])
                    {
                        case '0':
                            numberOfZeros[i]++;
                            break;
                        case '1':
                            numberOfOnes[i]++;
                            break;
                    }
                }
            }

            var gammaRate = new StringBuilder();
            var epsilonRate = new StringBuilder();

            for (var i = 0; i < numberOfBits; i++)
            {
                if (numberOfZeros[i] > numberOfOnes[i])
                {
                    gammaRate.Append('0');
                    epsilonRate.Append('1');
                }
                else
                {
                    gammaRate.Append('1');
                    epsilonRate.Append('0');
                }
            }

            var gammaRateInDecimal = Convert.ToInt32(gammaRate.ToString(), 2);
            var epsilonRateInDecimal = Convert.ToInt32(epsilonRate.ToString(), 2);
            return gammaRateInDecimal * epsilonRateInDecimal;
        }

        public int GetLifeSupportRating(List<string> data)
        {
            var oxygenGeneratorRating = GetOxygenGeneratorRating(data, (numberOfZeros, numberOfOnes) => numberOfZeros > numberOfOnes);
            var co2ScrubberRating = GetOxygenGeneratorRating(data, (numberOfZeros, numberOfOnes) => numberOfZeros <= numberOfOnes);

            var oxygenGeneratorRatingInDecimal = Convert.ToInt32(oxygenGeneratorRating, 2);
            var co2ScrubberRatingInDecimal = Convert.ToInt32(co2ScrubberRating, 2);
            return oxygenGeneratorRatingInDecimal * co2ScrubberRatingInDecimal;
        }

        private string GetOxygenGeneratorRating(IReadOnlyList<string> data, Func<int, int, bool> keepZero)
        {
            var updatedList = new List<string>(data);
            var bitToConsider = 0;
            var filter = new StringBuilder();

            while (true)
            {
                var numberOfZeros = 0;
                var numberOfOnes = 0;

                if (updatedList.Count == 1)
                {
                    return updatedList.Single();
                }

                foreach (var binaryNumber in updatedList)
                {
                    switch (binaryNumber[bitToConsider])
                    {
                        case '0':
                            numberOfZeros++;
                            break;
                        case '1':
                            numberOfOnes++;
                            break;
                    }
                }

                filter.Append(
                    keepZero(numberOfZeros, numberOfOnes)
                        ? '0'
                        : '1');
                updatedList = updatedList.Where(x => x.StartsWith(filter.ToString())).ToList();
                bitToConsider++;
            }
        }
    }
}
