using Reqnroll;

namespace BoosterTest.Specifications.Helpers
{
    /// <summary>
    /// This helper class provides a way of passing an object between test split across different files
    /// </summary>
    public static class ScenarioContextExtensions
    {

        public static T Output<T>(this ScenarioContext self)
        {
            var output = (T?)self[nameof(Output)] ?? throw new ArgumentNullException(nameof(Output));
            return output;
        }

        public static void Output<T>(this ScenarioContext self, T value)
        {
            ArgumentNullException.ThrowIfNull(value);
            self[nameof(Output)] = value;
        }
    }
}