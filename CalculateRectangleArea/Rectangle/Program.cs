using RectangleProject;
using System;
/*The first statement in any C# program is (using System)
The using keyword is used for including the namespaces in the program.
A program can include multiple using statements.*/ //this is a multiline comments
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProject
{
    class Rectangle
// The class keyword is used for declaring a class
    {
        /*members variable.Variables are attributes or data members of a class,used for storing data.
        In the this program,the Rectangle class has two member variables named Length and Width*/
            double lenght;
        
            double width;
/*Member Functions are set of statements that perform a specific task.
The member functions of a class are declared within the class.Our sample class Rectangle contains three member functions:AcceptDetails,GetArea and Display.*/       
            public void Acceptdetails()
        {
            lenght = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return lenght * width;
        }
        public void Display()
        {
            Console.WriteLine("Lenght:{0}", lenght);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
        }
    }
/*Instantiating a Class -Instantiation is the creation of a real instance or particular realization of an abstraction or template such as a class of objects or a computer process. 
To instantiate is to create such an instance by, for example, defining one particular variation of object within a class, giving it a name, and locating it in some physical place.
In this program, the class ExecuteRectangle contains the Main() method and instantiates the Rectangle class.*/
class ExecuteRectangle
{
    static void Main(string[]args)
    {
        Rectangle r = new Rectangle();
        r.Acceptdetails();
        r.Display();
        Console.ReadLine();
    }
}

