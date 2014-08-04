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
            string lowestTeamName = string.Empty;
            while (reader.Peek() != -1)
            {
                var line = reader.ReadLine();
                var goalDifference = ParseGoalDifference(line);
                var teamName = ParseTeamName(line);

                if (goalDifference < lowestGoalDifference)
                {
                    lowestGoalDifference = goalDifference;
                    lowestTeamName = teamName;
                }
            }

            Console.WriteLine("Lowest goal difference is: {0} ({1})", lowestTeamName, lowestGoalDifference);
        }

        private static string ParseTeamName(string rawClub)
        {
            var entries = rawClub.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return entries[1];
        }

        public static int ParseGoalDifference(string rawClub)
        {
            var entries = rawClub.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return int.Parse(entries[8]);
        }
    }
}
