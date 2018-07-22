﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Any part that implements the interface ESWeapon
    // can replace that part in any ship

    public interface ESWeapon
    {

        // User is forced to implement this method
        // It outputs the string returned when the 
        // object is printed

        String toString();

    }
}
