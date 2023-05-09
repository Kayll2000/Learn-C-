using System;
using System.IO;
using System.Text;

namespace FileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ����һ�� StreamReader ��ʵ������ȡ�ļ� 
                // using ���Ҳ�ܹر� StreamReader
                using (StreamReader sr = new StreamReader("c:/test.txt", Encoding.UTF8))
                {
                    string line;

                    // ���ļ���ȡ����ʾ�У�ֱ���ļ���ĩβ 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // ���û���ʾ������Ϣ
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}