using System;
using System.Collections.Generic;

namespace AdventOfCode2020.Day2
{
    public class Dive
    {
        public int GetPositionMultiplicationResult(IReadOnlyList<string> data)
        {
            var horizontalMovement = 0;
            var verticalMovement = 0;

            foreach (var movement in data)
            {
                var split = movement.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var direction = split[0];
                int.TryParse(split[1], out var movementAmount);

                if (direction == "forward")
                {
                    horizontalMovement += movementAmount;
                }

                else if (direction == "down")
                {
                    verticalMovement += movementAmount;
                }
                if (direction == "up")
                {
                    verticalMovement -= movementAmount;
                }
            }
            return horizontalMovement * verticalMovement;
        }

        public int GetPositionAimMultiplicationResult(IReadOnlyList<string> data)
        {
            var horizontalMovement = 0;
            var verticalMovement = 0;
            var aim = 0;

            foreach (var movement in data)
            {
                var split = movement.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var direction = split[0];
                int.TryParse(split[1], out var units);

                if (direction == "forward")
                {
                    horizontalMovement += units;
                    verticalMovement += (aim * units);
                }

                else if (direction == "down")
                {
                    aim += units;
                }
                if (direction == "up")
                {
                    aim -= units;
                }
            }
            return horizontalMovement * verticalMovement;
        }
    }
}
