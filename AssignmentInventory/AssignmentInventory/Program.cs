using System;

class Program
{


    public class User
    {
        // fields 
        public string userName;
        public int userCartItems;
        protected string password;
        public double totalBill;



        // constructor
        public User(string userName,int userCartItems,string password, double totalBill)
        {
            this.userName = userName;
            this.userCartItems = userCartItems;
            this.password = password;
            this.totalBill = totalBill;
        }

        // get and set 
        public string UserName
        {
            set { this.userName = value; }
            get { return this.userName; }
        }

        public int UserCartItems
        {
            set { this.userCartItems = value; }
            get { return this.userCartItems; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

        public double TotalBill
        {
            set { this.totalBill = value; }
            get { return this.totalBill; }
        }
    }
    public static void Main()
    {



        Electronics Tvs = new Electronics(101,"MITv",15000,80,"2 years");
        Electronics et = new Electronics(121, "LG", 2000, 12, "1 Year");
        Groceries vegitables = new Groceries(10, "VegitablesKit", 800, 100, "6 days");
        User user1 = new User("Ramesh", 0, "ramesh123",0);


        Console.WriteLine("Total itmes");
        Console.WriteLine("Electronic items is: " + Tvs.ProductId);
        Console.WriteLine("Electronic items is: " + Tvs.ProductName);
        Console.WriteLine("Electronic items is: " + Tvs.Price);
        Console.WriteLine("Electronic items is: " + Tvs.Qunatity);


        Console.WriteLine("Electronic items is: " + user1.UserName);
        Console.WriteLine("Electronic items is: " + user1.UserCartItems);

        Console.WriteLine("Electronic items is: " + et.ProductId);
        Console.WriteLine("Electronic items is: " + et.ProductName);
        Console.WriteLine("Electronic items is: " + et.Price);
        Console.WriteLine("Electronic items is: " + et.Qunatity);

    }




}