using System;

namespace tovar
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            // creates 3 products
            Date date1 = new Date(12, 12, 2020);
            Date date2 = new Date(25, 01, 2022);
            Date date3 = new Date(04, 10, 2022);
            Date date4 = new Date(11, 10, 2022);
            Date date5 = new Date(11, 10, 2022);

            FoodProducts Milk = new FoodProducts(30.25, "Packet of milk", date3, "Ukraine");
            Milk.expireDate = date4;
            Milk.amountLeft = 9999;
            Milk.measure = "packets";
            Milk.description = "very tasty milk 500 ml pls buy";

            FoodProducts Cheese = new FoodProducts(230.00, "Cheese \"Dutch\"", date2, "Kazakhstan");
            Cheese.expireDate = date5;
            Cheese.amountLeft = 113;
            Cheese.measure = "kilograms";
            Cheese.description = "100% fresh, 100% Dutch, 100% cheese";

            Books Twilight = new Books(1000, "Twighlight", date1, "Great Britain");
            Twilight.author = "Stephenie Meyer";
            Twilight.amountPages = 498;
            Twilight.pubHouse = "John Wolf";
            Twilight.description = "About three things I was absolutely positive.First, Edward was a vampire.Second, there was a part of him—and I didn't know how dominant that part might be—that thirsted for my blood.And third, I was unconditionally and irrevocably in love with him.Deeply seductive and extraordinarily suspenseful, Twilight is a love story with bite.";

            GlobalLists.Food.Add(Cheese);
            GlobalLists.Food.Add(Milk);
            
            GlobalLists.Books.Add(Twilight);


            InitializeComponent();
            toolStripButton1.Click += toolStripButton1_click;
            toolStripButton2.Click += toolStripButton2_click;
            toolStripButton3.Click += toolStripButton3_click;


            dataGridView1.Rows.Add(GlobalLists.Food[0].name, "Food", GlobalLists.Food[0].date.Print(), GlobalLists.Food[0].price, GlobalLists.Food[0].country, GlobalLists.Food[0].description);
            dataGridView1.Rows.Add(GlobalLists.Food[1].name, "Food", GlobalLists.Food[1].date.Print(), GlobalLists.Food[1].price, GlobalLists.Food[1].country, GlobalLists.Food[1].description);
            dataGridView1.Rows.Add(GlobalLists.Books[0].name, "Book", GlobalLists.Books[0].date.Print(), GlobalLists.Books[0].price, GlobalLists.Books[0].country, GlobalLists.Books[0].description);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;
                double price = double.Parse(textBox3.Text);
                string date = textBox4.Text;
                int day = int.Parse("" + date[0] + date[1]);
                int month = int.Parse("" + date[3] + date[4]);
                int year = int.Parse("" + date[6] + date[7] + date[8] + date[9]);
                Date Date = new Date(day,month,year);
                string country = textBox5.Text;
                int pages = int.Parse(textBox6.Text);
                string author = textBox7.Text;
                string pubhouse = textBox8.Text;
                string description = textBox9.Text;
                Books book = new Books(price,name,Date,country);
                book.author = author;
                book.description = description;
                book.amountPages = pages;
                book.pubHouse = pubhouse;
                int n = GlobalLists.Books.Count;
                GlobalLists.Books.Add(book);
                dataGridView1.Rows.Add(GlobalLists.Books[n].name, "Book", GlobalLists.Books[n].date.Print(), 
                GlobalLists.Books[n].price, GlobalLists.Books[n].country, GlobalLists.Books[n].description);
            }
            catch
            {
                MessageBox.Show("Ok, throw me some numbers");
                textBox2.Text = "Name here";
                textBox3.Name = "textBox3";
                textBox4.Text = "date here";
                textBox5.Text = "country here";
                textBox6.Text = "Enter amount of pages";
                textBox7.Text = "Enter author";
                textBox8.Text = "Enter publication house";
            }

        }
        private void toolStripButton2_click(object sender, EventArgs e)
        {

            try
            {
                string name = textBox2.Text;

                double price = double.Parse(textBox3.Text);

                string date = textBox4.Text;

                int day = int.Parse("" + date[0] + date[1]);
                int month = int.Parse("" + date[3] + date[4]);
                int year = int.Parse("" + date[6] + date[7] + date[8] + date[9]);
                Date Date = new Date(day, month, year);

                string country = textBox5.Text;

                date = textBox6.Text;
                day = int.Parse("" + date[0] + date[1]);
                month = int.Parse("" + date[3] + date[4]);
                year = int.Parse("" + date[6] + date[7] + date[8] + date[9]);
                Date ExpireDate  = new Date(day, month, year);

                int amountleft = int.Parse(textBox7.Text);

                string measure = textBox8.Text;

                string description = textBox9.Text;

                FoodProducts Food = new FoodProducts(price, name, Date, country);
                Food.amountLeft = amountleft;
                Food.description = description;
                Food.measure = measure;
                Food.expireDate = ExpireDate;
                int n = GlobalLists.Books.Count;
                GlobalLists.Food.Add(Food);
                dataGridView1.Rows.Add(GlobalLists.Food[n].name, "Food", GlobalLists.Food[n].date.Print(),
                GlobalLists.Food[n].price, GlobalLists.Food[n].country, GlobalLists.Food[n].description);
            }
            catch
            {
                MessageBox.Show("Ok, throw me some numbers");
                textBox2.Text = "Name here";
                textBox3.Name = "textBox3";
                textBox4.Text = "date here";
                textBox5.Text = "country here";
                textBox6.Text = "Enter expire date";
                textBox7.Text = "Enter amount left";
                textBox8.Text = "Enter measure";
            }
        }
        private void toolStripButton3_click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text) - 1;
                dataGridView1.Rows.RemoveAt(n);
                textBox1.Text = "Enter here";
                MessageBox.Show("Deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter row number in textbox please. It must be from 1 to " + (dataGridView1.RowCount - 1));
            }
        }
    }
}