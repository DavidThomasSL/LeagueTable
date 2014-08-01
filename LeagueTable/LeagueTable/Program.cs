namespace LeagueTable
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("You must pass in the filename you want to read as an argument");
                return;
            }

            var filename = args[0];


            var reader = new StreamReader(filename);

            // Skip the header line
            reader.ReadLine();

            int minimumGoalDifference = int.MaxValue;
            while (reader.Peek() != -1)
            {
                try
                {
                    var goalDifference = ParseGoalDifference(reader.ReadLine());

                    if (goalDifference < minimumGoalDifference)
                    {
                        minimumGoalDifference = goalDifference;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to parse club");
                }
            }

            Console.WriteLine("Minimum goal difference is: " + minimumGoalDifference);
        }

        public static int ParseGoalDifference(string rawClub)
        {
            var entries = rawClub.Split(new [] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            return int.Parse(entries[8]);
        }
    }
}
