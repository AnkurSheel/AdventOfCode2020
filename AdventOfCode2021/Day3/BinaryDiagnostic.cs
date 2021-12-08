using System;
using System.Collections.Generic;
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
    }
}
