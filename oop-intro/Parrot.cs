using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_intro
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} wanna cracker!");
        }
    }
}
