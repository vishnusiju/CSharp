using System;

namespace OverloadingAndOverriding
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            //int myNum1 = PlusMethod(8, 5);
            //double myNum2 = PlusMethod(4.3, 6.26);
            //Console.WriteLine("Int: " + myNum1);
            //Console.WriteLine("Double: " + myNum2);

            //Animals myAnimal = new Animals();
            //FirstAnimal myFirst = n ew FirstAnimal();
            //SecondAnimal mySecond = new SecondAnimal();


            //myAnimal.AnimalSound();
            //myFirst.AnimalSound();
            //mySecond.AnimalSound();

            Animals animal = new FirstAnimal();
            animal.AnimalSound();
        }
    }
}
