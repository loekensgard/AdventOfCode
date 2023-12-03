using adventofcode._2023.Day1;
using adventofcode._2023.Day2;
using AdventOfCode._2023.Day3;

// Read input from file
SolvePuzzles("../../../2023/Day1/input.txt", Day1.SolvePartOne, Day1.SolvePartTwo);
SolvePuzzles("../../../2023/Day2/input.txt", Day2.SolvePartOne, Day2.SolvePartTwo);
SolvePuzzles("../../../2023/Day3/input.txt", Day3.SolvePartOne, Day3.SolvePartTwo);

static void SolvePuzzles(string filePath, Func<string[], int> solvePartOne, Func<string[], int> solvePartTwo)
{
    var input = File.ReadAllLines(filePath);

    Console.WriteLine($"Puzzle One: {solvePartOne(input)}");
    Console.WriteLine($"Puzzle Two: {solvePartTwo(input)}");
}