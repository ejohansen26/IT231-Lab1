namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Console.Write("Enter 1st number: ");
			int num1 = Int32.Parse(Console.ReadLine());
			Console.Write("Enter 2nd number: ");
			int num2 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("The sum of those numbers is " + Addition(num1, num2));
		}
		static int Addition(int num1, int num2) => num1 + num2;
	}
}