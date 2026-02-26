using System;
using System.ComponentModel;
using System.Net.Sockets;
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
    #region Part 02
    ////1
    //enum TicketType
    //{
    //    Standard,
    //    VIP, 
    //    IMAX

    //}
    ////2
    //struct Seat
    //{
    //    public char Row;
    //    public int Number;

    //    public Seat(char row, int number)
    //    {  Row = row;
    //       Number = number;
    //    }

    //    public override string ToString() => $"{Row}{Number}";

    //}
    ////3
    //class Ticket
    //{
    //    public string MovieName;
    //    public TicketType Type;
    //    public Seat Seat;
    //    private double Price;

    //    public Ticket(string movieName, TicketType type, Seat seat, double price)
    //    {
    //        MovieName = movieName;
    //        Type = type;
    //        Seat = seat;
    //        Price = price;
    //    }
    //    public Ticket(string movieName):this(movieName, TicketType.Standard,new Seat('A',1),50) {}
    //    //4
    //    //4.a
    //    public double CalcTotal(double taxPercent)
    //    { return Price + (Price * taxPercent / 100); }

    //    //4.b
    //    public void ApplyDiscount( ref double discountAmount)
    //    {
    //        if (discountAmount >0 && discountAmount <= Price)
    //        {
    //            Price -= discountAmount;
    //            discountAmount = 0;

    //        }
    //    }

    //    //4.c
    //     public void PrintTicket(double taxPercent)
    //    {
    //        Console.WriteLine($"Movie : {MovieName}");
    //        Console.WriteLine($"Type : {Type}");
    //        Console.WriteLine($"Seat : {Seat}");
    //        Console.WriteLine($"Price : {Price}");
    //        Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent)}");



    //    }


    //}
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
            #region Question03
            //1. Create the Class Library
            //2. Write your code in the library
            //3. Create a Console App to use it
            //4. Add a Reference to the Library
            //5. Use the Library in your App
            //6. Run the Console App — Done! ✅

            #endregion
            #region Question04
            // What is a class library?
            //>> A Class Library is a separate project that contains reusable classes,
            // but has no Main method and cannot run on its own.It compiles into a .dll file(Dynamic Link Library).
            //Why do we use class libraries? 
            //>>1.♻️ Reusability — write once, use in many projects
            //2.📂 Organization — Separate concerns into different assemblies
            //3.👥 Teamwork — different developers work on different libraries
            //4.🔧 Maintenance — fix a bug once, all projects benefit
            #endregion
            #endregion
            #region Part 02
            //const double TAX = 14;
            //Console.Write("Enter Movie Name : ");
            //string movieName = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            //TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row : ");
            //char row = Console.ReadLine().ToUpper()[0];

            //Console.Write("Enter Seat Number : ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price : ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount : ");
            //double discount = double.Parse(Console.ReadLine());


            //Ticket ticket01 = new Ticket(movieName, type, new Seat(row, number), price);


            //Console.WriteLine("\n===== Ticket Info =====");
            //ticket01.PrintTicket(TAX);

            //Console.WriteLine("\n===== After Discount =====");
            //double originalDiscount = discount;
            //ticket01.ApplyDiscount(ref discount);
            //Console.WriteLine($"Discount Before : {originalDiscount}");
            //Console.WriteLine($"Discount After  : {discount}");
            //ticket01.PrintTicket(TAX);


            #endregion
        }
    }
}
