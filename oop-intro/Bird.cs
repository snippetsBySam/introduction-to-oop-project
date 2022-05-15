using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_intro
{
    public abstract class Bird : IDance
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Speak();

        public virtual void Fly()
        {
            Console.WriteLine("Hi there! I can fly.");
        }

        public void Spin()
        {
            Console.WriteLine($"{Name} spin!");
        }

        public void DoTheCaterpillar()
        {
            Console.WriteLine($"{Name} do the wriggly woo!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jump in the air!");
        }
    }
}
