using Moq;
using NUnit.Framework;

namespace TestDemo.UnitTests
{
    [TestFixture]
    public class StringCalculator_UnitTests
    {
        [Test]
        public void Add_EmptyString_Returns_0()
        {
            StringCalculator calc = new StringCalculator();
            int expectedResult = 0;
            int result = calc.Add("");
            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void Add_SingleNumber_ReturnTheNumber()
        {
            StringCalculator calc = new StringCalculator();
            int expectedResult = 5;
            int result = calc.Add("5");
            Assert.AreEqual(expectedResult, result);

        }


        [Test]
        public void Add_AddsTwoNumbers_Calculated()
        {
            // Arrange
            StringCalculator calc = new StringCalculator();

            //Act
            int sum = calc.Add2(2, 4);

            //Assert
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;

            Assert.AreEqual(x, y);
        }


     

        public class StringCalculator
        {
            public int Add(string input)
            {
                if (string.IsNullOrEmpty(input)) return 0;

                return int.Parse(input);
            }


            public int Add2(int x, int y)
            {
                return x + y;
            }
        }
    }
}
