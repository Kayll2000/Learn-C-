using System;
using System.IO;

namespace WindowsFileApplication
{
    class Program
    {
        /// <summary>
        /// �����ִ������ĳ���ʱ��������ʾ�ļ������Ƽ������� Windows Ŀ¼�еĴ�С��
        /// </summary>
        static void Main(string[] args)
        {
            // ����һ�� DirectoryInfo ����
            DirectoryInfo mydir = new DirectoryInfo(@"c:\WindowsTest");

            // ��ȡĿ¼�е��ļ��Լ����ǵ����ƺʹ�С
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