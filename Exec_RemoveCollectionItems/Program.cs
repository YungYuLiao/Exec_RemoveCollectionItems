using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		static void Main(string[] args)
		{ //在集合中移除多個項目
			List<string> list = new List<string>{"Annie","Bill","Cara","Dorthy","Elle","Flora"};
			list.RemoveRange(0,1); //移除一個範圍 (0,1)表示從0號位移除1個
			list.Remove("Cara"); //移除單個項目
			list.RemoveAt(list.Count-2); //索引處項目
			//list.RemoveAll(list.Contains); //移除所有,可用list.Clear()
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			

		}
	}
}
