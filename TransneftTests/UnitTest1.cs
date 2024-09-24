using TransneftTestTask.Classes;

namespace TransneftTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Тест по умолчанию.
        /// </summary>
        [Fact]
        public void StandartTest()
        {
            double testResult = -1.769;

            double factResult = new NewtonMethod().Calculate
                (
                    Functions.MainFunction, 
                    Functions.FirstDerivative,
                    Functions.SecondDerivative,
                    -4,
                    4, 
                    0.02
                );

            Assert.Equal(testResult, Math.Round(factResult, 3));
        }
    }
}