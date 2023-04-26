using System;

namespace 星號三角形_delegate_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rowIndexNum = 10;
			int rowIndex = 1;

			Console.WriteLine(Triangle.GetTriangle(rowIndexNum, rowIndex, Triangle.TriangleLeft));
			Console.WriteLine(Triangle.GetTriangle(rowIndexNum, rowIndex, Triangle.TriangleRight));
			Console.WriteLine(Triangle.GetTriangle(rowIndexNum, rowIndex, Triangle.TriangleMid));
			Console.WriteLine(Triangle.GetTriangle(rowIndexNum, rowIndex, Triangle.TriangleInverted));

		}
	}
}

public class Triangle
{
	/// <summary>
	/// 
	/// </summary>
	/// <param name="rowIndexNum">三角形共幾行</param>
	/// <param name="rowIndex">初始值在第幾行</param>
	/// <param name="pattern">三角形每一行如何呈現</param>
	/// <returns></returns>
	public static string GetTriangle(int rowIndexNum, int rowIndex, Func<int, int, string> pattern)
	{
		string result = string.Empty;
		for (rowIndex = 1; rowIndex <= rowIndexNum; rowIndex++)
		{
			result += pattern(rowIndexNum, rowIndex) + "\n";
		}
		return result;
	}

	public static string TriangleLeft(int rowIndexNum, int rowIndex)
	{
		return new string('*', rowIndex);
	}

	public static string TriangleRight(int rowIndexNum, int rowIndex)
	{
		return new string(' ', rowIndexNum - rowIndex) + new string('*', rowIndex);
	}

	public static string TriangleMid(int rowIndexNum, int rowIndex)
	{
		return new string(' ', rowIndexNum - rowIndex) + new string('*', rowIndex * 2 - 1);
	}

	public static string TriangleInverted(int rowIndexNum, int rowIndex)
	{
		return new string(' ', rowIndex - 1) + new string('*', Math.Abs((rowIndex - rowIndexNum) * 2 - 1));
	}
}
