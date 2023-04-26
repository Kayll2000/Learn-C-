using System;
namespace CommonOpt
{
    /// <summary>
    /// 常用指令
    /// </summary>
    class CommonLua
    {
        void static void Main(string[] args)
        {
            Console.Write("test");//输出不换行
            Console.WriteLine("test");//输出换行
    
            Console.ReadKey();//在控制台窗口停留一下，直到敲击键盘
            Console.ReadLine();//输出任意东西回车才会退出，会等待直到用户按下回车，一次读入一行。[读取键盘输入的所有字符，返回字符串。]
            Console.Read();//输出任意东西回车才会退出，会等待直到用户按下回车，一次读入一行。[读取键盘输入的第一个字符，返回其对应的ASCII值。]
        }
    }
}