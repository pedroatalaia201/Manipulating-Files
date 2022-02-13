using System;
using System.IO;

namespace Helper
{
	class FileHelper
	{
		public void ListDirectories(string path)
		{
			var paths = Directory.GetDirectories(path, "*", SearchOption.AllDirectories); //This will return a array, that's the why of the var;

			foreach(string returndePath in paths)
			{
				Console.WriteLine(returndePath);
			}
		}

		public void ListFilesDirectories(string path)
		{
			var paths = Directory.GetFiles(path);

			foreach(string returndePath in paths)
			{
				Console.WriteLine(returndePath);
			}			
		}
	}
}
