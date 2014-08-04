using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeagueTable.IntegrationTests
{
    using System.IO;

    using LeagueTable;

    [TestClass]
    public class ProgramIntegrationTests
    {
        [TestMethod]
        public void MinimumGoalDifferenceIsLeeds()
        {
            var console = new StringWriter();
            Console.SetOut(console);

            Program.Main(new[] { @".\Data\leaguetable.txt" });

            // Leeds have the lowest goal difference
            Assert.AreEqual("Lowest goal difference is: Leeds United (-39)", console.ToString().Trim());
        }
    }
}