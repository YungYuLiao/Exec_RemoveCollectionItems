using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person =	new Person();
			string height = person.GetHeight();
			string weight = person.GetWeight();
			try
			{
				double index = person.BMIcal(double.Parse(height), double.Parse(weight));
				string result = person.Display(index);
				Console.WriteLine($"您的BMI為{index.ToString("#.00")}，{result}");
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
				
		

		}
		class Person
		{
			public string GetHeight()
			{
				Console.Write("請輸入身高(公分): ");
				return Console.ReadLine();
			}
			public string GetWeight()
			{
				Console.Write("請輸入體重(公斤): ");
				return Console.ReadLine();
			}
			public double BMIcal(double height, double weight)
			{
				if (height <= 0 || weight <= 0)
				{
					throw new Exception("輸入數值不可小於或等於0");
				}
				double BMI = weight / Math.Pow(height/100, 2);
				return BMI;
			}
			public string  Display (double BMI)
			{
				string msg = String.Empty;
				if (BMI < 18.5)
				{
					msg = "體重過輕!";
				}
				else if (BMI < 24)
				{
					msg = "體重適中";
				}
				else if (BMI < 27)
				{
					msg = "體重過重!";
				}
				else if (BMI < 30)
				{
					msg = "輕度肥胖!";
				}
				else if (BMI < 35)
				{
					msg = "中度肥胖!";
				}
				else
				{
					msg = "重度肥胖!";
				}
				return msg;
			}
		}
	}
}
