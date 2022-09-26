using System;

namespace Q5
{
    abstract class BankAcc
    {
        public abstract void Link_Aadhar_AccNo();

    }
    class Link : BankAcc
    {
        int adh_no;
        public Link()
        {
            Console.Write("Enter a Aadhar No : ");
            adh_no = Convert.ToInt32(Console.ReadLine());

        }
        public override void Link_Aadhar_AccNo()
        {
            Console.WriteLine("Aadhar number link to Bank Account Successfully!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Link link = new Link();

            link.Link_Aadhar_AccNo();
        }
    }
}