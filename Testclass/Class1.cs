using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnitDemonstration;

namespace TestClass
{
    [TestFixture]
    public class TriangleTest1
    {
        [Test]

        public void ValidTriangle_Input()
        {
            //Arrange
            int firstangle = 60;
            int secondangle = 60;
            int thirdangle = 60;

            string expected = " The traingle is valid";

            //Act
            string actual = Triangle.ValidTriangle(firstangle, secondangle, thirdangle);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}