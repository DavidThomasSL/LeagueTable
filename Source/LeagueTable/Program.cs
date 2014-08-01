namespace LeagueTable
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            var filename = args[0];
            var reader = new StreamReader(filename);

            // Skip the header line
            reader.ReadLine();

            int lowestGoalDifference = int.MaxValue;
            while (reader.Peek() != -1)
            {
                var goalDifference = ParseGoalDifference(reader.ReadLine());

                if (goalDifference < lowestGoalDifference)
                {
                    lowestGoalDifference = goalDifference;
                }
            }

            Console.WriteLine("Lowest goal difference is: " + lowestGoalDifference);
        }

        public static int ParseGoalDifference(string rawClub)
        {
            var entries = rawClub.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return int.Parse(entries[8]);
        }
    }
}
