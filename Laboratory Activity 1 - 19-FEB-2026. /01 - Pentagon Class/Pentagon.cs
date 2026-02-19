using System;
					
public class Pentagon
{
	private double side;
	
	public Pentagon(){
		side = 0;
	}
	
	public Pentagon(double s){
		side = s;
	}
	
	public double GetPerimeter(){
		return 5 * side;
	}

	public double GetArea(){
		return Math.Sqrt((5 * (5 + 2 * Math.Sqrt(5))) * side * side) /4;
	}
	
	public void Display(string name){
		Console.WriteLine($"{name}");
		Console.WriteLine("------------------------");
		Console.WriteLine($"Side length: {side}");
		Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
		Console.WriteLine($"Area: {GetArea():F3}");
		Console.WriteLine();
		
	}
	
	public static void Main(){
		Pentagon p1 = new();
		Pentagon p2 = new(5);
		
	p1.Display("Pentagon p1");
	p2.Display("Pentagon p2");
	}
	
}

