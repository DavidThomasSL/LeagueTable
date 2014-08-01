namespace LeagueTable.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ParseGoalDifferenceParsesGoalDifference()
        {
            Assert.AreEqual(-1, Program.ParseGoalDifference("12 	Southampton 	38 	12 	11 	15 	44 	45 	-1 	47"));
        }
    }
}
