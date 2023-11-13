using TwistedFizzBuzz.Library;

var fizzBuzz = new FizzBuzz();
int start = 1;
int end = 100;
var output = fizzBuzz.GenerateFizzBuzz(start, end);
foreach (var result in output)
{
    Console.WriteLine(result);
}

