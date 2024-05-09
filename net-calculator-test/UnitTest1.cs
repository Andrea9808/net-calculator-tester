using net_calculator_tester;

namespace net_calculator_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1.0f, 2.0f)]
        public void AddTest(float num1 , float num2)
        {
            try
            {
                Calcolatrice calcolatrice = new Calcolatrice();
                float somma = num1 + num2;
                float result = Calcolatrice.Add(num1, num2);

                Assert.AreEqual(somma, result, $"La somma di {num1} e {num2} deve essere uguale a {somma}");
            }
            catch(Exception e) 
            {
                Assert.Fail("Eccezione: " + e.Message);
            }
        }


        [Test]
        [TestCase(4.0f, 0.0f)]// se inserisce il num 2 più altro andrà in errore
        public void SubstractTest(float num1, float num2)
        {
            try
            {
                Calcolatrice calcolatrice = new Calcolatrice();
                float differenza = num1 - num2;
                float result = Calcolatrice.Substract(num1, num2);

                Assert.GreaterOrEqual(result, 0, $"La differenza tra {num1} e {num2} deve essere positiva");
            }
            catch(Exception e)
            {
                Assert.Fail("Eccezione: " + e.Message);
            }
        }
    }
}