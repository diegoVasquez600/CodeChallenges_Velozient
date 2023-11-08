# Overview

The point of this brief exercise is to help us better understand your ability to work through problems, design solutions, and work in an existing codebase. It's important that the solution you provide meets all the requirements, demonstrates clean code, and is scalable.

# Code

There are 3 projects in this solution:

## SmartVault.CodeGeneration

This project is used to generate code that is used in the SmartVault.Program library.

## SmartVault.DataGeneration

This project is used to create a test sqlite database.

## SmartVault.Program

This project will be used to fulfill some of the requirements that require output.

# Requirements

1. Speed up the execution of the SmartVault.DataGeneration tool. Developers have complained that this takes a long time to create a test database.

2. All business objects should have a created on date.

3. Implement a way to output the contents of every third file of an account to a single file, if the file contains the text "Smith Property".

4. Implement a way to get the total file size of all files, get the file size from the actual file as the database may be out of sync with the actual size.

5. Add a new business object to support OAuth integrations (No need to implement an actual OAuth integration, just the boilerplate necessary in the given application)

6. Commit your code to a github repository and share the link back with us

# Guidelines

- There should be at least one test project

- This project uses [Source Generators](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) and should be run in Visual Studio 2022

- You may create any additional projects to support your application, including test projects.

- Use good judgement and keep things as simple as necessary, but do make sure the submission does not feel unfinished or thrown together

- This should take 2-4 hours to complete