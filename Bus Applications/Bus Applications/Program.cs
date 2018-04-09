using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemauthor;

namespace Bus_Applications
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Cus = new Customer();
            start:
            Console.Write("Seats Number:");
            byte Snum = byte.Parse(Console.ReadLine());
            if (Snum > 25)
                Console.Write("Not Allowed\n");
            else
            {
                Cus.Reserve(Snum);
            }
            Console.Write("Press anykey to Reload");
            Console.ReadKey();
            Console.Clear();
            goto start;

        }
    }
    class Customer
    {
        Comp.Company cus = new Comp.Company();
        static byte Id = 0; //number of Reserved seats
        public void Reserve(byte snum) //Register New Customers
        {
            if (Id > 24)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("There is no avaliable Seats\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (25 - Id < snum)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Sorry the avaliable Seats is not enough\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                for (byte i = 0; i < snum; i++)
                {
                    Console.Write("ID:{0} in Bus number{1}\n", cus.Bsearch().Ssearch().Cusid, cus.Bsearch().Ssearch().Busid);
                    cus.Bsearch().Ssearch().state = true;
                    Id++;
                    if (Id == 5 || Id == 10 || Id == 15 || Id == 20 || Id == 25)
                    {
                        cus.Bsearch().state = true;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Reservation Done Successfully\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}

namespace Comp
{
    class Company
    {
        Bus [] bus=new Bus[5]{new Bus(1),new Bus(2),new Bus(3),new Bus(4),new Bus(5)};
        //Bus Search    
        public Bus Bsearch()
        {
            foreach(Bus B in bus)
            {
                if (B.state == false)
                    return B;
            }
            return null;
        }
    }
    class Bus
    {
        public byte Busid = 1;
        public bool state = false;
        Seat [] seat=new Seat[5];
        byte counter=1;
        public Bus(byte x)
        {
            this.Busid = x;
            for (byte i = 0; i < 5; i++)
            {
                seat[i] = new Seat();
                seat[i].Cusid = counter;
                seat[i].Busid = x;
                counter++;
            }
        }
        public Seat Ssearch()
        {
            foreach (Seat S in seat)
            {
                if (S.state == false)
                    return S;
            }
            return null;
        }
    }

    class Seat
    {
        public byte Cusid = 1;
        public byte Busid = 1;
        public bool state = false; //false=Not Reserved  True=Reserved
    }
}

