using System;

class Program
{
    /// <summary>
    ///  从这个例子我体会到了有接口的好处，可以想象如果又来了新的员工。
    ///  如果不采用接口，而是每个员工都有一个单独的类，这样就会容易出错。
    ///  如果有接口这种协议约束的话，那么只要实现了接口就肯定有接口里声明的方法，我们只需拿来调用。
    ///  接口其实就是实现C++里面的多继承，因为C#只有单继承。
    /// </summary>
    /// 
    static void Main(string[] args)
    {
        IWorker james1 = new James1();
        IWorker james2 = new James2();
        IWorker james3 = new James3();
        ILevel ljames1 = new LJames1();
        ILevel ljames2 = new LJames2();
        ILevel ljames3 = new LJames3();
        james1.work("设计");
        james2.work("编程");
        james3.work("FAE");
        ljames1.level(1);
        ljames2.level(2);
        ljames3.level(3);

    }
}
    /// <summary>
    /// 接口
    /// </summary>
public interface IWorker { void work(string s); }
public interface ILevel  { void level(int i); }

class James1 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("我的名字是James1，我的工作是" + s);
    }
}
class James2 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("我的名字是James2，我的工作是" + s);
    }
}
class James3 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("我的名字是James3，我的工作是" + s);       
    }
}

class LJames1 : ILevel
{
    public void level(int i)
    {
        Console.WriteLine("我的等级是" + i);
    }
}
class LJames2 : ILevel
{
    public void level(int i)
    {
        Console.WriteLine("我的等级是" + i);
    }
}
class LJames3 : ILevel
{
    public void level(int i)
    {
        Console.WriteLine("我的等级是" + i);
    }
}