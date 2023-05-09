using System;
namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }

            Value myvalue = new Value();
            try
            {
                myvalue.addvalue(10);
                myvalue.showvalue();
            }
            catch (OverMaxException ex)
            {
                Console.WriteLine("�쳣���:{0}",ex.Message);
            }

            Console.ReadKey();
        }
    }
}
    /// <summary>
    /// �û��Զ�����쳣���������� ApplicationException �ࡣ
    /// </summary>
public class TempIsZeroException : ApplicationException
{
    public TempIsZeroException(string message) : base(message)
    {
    }
}
public class OverMaxException : ApplicationException
{
    public OverMaxException (string message) : base(message)
    {

    }
}
public class Temperature
{
    int temperature = 10;
    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}
public class Value
{
    int value = 1;
    public void addvalue(int i)
    {
        value += i;
    }
    public void showvalue()
    {
        if(value > 10)
        {
            throw (new OverMaxException("�Ѿ�������10 -- MAX"));
        }
        else
        {
            Console.WriteLine("value is :{0}", value);
        }
    }
        }