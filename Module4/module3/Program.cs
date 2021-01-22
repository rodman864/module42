using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using module3.MyClasses;
using module3.Module;

namespace module3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cakes MyClasses = new Cakes();
            MyClasses.AddFlavor(new Cakes());



            BirthdayCake<string> Module = new BirthdayCake<string>();
            Module.Flavor = "Chocolate";

            Console.WriteLine("I don't like my birthday cake because it has the flavor of " + Module.Flavor);
            Console.WriteLine("My favorite flavor is" + MyClasses);



        }
    }
    
}

