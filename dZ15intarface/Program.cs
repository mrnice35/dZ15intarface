using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dZ15intarface
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(3, 7);// создаем экземпляр класса и указываем шаг арифметической прогрессии и первый член
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Следующее число прогрессии" + (arithProgression.getNext() + 3 * (i - 1)));
            Console.WriteLine("\nСбросить");
            arithProgression.reset();
            GeomProgression geomProgression = new GeomProgression(3, 7);// создаем экземпляр класса и указываем шаг геометрической прогрессии и первый член
            for (int i = 1; i < 10; i++)
                Console.WriteLine("Следующее число прогрессии" + (geomProgression.getNext()* Math.Pow(3,(i-1))));
            Console.WriteLine("\nСбросить");
            geomProgression.reset();


            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);// метод устанавливающий начальное значение
        int getNext();//медтод возвращающий следующее число ряда
        void reset();// метод выполняющий сброс к начальному значению
    }
    class ArithProgression : ISeries

    {
        int start;// поле начального значения
        int b;// поле шаг геометрической прогрессии 
        int val;



        public ArithProgression(int B, int Start) //конструктор
        {
            start = Start;
            b = B;
            val = 0;

        }
        public int getNext()
        {

            val = start + b;
            return val;

        }

        public void reset()
        {
            val = start;
            Console.WriteLine("вернуться к начальному значению {0}", val);
        }

        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class GeomProgression : ISeries
    {
        int start;// поле начального значения геометрической прогрессии
        int b;// поле шаг геометрической прогрессии 
        int val;

        public GeomProgression(int B, int Start) //конструктор
        {
            start = Start;
            b = B;
            val = 0;
        }
        public int getNext()
        {

            val = start * b;
            return val;
        }
        public void reset()
        {
            val = start;
            Console.WriteLine("вернуться к начальному значению {0}", val);
        }

        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
}