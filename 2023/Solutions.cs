using adventofcode._2023.Day1;
using adventofcode._2023.Day2;
using AdventOfCode._2023.Day3;

// Read input from file
var day1 = System.IO.File.ReadAllLines("../../../2023/Day1/input.txt");
var day2 = System.IO.File.ReadAllLines("../../../2023/Day2/input.txt");
var day3 = System.IO.File.ReadAllLines("../../../2023/Day3/input.txt");

// Day 1
Console.WriteLine("Puzzle One Day1: " + Day1.SolvePartOne(day1));
Console.WriteLine("Puzzle Two Day1: " + Day1.SolvePartTwo(day1));

// Day 2
Console.WriteLine("Puzzle One Day2: " + Day2.SolvePartOne(day2));
Console.WriteLine("Puzzle Two Day2: " + Day2.SolvePartTwo(day2));

// Day 3
Console.WriteLine("Puzzle One Day3: " + Day3.SolvePartOne(day3));
Console.WriteLine("Puzzle Two Day3: " + Day3.SolvePartTwo(day3));