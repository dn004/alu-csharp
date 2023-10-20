using NUnit.Framework;
using MyMath;

namespace Tests
{
    /// <summary>
    /// This class contains test methods for the 'Add' operation in the 'Opps' class.
    /// </summary>
    [TestFixture]
    public class Test_NumberAddition
    {
        private Operations _myMath;

        /// <summary>
        /// This method is called before each test to set up the test environment.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _myMath = new Operations();
        }

        /// <summary>
        /// Test if addition of two numbers is equal to 4.
        /// </summary>
        [Test]
        public void AdditionOperation()
        {
            bool state = false;
            if (Operations.Add(2, 2) == 4)
            {
                state = true;
            }
            Assert.IsTrue(state, "State is True");
        }
    }
}
