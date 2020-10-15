using Shouldly; // I really like this assertion library and use it quite often at work
using Xunit;

namespace newcreation
{ 
    public class FizzBuzzTests
    {
        // I wanted to play around with the new C# 8 inline switch statement
        private string GetFizzBuzzByValue(int value) => value switch
        {
            var x when x % 5 == 0 && x % 3 == 0 => "FIZZBUZZ",
            var x when x % 5 == 0 => "BUZZ",
            var x when x % 3 == 0 => "FIZZ",
            _ => value.ToString()
        };

        // I cleaned up your function so that it made it easier to test
        private string GetFizzBuzzByValue2(int value)
        {
            if (value % 5 == 0 && value % 3 == 0)
            {
                return "FIZZBUZZ";
            }
            if (value % 3 == 0 )
            {
                return "FIZZ";
            }
            return value % 5 == 0 
                ? "BUZZ" 
                : value.ToString();
        }

        [Theory] // theory allows us to build a ton of tests based on the "inlinedata" you see below.
                 // This builds 14 tests and it checks both implementations
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "FIZZ")]
        [InlineData(5, "BUZZ")]
        [InlineData(6, "FIZZ")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "FIZZ")]
        [InlineData(10, "BUZZ")]
        [InlineData(11, "11")]
        [InlineData(12, "FIZZ")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FIZZBUZZ")]
        public void TestFizzBuzz(int value, string result)
        {
            GetFizzBuzzByValue(value)
                .ShouldBe(result);
            GetFizzBuzzByValue2(value)
                .ShouldBe(result);
        }
    }
}