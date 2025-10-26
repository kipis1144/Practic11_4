using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Alex = new Player(5, 100);
            Alex.TakeDamage(30);
            Alex.TakeDamage(20);
            Alex.TakeDamage(40);
            Alex.TakeDamage(10);
        }
    }
}
