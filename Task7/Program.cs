using System;
using System.Drawing;
using Task7.Interfaces;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem-1
            //Car car1 = new Car();
            //Console.WriteLine(car1);

            //Car car2 = new Car(10);
            //Console.WriteLine(car2);

            //Car car3 = new Car(20,"BMW");
            //Console.WriteLine(car3);

            //Car car4 = new Car(30, "Mercedes", 3503);
            //Console.WriteLine(car4);
            #endregion

            #region Question-1
            // because when you define a construcrtor, the Compiler will think that you no longer will need the default one and you will need to define it
            // yourself or it will suppresses the default constructor. This to ensure that the compiler doesn't make a mistake and define these variables with
            // default values.
            #endregion

            #region Problem-2
            //Calculator Calc1 = new Calculator();
            //Console.WriteLine(Calc1.sum(2, 3));
            //Console.WriteLine(Calc1.sum(3,4,5));
            //Console.WriteLine(Calc1.sum(2.8, 7.2));
            #endregion

            #region Question-2
            // It enhances that by writing the functions one time and with one common name of them, I can use any of them based on input type
            // without need to remember each one's name.
            #endregion

            #region Problem-3
            //Child child = new Child(10, 50, 70);
            //Console.WriteLine(child);
            #endregion

            #region Question-3
            // to stop declaring attributes again and use the same attributes declared and initialized in the parent class.
            // as all attributes present on the father class are being inherited by his children automatically without need to declare and initialize.
            // that improves readability and reuseability and decreases redundance.
            #endregion

            #region Problem-4
            //Child child1 = new Child(3, 4, 5);
            //Console.WriteLine(child1.Product());
            //Console.WriteLine(child1.Product1());
            #endregion

            #region Question-4
            // new: it's more like to have a new method with the same name in a child class and hide this method in the father behavior
            // override: it changes the behaviour of the method in ths child class 
            #endregion

            #region Problem-5
            //Parent P1 = new Parent(4, 5);
            //Child C1 = new Child(7, 6, 7);
            //Console.WriteLine(P1);
            //Console.WriteLine(C1);
            #endregion

            #region Question-5
            // Because the original behaviour of .ToString() returns the solution name and class name.
            // this behaviour isn't favorable, so we need to override it.
            #endregion

            #region Problem-6
            //Rectangle R1 = new Rectangle(8, 2);
            //Console.WriteLine(R1.Area);
            //R1.Draw();
            #endregion

            #region Question-6
            // because the interface is like a code contract. it doesn't have any body of any method so it can't be implemented or mke an instance from it.
            #endregion

            #region Problem-7

            //IShape c1;
            //c1 = new Circle(10);
            //Console.WriteLine(c1.Area);
            //c1.PrintDetails();
            #endregion

            #region Question-7
            // to ease the process of add methods inside an interface that has same syntax that reduces redundance
            // also when there are classes that will use this method and others won't, this helps to solve this problem instead of make another interface
            #endregion

            #region Problem-8
            //IMovable CanItMove = new car();
            //CanItMove.Move();
            #endregion

            #region Question-8
            // to separate between original method and the numbers entering and leaving the method, so no unaccessible one can reach the method syntax.
            // it can be used by many classes not a specific one, so it reduces redundance in code writing and enhances readaility.
            // it applies polymorphism not like classes.
            #endregion

            #region Problem-9
            //File f1 = new File();
            //f1.Read();
            //f1.Write();
            #endregion

            #region Question-9
            // class can inherite from only one class, but C# allows to inherite from multiple interfaces in the same time.
            // Each interface can have a different method to use in it and the class can use any interface to do the required function.
            // This help to overcome the single inheritance.
            #endregion

            #region Problem-10
            //rectangle R1 = new rectangle();
            //R1.Draw();
            //R1.CalculateArea(10,20);
            #endregion

            #region Question-10
            // Virtual : it can be overriden, it doesn't need implementation, we can't change its body to work 
            // abstract : it can't be overriden, it needs implementation, we must change its body to work  
            #endregion
        }
    }
}
