using Reqnroll;

namespace ProjectHermes.Tests.Specifications.StepDefinitions
{

    /// <summary>
    /// This is just a simple demo, to show how reqnroll BBD tests work
    /// </summary>

    [Binding]
    public class AddTwoNumbersStepDefinitions
    {
        private readonly Calculator _calculator = new();

        [Given("I chose {int} as first number")]
        public void GivenIChoseAsFirstNumber(int firstNumber)
        {
            _calculator.SetFirstNumber(firstNumber);
        }

        [Given("I chose {int} as second number")]
        public void GivenIChoseAsSecondNumber(int secondNumber)
        {
            _calculator.SetSecondNumber(secondNumber);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            _calculator.AddNumbers();
        }

        [Then("the result should be {int} on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            var actualResult = _calculator.Result;

            Assert.Equal(expectedResult, actualResult);
        }


    }
    internal class Calculator
    {
        private int _first = default;
        private int _second = default;
        public int Result { get; internal set; } = default;

        internal void AddNumbers()
        {
            Result = _first + _second;
        }

        internal void SetFirstNumber(int firstNumber)
        {
            _first = firstNumber;
        }

        internal void SetSecondNumber(int secondNumber)
        {
            _second = secondNumber;
        }
    }
}