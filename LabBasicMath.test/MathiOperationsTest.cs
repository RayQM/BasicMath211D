using BasicMath211D;

namespace LabBasicMath.test
{
    public class Tests
    {
        private MathOperations mathOpeatations;

        [SetUp]
          
        public void Setup()
        {
            mathOpeatations = new MathOperations();
        }

        [Test]
        public void TestAddTwoPlusTwo()
        {
            double expected = 4;
            double actual = mathOpeatations.Add(2, 2);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestOnesubstractFour()
        { 
            double expected = -3;
            double actual = mathOpeatations.Subtract(1, 4);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TesttwomultiplyTwo()
        { 
            double expected = 4;
            double actual = mathOpeatations.Multiply(2, 2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestEightDivdeTwo()
        { 
            double expected = 4;
            double actual = mathOpeatations.Divide(8, 2);
            Assert.AreEqual(expected, actual);
        }
        

    }   
}