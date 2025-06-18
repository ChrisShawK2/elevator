namespace Elevator
{
    public class Elevator
    {
        const int _OneFloorTime = 10;
        public static int GetStartFloor()
        {
            int? startFloor = null;
            while (startFloor == null)
            {
                Console.WriteLine("Which floor is the elevator on now?  (type 'Q' to quit)");
                var answer = Console.ReadLine();
                if (answer?.ToUpper().StartsWith('Q') == true)
                {
                    throw new Exception("User cancelled");
                }

                if (int.TryParse(answer, out var floor))
                {
                    if (floor < 0)
                    {
                        Console.WriteLine("This elevator doesn't visit the basement");
                    }
                    else
                    {
                        startFloor = floor;
                    }
                }
            }
            return startFloor.Value;
        }

        public static IEnumerable<int> GetFloorsToVisit()
        {
            var valid = false;
            IEnumerable<int> floors = [];
            while (!valid)
            {
                Console.WriteLine("Which floors are to be visited?");
                Console.WriteLine("  Enter a comma-separated list of floor numbers (type 'Q' to quit)");
                var answer = Console.ReadLine();
                if (answer?.ToUpper().StartsWith('Q') == true)
                {
                    throw new Exception("User cancelled");
                }

                try
                {
                    floors = ParseFloorList(answer).ToArray();
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return floors;
        }

        private static IEnumerable<int> ParseFloorList(string? input)
        {
            var pieces = input?.Split(',') ?? [];
            foreach (var piece in pieces)
            {
                if (int.TryParse(piece.Trim(), out var floor))
                {
                    if (floor < 0)
                    {
                        throw new Exception("This elevator doesn't visit the basement");
                    }
                    else
                    {
                        yield return floor;
                    }
                }
                else
                {
                    throw new Exception($"Could not parse '{piece}'.");
                }
            }
        }

        public static void Simulate(int start, IEnumerable<int> floorsToVisit)
        {
            var totalTime = 0;
            List<int> floorsVisited = [];
            foreach (var floor in floorsToVisit)
            {
                totalTime += _OneFloorTime * Math.Abs(start - floor);
                floorsVisited.Add(floor);
                start = floor;
            }

            Console.WriteLine($"Floors Visited: {string.Join(", ", floorsVisited)}");
            Console.WriteLine($"Total Time:  {totalTime}");
        }
    }
}