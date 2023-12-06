namespace AdventOfCode._2023.Day6
{
    public static class CalculatorHelper
    {
        public static long CalculateWinningTimes(long totalTime, long totalDistance)
        {
            // Calculate the discriminant of the quadratic equation
            var discriminant = Math.Sqrt(totalTime * totalTime - 4 * totalDistance);

            // Calculate the minimum possible winning time using the quadratic formula
            var minPossibleWinningTimeFloat = (totalTime - discriminant) / 2;
            var minPossibleWinningTime = (long)Math.Floor(minPossibleWinningTimeFloat + 1);

            // Calculate the maximum possible winning time
            var maxPossibleWinningTime = totalTime - minPossibleWinningTime;

            // Calculate the range of possible winning times
            var numberOfPossibleWinningTimes = maxPossibleWinningTime - minPossibleWinningTime + 1;

            // Return the total number of possible winning times within the given constraints
            return numberOfPossibleWinningTimes;
        }
    }
}
