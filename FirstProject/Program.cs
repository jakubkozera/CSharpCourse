using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibrary;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(), new Rectangle(), new Triangle(),};

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}


