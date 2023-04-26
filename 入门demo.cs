using System;

namespace GameDemoSpace
{
    /// <summary>
    /// 基类
    /// </summary>
    class Person
    {
        protected int power;//体力
        protected string name;//名字
        protected int energy;//能量条
        
        public void setname(string name)
        {
            this.name = name;
        }
        public void setpower(int power)
        {
            this.power = power;
        }
        public void setenergy(int energy)
        {
            this.energy =energy;
        }
        public int getpower()
        {return power;}
        public int getenergy()
        {return energy;}
        public string getname()
        {return name;}
    }

    /// <summary>
    /// BOSS类
    /// </summary>
    class Boss:Person//boss攻击
    {
    
        public void hurt()//伤害
        {
            power -= 5;//一次减5
            energy += 3;
        }
    }

    /// <summary>
    /// 士兵类
    /// </summary>
    class Soldier:Person//士兵进击
    {
    
        public  void attack()
        {
            power -= 10;
            energy += 5;
        }
        void addpower(int num)
        {
            power += num;
        }

    }
    
    class process
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            Soldier soldier = new Soldier();
            // Person p = new Person();
            soldier.setname("soldier");
            soldier.setpower(100);
            soldier.setenergy(0);

            boss.setname("boss");
            boss.setpower(100);
            boss.setpower(0);
            
            Console.WriteLine("boss power {0}",boss.getpower());
            boss.hurt();
            Console.WriteLine("boss power {0}",boss.getpower());
        }
    }
}