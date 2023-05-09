using System;

class Program
{
    /// <summary>
    ///  �������������ᵽ���нӿڵĺô���������������������µ�Ա����
    ///  ��������ýӿڣ�����ÿ��Ա������һ���������࣬�����ͻ����׳���
    ///  ����нӿ�����Э��Լ���Ļ�����ôֻҪʵ���˽ӿھͿ϶��нӿ��������ķ���������ֻ���������á�
    ///  �ӿ���ʵ����ʵ��C++����Ķ�̳У���ΪC#ֻ�е��̳С�
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
        james1.work("���");
        james2.work("���");
        james3.work("FAE");
        ljames1.level(1);
        ljames2.level(2);
        ljames3.level(3);

    }
}
    /// <summary>
    /// �ӿ�
    /// </summary>
public interface IWorker { void work(string s); }
public interface ILevel  { void level(int i); }

class James1 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("�ҵ�������James1���ҵĹ�����" + s);
    }
}
class James2 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("�ҵ�������James2���ҵĹ�����" + s);
    }
}
class James3 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("�ҵ�������James3���ҵĹ�����" + s);       
    }
}

class LJames1 : ILevel
{
    public void level(int i)
    {
        Console.WriteLine("�ҵĵȼ���" + i);
    }
}
class LJames2 : ILevel
{
    public void level(int i)
    {
        Console.WriteLine("�ҵĵȼ���" + i);
    }
}
class LJames3 : ILevel
{
    public void level(int i)
    {
        Console.WriteLine("�ҵĵȼ���" + i);
    }
}