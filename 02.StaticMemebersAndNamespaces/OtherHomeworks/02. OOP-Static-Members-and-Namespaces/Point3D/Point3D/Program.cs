﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point somePoint = new Point(3,4,5);
            Console.WriteLine(somePoint.ToString());
        }
    }
}