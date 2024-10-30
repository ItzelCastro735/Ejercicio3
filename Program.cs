// See https://aka.ms/new-console-template for more information



using System.Numerics;
using exercise3.V2;

Console.WriteLine("Hello, World!");

Double width =  Double.Parse( Console.ReadLine());
Double height = Double.Parse(Console.ReadLine());


/*var (perimeter, area, diagonal) = RectangleCalculator.CalculateRectangleProperties(19, 20);


Console.WriteLine(perimeter);
Console.WriteLine(area);
Console.WriteLine(diagonal);
*/ 

var Calculator = new exercise3.V2.RectangleCalculator(width, height);

 
 


Console.WriteLine( Calculator.GetArea());

Console.WriteLine(Calculator.GetPerimeter());

Console.WriteLine(Calculator.GetDiagonal());

