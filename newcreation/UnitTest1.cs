using System;
using Xunit;

namespace newcreation
{ 
    public class UnitTest1
    { 
        [Fact]
        public void Test1()
        {

            var num = 0;
                while (num <=100) 
                {

                if (num % 5 === 0 && num % 3 === 0) {
                console.log("FizzBuzz")   
                }
                else if (num % 3 === 0 ) {
                console.log("Fizz")   
                }

                else if (num % 5 === 0 ) {
                console.log("Buzz")   
                }

                else {
                console.log(num);
                }

                num++;
                }
                }
                }
                }





        }
    }
}
