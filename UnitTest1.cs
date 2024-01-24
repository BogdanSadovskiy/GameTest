
using myGame;                
namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Hero_Health_Cheking_Test1()
        {
            Juggernaut juggernaut = new myGame.Juggernaut();
            juggernaut.currenthealth = -2;
            int expectedHealth = 0;
            juggernaut.HealthCheking();
            Assert.AreEqual(expectedHealth, juggernaut.currenthealth);


        }
        [TestMethod]
        public void Hero_Health_Cheking_Test2()
        {
            Juggernaut juggernaut = new myGame.Juggernaut();
            juggernaut.currenthealth = 122323;
            int expectedHealth = juggernaut.Health;
            juggernaut.HealthCheking();
            Assert.AreEqual(expectedHealth, juggernaut.currenthealth);


        }
        [TestMethod]
        public void Hero_Health_Cheking_Test3()
        {
            Juggernaut juggernaut = new myGame.Juggernaut();
            int expectedHealth = juggernaut.currenthealth - 100;
            juggernaut.getAttacked(100, 100);
            Assert.AreEqual(expectedHealth, juggernaut.currenthealth + 20);


        }
    }
}