using adventofcode._2023.Day1;
using adventofcode._2023.Day2;
using AdventOfCode._2023.Day3;
using AdventOfCode._2023.Day4;
using AdventOfCode._2023.Day6;
using AdventOfCode._2023.Day7;
using AdventOfCode._2023.Day8;

// Read input from file
SolvePuzzles("../../../2023/Day1/input.txt", Day1.SolvePartOne, Day1.SolvePartTwo);
SolvePuzzles("../../../2023/Day2/input.txt", Day2.SolvePartOne, Day2.SolvePartTwo);
SolvePuzzles("../../../2023/Day3/input.txt", Day3.SolvePartOne, Day3.SolvePartTwo);
SolvePuzzles("../../../2023/Day4/input.txt", Day4.SolvePartOne, Day4.SolvePartTwo);
SolvePuzzles("../../../2023/Day6/input.txt", Day6.SolvePartOne, Day6.SolvePartTwo);
SolvePuzzles("../../../2023/Day7/input.txt", Day7.SolvePartOne, Day7.SolvePartTwo);
SolvePuzzles("../../../2023/Day8/input.txt", Day8.SolvePartOne, Day8.SolvePartTwo);


static void SolvePuzzles(string filePath, Func<string[], string> solvePartOne, Func<string[], string> solvePartTwo)
{
    var input = File.ReadAllLines(filePath);

    Console.WriteLine($"Puzzle One : {solvePartOne(input)}");
    Console.WriteLine($"Puzzle Two : {solvePartTwo(input)}");
}