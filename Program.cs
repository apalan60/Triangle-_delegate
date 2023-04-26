using System.Data;
using System.Text;

namespace 星號三角形_delegate_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rowIndexNum = 10;

			var output = Triangle.GetTriangle(rowIndexNum, TriangleLeft);
			Console.WriteLine(output);

			var output2 = Triangle.GetTriangle(rowIndexNum, TriangleRight);
			Console.WriteLine(output2);

			var output3 = Triangle.GetTriangle(rowIndexNum, TriangleMid);
			Console.WriteLine(output3);

			var output4 = Triangle.GetTriangle(rowIndexNum, TriangleInverted);
			Console.WriteLine(output4);

		}


		/// <summary>
		/// 靠左三角形
		/// </summary>
		/// <param name="rowIndexNum"></param>
		/// <returns></returns>
		private static string TriangleLeft(int rowIndexNum)
		{
			StringBuilder sbrow = new StringBuilder();
			for (int rowIndex = 1; rowIndex <= rowIndexNum; rowIndex++)
			{
				string row = new string('*', rowIndex);
				sbrow.AppendLine(row);
			}
			return sbrow.ToString();

		}

		/// <summary>
		/// 靠右三角形
		/// </summary>
		/// <param name="rowIndexNum"></param>
		/// <returns></returns>
		private static string TriangleRight(int rowIndexNum)
		{
			StringBuilder sbrow = new StringBuilder();
			for (int rowIndex = 1; rowIndex <= rowIndexNum; rowIndex++)
			{
				string row = new string('*', rowIndex);
				row = row.PadLeft(rowIndexNum);
				sbrow.AppendLine(row);
			}
			return sbrow.ToString();
		}

		/// <summary>
		/// 置中三角形
		/// </summary>
		private static string TriangleMid(int rowIndexNum)
		{
			StringBuilder sbrow = new StringBuilder();
			for (int rowIndex = 1; rowIndex <= rowIndexNum; rowIndex++)
			{
				string spaces = new string(' ', rowIndexNum - rowIndex);
				string row = new string('*', rowIndex * 2 - 1);
				sbrow.AppendLine(spaces + row);

			}
			return sbrow.ToString();
		}

		/// <summary>
		/// 倒星形三角形
		/// </summary>
		private static string TriangleInverted(int rowIndexNum)
		{
			StringBuilder sbrow = new StringBuilder();
			for (int rowIndex = rowIndexNum; rowIndex >= 1; rowIndex--)
			{
				string spaces = new string(' ', rowIndexNum - rowIndex);
				string row = new string('*', rowIndex * 2 - 1);
				sbrow.AppendLine(spaces + row);

			}
			return sbrow.ToString();
		}
	}

	public class Triangle
	{
		public static string GetTriangle(int rowIndexNum, Func<int, string> func)
		{
			return func(rowIndexNum);
		}
	}


}