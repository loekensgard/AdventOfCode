namespace AdventOfCode._2023.Day8
{
    public static class Day8
    {
        public static string SolvePartOne(string[] lines)
        {
            var instructions = lines[0];
            var network = GetNodes(lines);

            var currentNode = "AAA";
            var steps = 0;

            while (true)
            {
                bool foundZZZ = false;

                for (int i = 0; i < instructions.Length; i++)
                {
                    char direction = instructions[i];
                    currentNode = (direction == 'L') ? network[currentNode].left : network[currentNode].right;
                    steps++;

                    if (currentNode == "ZZZ")
                    {
                        foundZZZ = true;
                        break;
                    }
                }

                if (foundZZZ)
                {
                    break;
                }
            }

            return steps.ToString();
        }

        private static Dictionary<string, (string left, string right)> GetNodes(string[] lines)
        {
            Dictionary<string, (string left, string right)> network = new();


            foreach (string line in lines.Skip(1))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        // Trim any extra spaces
                        string key = parts[0].Trim();
                        string values = parts[1].Trim(' ', '(', ')');

                        // Split the values into left and right
                        string[] valueParts = values.Split(',');

                        if (valueParts.Length == 2)
                        {
                            // Trim any extra spaces from each value
                            string left = valueParts[0].Trim();
                            string right = valueParts[1].Trim();

                            // Add to the dictionary
                            network.Add(key, (left, right));
                        }
                    }
                }
            }

            return network;
        }

        public static string SolvePartTwo(string[] lines)
        {
            var instructions = lines[0];
            var network = GetNodes(lines);

            //Bleh

            return 0.ToString();
        }

    }
}
