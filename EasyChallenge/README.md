# Overview

The point of this exercise is to see how you think through problems and design solutions. It's important that the solution you provide meets all the requirements as well as demonstrates clean code and a polished solution.

# Original FizzBuzz Problem

Write a program to output the first 100 numbers except where the is a multiple of 3 or 5. When the number is a multiple of 3 print "Fizz", when the number is a multiple of 5, print "Buzz", when the number is a multiple of both 3 and 5, print "FizzBuzz"
Example output:
1
2
Fizz
4
Buzz
...
97
98
Fizz
Buzz

# FizzBuzz With A Twist Requirements

1. Create a C# library called TwistedFizzBuzz that can:

	- Accept user input for a range of numbers and returns their FizzBuzz output. For example, 1-50, 1-2,000,000,000, or (-2)-(-37)

	- Accept user input of a non-sequential set of numbers and returns their FizzBuzz output. For example: -5, 6, 300, 12, 15

	- Accept user input for alternative tokens instead of "Fizz" and "Buzz" and alternative divisors instead of 3 and 5. For example, 7, 17, and 3 would use "Poem", "Writer", and "College". 119 would output "PoemWriter", 51 would output "WriterCollege", 21 would output "PoemCollege, and 357 would output "PoemWriterCollege"

	- Accept user input for API generated tokens provided by [https://rich-red-cocoon-veil.cyclic.app/](https://rich-red-cocoon-veil.cyclic.app/)

2. Write a C# console application that uses the TwistedFizzBuzz library to solve the standard FizzBuzz Problem.

3. Write another C# console application that uses the TwistedFizzBuzz library to do the following:

	- Output values from -20 to 127

	- For multiples of 5 print "Fizz"

	- For multiples of 9 print "Buzz"

	- For multiples of 27 print "Bar"

	- For multiples where more than one number from above matches, print the appropriate concatenated tokens

4. Include tests for the TwistedFizzBuzz library and anything else you deem appropriate

5. Commit your code to a Github repository and share the link back with us

# Guidelines

- The final solution should have at least 4 projects in it, the TwistedFizzBuzz library, the two console applications, and at least one test project

- The console applications should not take in any command line arguments or user input, just output to the console per the above requirements

- Use good judgement and keep things as simple as necessary, but do make sure the submission does not feel unfinished or thrown together

- This should take 1-3 hours to complete