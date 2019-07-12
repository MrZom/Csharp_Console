using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV30_General
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Level = Level.BigBoss;
            Console.WriteLine((int)Level.Manager);
            Console.ReadLine();
        }
    }
    enum Level
    {
       Employee,
       Manager,
       Boss,
       BigBoss,
    }
    class Person
    {
        public int ID { get; set; }
        public Level Level { get; set; }
    }
}
/*namespace TV30_General
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> fun = (a,b)=> { return a + b; };
            var resule = fun(1, 2);
            Console.WriteLine(resule);
            Console.ReadLine();
        }
    }

}*/
/*namespace TV30_General
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 1, 2, 3, 4 };
            double[] a3 = { 1.1, 2.1, 3.1, 4.1 };
            var result = Zip(a1, a3);
            Console.WriteLine(string.Join(",", result));
            Console.ReadLine();
        }
        static object[] Zip<T,C>(T[] A, C[] B)
        {
            object[] zipped = new object[A.Length + B.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < A.Length) zipped[zi++] = A[ai++];
                if (bi < B.Length) zipped[zi++] = B[bi++];
            } while (ai < A.Length || ai < B.Length);
            return zipped;
        }
    }

}*/
/*namespace TV30_General
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
          //  stu.Name = "aaa";
            stu.ID = 22;

        }
    }
    interface IUnique<Tid>
    {
        Tid ID { get; set; }
    }
    class Student : IUnique<ulong>
    {
        public ulong ID { get; set; }
    }
}*/
/*namespace TV30_General
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple { Color = "Red" };
            Book book = new Book { Name = "New book" };
            Box<Apple> box1 = new Box<Apple>(){ Cargo = apple };
            Box<Book> box2 = new Box<Book>(){ Cargo = book };
            Console.WriteLine(box1.Cargo.Color);
        }
    }

    class Apple
    {
        public string Color { get; set; }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }
}
*/
