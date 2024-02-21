using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETGTVT
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string textData = "nguyen12themanh26";
			int[] a = { 2, 3, 1, 2, 5, 6, 10, 3, 4, 5 };
			MaxandMax(a);
			//int index = 0;
			//int min = int.MaxValue;
			//int max = int.MinValue;
			//foreach (char c in textData)
			//{
			//	if (char.IsDigit(c))
			//	{

			//		if (int.Parse(c.ToString()) < min)
			//			min = int.Parse(c.ToString());
			//		if (int.Parse(c.ToString()) > max) max = int.Parse(c.ToString());
			//	}
			//	index++;
			//}
			//Console.WriteLine($"Gia tri min: {min} Gia tri max : {max}");
			////// nhap so nguyen duong
			//int x;
			//Console.WriteLine("Nhap so nguyen duong x: ");
			//x = int.Parse(Console.ReadLine());
			//ValidateSoX(x);
			//if (CheckSoNguyenTo(x) == true)
			//		Console.WriteLine($" So nguyen to x : {x}");
			//else Console.WriteLine("Khong phai so nguyen to");

			//private static void ValidateSoX(int s)
			//{
			//	while (s < 0)
			//	{
			//		Console.WriteLine("Nhap lai so nguyen duong : ");
			//		s = int.Parse(Console.ReadLine());	
			//	}
			//}
			//private static bool CheckSoNguyenTo(int x)
			//{
			//	if (x < 2)
			//	{
			//		return false;

			//	}

			//	for (int i = 2; i <= x / 2; i++)
			//		{
			//			if (x % i == 0)
			//				return false;
			//		}

			//	return true;

			//}
			//1. đầu vào là 1 mảng giá trị gồm các số nguyên
			// in ra màn hình giá trị lớn thứ 2 và bé thứ 2 trong mảng

			//2. đầu vào là 1 chuỗi text gồm số và chữ ( ko có ký tự - hay + )
			// đưa ra chuỗi các ký tự ko chứa số trong đó dài nhất trong chuỗi
			//abcbc123xyx1abciabcjancajo ===> abciabcjancajo

			//3. nhập vào màn hình 1 số bất kỳ.
			// đưa ra giá trị các số nguyên tố nằm giữa 0 và nó
			string text = "a-bc-12xyx-1-2b123";
			CheckSumText(text);
			//4. đầu vào là 1 chuỗi text gồm số và chữ ( có chứa ký tự - , ko chứa ký tự +)
			// tính tổng các ký tự là số trong chuỗi đó : lưu ý : a-bc-12xyx-1-2b123 ==> -12 + -1 + -2 + 123 = tổng
		}
		static void CheckSumText(string text)
		{
			int sum = 0;
			string currentNumber = "";

			for (int i = 0; i < text.Length; i++)
			{
				if (char.IsDigit(text[i]) || text[i] == '-')
				{
					currentNumber += text[i];
				}
				else if (currentNumber.Length > 0)
				{
					sum += int.Parse(currentNumber);
					currentNumber = "";
				}
			}
			if (!string.IsNullOrEmpty(currentNumber))
			{
				if (int.TryParse(currentNumber, out int number))
				{
					sum += number;
				}
				else
				{
					Console.WriteLine($"Invalid number format: {currentNumber}");
				}
			}

			Console.WriteLine($"Tong cua day : {sum}");
		}
		static void ListNumberPrime(int[] list,int z)
		{
			for (int i = 0;i<z;i++)
			{
				if (CheckPrime(list[i]))
					Console.Write(list[i]+" ");
			}	
		}

		static bool CheckPrime(int x)
		{
			if(x<2)
			{
				return false;
			}	
			for (int i=0;i<=x/2;i++)
			{
				if (x % i == 0)
					return false;
			}
			return true;
		}
		static void ChuoiLength(string text)
		{
			string currentSubstring = "";
			string longestSubstring = "";
			for (int i = 0; i < text.Length; i++)
			{
				if (char.IsLetter(text[i]))
				{
					currentSubstring += text[i];
				}
				else
				{
					if (currentSubstring.Length > longestSubstring.Length)
					{
						longestSubstring = currentSubstring;
					}
					currentSubstring = "";
				}
			}
			if (currentSubstring.Length > longestSubstring.Length)
			{
				longestSubstring = currentSubstring;
			}
			Console.WriteLine(longestSubstring);
		}
		static void MaxandMax(int[] list)
		{
			int max = list[0];
			int max1 = list[1];

			for (int i = 0; i < list.Length; i++)
			{
				if (list[i] > max)
				{
					max1 = max; // Update max2 before updating max
					max = list[i];
				}
				else if (list[i] > max1 && list[i] != max)
				{
					max1 = list[i];
				}
			}
			Console.WriteLine($"Max : {max}" );
			Console.WriteLine($"Max t2 : {max1}");
		}
	}
}
