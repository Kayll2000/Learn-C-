using System;
using System.IO;

namespace WindowsFileApplication
{
    class Program
    {
        /// <summary>
        /// 编译和执行上面的程序时，它会显示文件的名称及它们在 Windows 目录中的大小。
        /// </summary>
        static void Main(string[] args)
        {
            // 创建一个 DirectoryInfo 对象
            DirectoryInfo mydir = new DirectoryInfo(@"c:\WindowsTest");

            // 获取目录中的文件以及它们的名称和大小
            FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}",
                                    file.Name, file.Length);
            }
            Console.ReadKey();
        }
    }
}