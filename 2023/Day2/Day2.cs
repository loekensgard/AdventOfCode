namespace adventofcode._2023.Day2;

public static class Day2
{
    public static int SolvePartOne(string[] lines)
    {
        return GetCubesFromGame(lines).Where(game => game.Red <= 12 && game.Green <= 13 && game.Blue <= 14).Select(game => game.Id).Sum();
    }

    public static int SolvePartTwo(string[] lines)
    {
        return GetCubesFromGame(lines).Sum(game => game.Red * game.Green * game.Blue);
    }

    private static List<Game> GetCubesFromGame(string[] lines)
    {
        var games = new List<Game>();

        foreach (var line in lines)
        {
            var regex = RegexHelper.CubePattern();
            var cubes = regex.Matches(line);

            var game = new Game
            {
                Id = int.Parse(line.Replace(":", "").Split(" ")[1]),
                Red = cubes.Select(cubes => cubes.ToString().Split(" ")).Where(cubes => cubes[1] == "red").Select(cubes => int.Parse(cubes[0])).Max(),
                Green = cubes.Select(cubes => cubes.ToString().Split(" ")).Where(cubes => cubes[1] == "green").Select(cubes => int.Parse(cubes[0])).Max(),
                Blue = cubes.Select(cubes => cubes.ToString().Split(" ")).Where(cubes => cubes[1] == "blue").Select(cubes => int.Parse(cubes[0])).Max()
            };

            games.Add(game);
        }

        return games;
    }
}