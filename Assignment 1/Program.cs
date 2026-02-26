using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1
{
    #region part 01
    #region Question 01
    //Reference Type
    //  class PersonClass
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public PersonClass(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    ////Value Type
    //struct PersonStruct
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public PersonStruct(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    #endregion
    #region Question02
    //class Person
    //{
    //    public string Name;      // Anyone can access
    //    private int age;         // Only this class can access

    //    public void SetAge(int a)
    //    {
    //        if (a > 0)
    //            age = a;
    //    }

    //    public int GetAge()
    //    {
    //        return age;
    //    }
    //}

    #endregion

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Question01
            //// CLASS: Copy shares the same reference
            //PersonClass P01 = new PersonClass("Ahmed",20);
            //PersonClass P02 = P01;
            //P02.Name = "Mohamed";

            //Console.WriteLine("-- Class (Reference Type) --");
            //Console.WriteLine($"P01.Name = {P01.Name}"); // Mohamed  ← changed!
            //Console.WriteLine($"P02.Name = {P02.Name}"); // Mohamed

            //// STRUCT: Copy creates an independent clone
            //PersonStruct P03 = new PersonStruct("Ahmed", 20);
            //PersonStruct P04 = P03;
            //P04.Name = "Mohamed";
            //Console.WriteLine("\n-- Struct (Value Type) --");
            //Console.WriteLine($"P03.Name = {P03.Name}"); // Ahmed ← unchanged
            //Console.WriteLine($"P04.Name = {P04.Name}"); // Mohamed

            //Class vs Struct
            //Feature | class       | struct
            //Type    | Value type  | Reference type
            //Stored  |  In Stack    |  Heap(reference on stack)
            //Assignment |Copies the data |Copies the reference
            //Inheritance |❌ Not supported |✅ Supported
            //Default Constructor |Always exists, cannot be removed |Provided if none defined
            //Null |❌ Cannot be null(unless nullable) |✅ Can be null



            #endregion
            #region Question02
           // Person p = new Person();

           // p.Name = "Ali";        //  Works — public
           // p.SetAge(25);            //  Works — public method
           // Console.WriteLine($"{p.Name} is {p.GetAge()} years old."); // p.age = 25;          // ❌ Error — private
           //// public => anyone can use it. private => only the class itself can use it.
            #endregion
        #endregion
        }
    }
}
