using System;

namespace Lab1_9
{
   
    class Receipt
    {
        private int number;
        private int date;
        private int summa;
        
        public Receipt()
        {
            Console.WriteLine("Instance constructor without parameters");
            
        }
        public Receipt(int number, int date, int summa)
        {
            Console.WriteLine("Instance constructor with parameters");
            this.number = number;
            this.date = date;
            this.summa = summa;

        }
        public Receipt(Receipt receipt1)
        {
            Console.WriteLine("Copy constructor");
            number = receipt1.number;
            date = receipt1.date;   
            summa = receipt1.summa;
        }
        public void SetLastNumber(int number)
        {
            this.number = number;
        }
        
        ~Receipt()
        {
            Console.WriteLine("Destructor was called");
        }

        public int Number
        {
            get {
                Console.WriteLine("called get for number"); 
                return number; }
            set {
                Console.WriteLine("called set for number");
                number = value; }
                
        }
        public int Date
        {
            get
            {
                Console.WriteLine("called get for date");
                return date;
            }
            set
            {
                Console.WriteLine("called set for date");
                date = value;
            }

        }
        public int Summa
        {
            get
            {
                Console.WriteLine("called get for summa");
                return summa;
            }
            set
            {
                Console.WriteLine("called set for summa");
                summa = value;
            }

        }
        public void Print()
        {
            Console.WriteLine("Information about receip:");
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Summa: {summa}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Receipt receipt = new Receipt();
            Counter.addOne();
            receipt.Number = 3;
            int number = receipt.Number;
            receipt.Date = 3;
            int date = receipt.Date;
            receipt.Summa = 3;
            int summa = receipt.Summa;
            receipt.Print();
            Receipt receipt1 = new Receipt(4, 5, 8);
            Counter.addOne();
            Receipt receipt2 = new Receipt(receipt1);
            Counter.addOne();
            receipt1.SetLastNumber(22);
            receipt1.Print();
            Console.WriteLine();
            receipt2.Print();
            Console.WriteLine(Counter.Count);
            

        }
    }
}