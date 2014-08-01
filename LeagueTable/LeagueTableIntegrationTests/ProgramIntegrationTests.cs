using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeagueTableIntegrationTests
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

            Program.Main(new [] {"..\\..\\..\\..\\assets\\leaguetable.txt"});

            Assert.AreEqual("Minimum goal difference is: -39", console.ToString().Trim());
        }
    }
}
