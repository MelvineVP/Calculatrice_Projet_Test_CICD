using Calculatrice_test_Ci_CD;

namespace Projet_Test_Calculatrice
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculatrice calculatrice = new Calculatrice();

            Assert.Equal(10, calculatrice.Calculate("5+5"));

        }
    }
}