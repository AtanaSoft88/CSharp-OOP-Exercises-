﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person        
    {        
        public Child(string name, int age)
            :base(name,age)
        {
            if (age > 15)
            {
                Console.WriteLine("Age cant be more than 15");
                return;
            }
        
        }

        

    }
}
