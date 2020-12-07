using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingAndOverriding
{
    class Animals
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine(" the animal make a sound");
        }
    }
    class FirstAnimal : Animals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("the first animal make sound is: Sound1");
        }
    }
    //class SecondAnimal
    //{
    //    public void AnimalSound()
    //    {
    //        Console.WriteLine("the second animal make sound is: Sound2");
    //    }
    //}

}
