using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace tovar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new List());

        }
    }
    class Date
    {
        public int year;
        public int month;
        public int day;
        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }
        public string Print()
        {
            string result = day + "." + month + "." + year;
            return result;
        }
    }
    class Goods
    {
        public double price;
        public string name;
        public string description;
        public Date date;
        public string country;
        public Goods(double price, string name, Date date, string country)
        {
            this.price = price;
            this.name = name;
            this.description = "";
            this.date = date;
            this.country = country;
        }
    }
    class FoodProducts : Goods
    {
        public Date? expireDate;
        public int amountLeft;
        public string measure;
        public FoodProducts(double price, string name, Date date, string country) : base(price, name, date, country)
        {
            expireDate = null;
            amountLeft = 0;
            measure = "";
            this.description = "";
            this.price = price;
            this.name = name;
            this.date = date;
            this.country = country;
        }
        public string displayInfo()
        {
            string result = "";
            result = result + "Name: " + name + "\n";
            result = result + "Price: " + price + "\n";
            result = result + "Country from: " + country + "\n";
            result = result + "Date packed: " + date.Print() + "\n";
            result = result + "Expire date: " + expireDate.Print() + "\n";
            result = result + "Measure: " + measure + "\n";
            result = result + "Amount left: " + amountLeft + "\n";
            result = result + "Description: " + description;
            return result;
        }
    }
    class Books : Goods
    {
        public int amountPages;
        public string author;
        public string pubHouse;
        public Books(double price, string name, Date date, string country) : base(price, name, date, country)
        {
            this.amountPages = 0;
            this.author = "";
            this.pubHouse = "";
            this.description = "";
            this.price = price;
            this.name = name;
            this.date = date;
            this.country = country;
        }
        public string displayInfo()
        {
            string result = "";
            result = result + "Name: " + name + "\n";
            result = result + "Author: " + author + "\n";
            result = result + "Price: " + price + "\n";
            result = result + "Country from: " + country + "\n";
            result = result + "Date published: " + date.Print() + "\n";
            result = result + "Amount of pages: " + amountPages + "\n";
            result = result + "Publishing House: " + pubHouse + "\n";
            result = result + "Description: " + description;
            return result;
        }
    }
    static class Globals
    {
        public static List<FoodProducts> Food = new List<FoodProducts>();
        public static List<Books> Books = new List<Books>();
        public static bool RemoveMode = true;
        public static bool AddBookMode = false;
        public static bool AddFoodMode = false;
    }
}