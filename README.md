# API 2 AMP

A simple console application in C# showing a call to an API and converting it to a Google AMP article.

## Requirements

- Visual Studio 2015
- .NET Core	1.0.0-rc1 or greater
- Patience, if anything goes wrong

## How to use?

Open the project in Visual Studio 2015. Build the project, and run it. Once the console application finishes, you can find the files at `~/files/`.

## How does it works?

The application uses [jsonplaceholder.typicode.com](http://jsonplaceholder.typicode.com/) [posts](http://jsonplaceholder.typicode.com/posts) end-point as the test end-point. A file is created using a `StreamWriter`, and [Nustache](https://github.com/jdiamond/Nustache) to replace the placerholders in a template.

## Questions?

If you have any questions or suggestions regarding the code, please contact me: Jonathan Agosto <[hello@jonathanagosto.com](mailto:hello@jonathanagosto.com)>.