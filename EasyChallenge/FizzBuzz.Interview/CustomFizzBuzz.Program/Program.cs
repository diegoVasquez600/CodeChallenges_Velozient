using TwistedFizzBuzz.Library;

Console.WriteLine("Custom FizzBuzz Output Program");
int start = -20;
int end = 127;
List<(int, string)> divisorTokenPairs = new()
{
    (5, "Fizz"),
    (9, "Buzz"),
    (27, "Bar")
};

FizzBuzz fizzBuzz = new();
List<string> output = fizzBuzz.GenerateFizzBuzz(start, end, divisorTokenPairs);
foreach (var item in output)
{
    Console.WriteLine(item);
}
