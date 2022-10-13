using System;

namespace tovar
{
    public partial class List : Form
    {
        public List()
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

            Globals.Food.Add(Cheese);
            Globals.Food.Add(Milk);
            Globals.Books.Add(Twilight);


            InitializeComponent();
            NewBookButton.Click += AddBookButton;
            NewFoodButton.Click += AddFoodButton;
            RemoveProductButton.Click += RemoveButton;


            dataGridView1.Rows.Add(Globals.Food[0].name, "Food", Globals.Food[0].date.Print(), Globals.Food[0].price, Globals.Food[0].country, Globals.Food[0].description);
            dataGridView1.Rows.Add(Globals.Food[1].name, "Food", Globals.Food[1].date.Print(), Globals.Food[1].price, Globals.Food[1].country, Globals.Food[1].description);
            dataGridView1.Rows.Add(Globals.Books[0].name, "Book", Globals.Books[0].date.Print(), Globals.Books[0].price, Globals.Books[0].country, Globals.Books[0].description);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object t = dataGridView1.CurrentCell.Value;
            string? nameFromCell = Convert.ToString(t);
            bool isBook = false;
            bool isFood = false;
            if (nameFromCell == null)
            {
                nameFromCell = "";
            }
            object? result = checkifbook(nameFromCell);
            isBook = true;
            if (result == null)
            {
                result = checkifFood(nameFromCell);
                isFood = true;
                isBook = false;
            }


            if (result == null)
            {
                MessageBox.Show("Bad things happen, unfortunately we couldn`t find the object, alas. " +
                                "Try clicking on the cells from the first column.");
                return;
            }
            else
            {
                if (isBook)
                {
                    Books? B = result as Books;
                    string s = B.displayInfo();
                    MessageBox.Show(s);
                }
                else if (isFood)
                {
                        FoodProducts? F = result as FoodProducts;
                        string s = F.displayInfo();
                        MessageBox.Show(s);
                }
                else
                {
                    MessageBox.Show("Bad things happen, unfortunately we couldn`t find the object, alas. " +
                                "Try clicking on the cells from the first column.");
                }
            }
        }

        Books? checkifbook(string givenName)
        {
            foreach (Books book in Globals.Books)
            {
                if (book.name == givenName)
                {
                    return book;
                }
            }
            return null;
        }

        FoodProducts? checkifFood(string givenName)
        {
            foreach (FoodProducts food in Globals.Food)
            {
                if (food.name == givenName)
                {
                    return food;
                }
            }
            return null;
        }

        private void AddBookButton(object sender, EventArgs e)
        {
            Globals.RemoveMode = false;
            Globals.AddFoodMode = false;
            Globals.AddBookMode = true;
            DisplayNeeded(Globals.AddFoodMode, Globals.AddBookMode, Globals.RemoveMode);
        }
        private void AddFoodButton(object sender, EventArgs e)
        {
            Globals.RemoveMode = false;
            Globals.AddFoodMode = true;
            Globals.AddBookMode = false;
            DisplayNeeded(Globals.AddFoodMode, Globals.AddBookMode, Globals.RemoveMode);
        }
        private void RemoveButton(object sender, EventArgs e)
        {
            Globals.RemoveMode = true;
            Globals.AddFoodMode = false;
            Globals.AddBookMode = false;
            DisplayNeeded(Globals.AddFoodMode, Globals.AddBookMode, Globals.RemoveMode);
        }

        private void buttonAddConfirm_Click(object sender, EventArgs e)
        {
            //add food mode
            if (Globals.AddFoodMode)
            {
                try
                {
                    string name = textboxName.Text;

                    double price = double.Parse(textBoxPrice.Text);

                    string date = textBoxDate.Text;

                    int day = int.Parse("" + date[0] + date[1]);
                    int month = int.Parse("" + date[3] + date[4]);
                    int year = int.Parse("" + date[6] + date[7] + date[8] + date[9]);
                    Date Date = new Date(day, month, year);

                    string country = textBoxCountry.Text;

                    date = txtboxDateEnd_Pages.Text;
                    day = int.Parse("" + date[0] + date[1]);
                    month = int.Parse("" + date[3] + date[4]);
                    year = int.Parse("" + date[6] + date[7] + date[8] + date[9]);
                    Date ExpireDate = new Date(day, month, year);

                    int amountleft = int.Parse(txtboxAuthor_Amount.Text);

                    string measure = txtboxMeasure_House.Text;

                    string description = textBoxDescryption.Text;

                    FoodProducts Food = new FoodProducts(price, name, Date, country);
                    Food.amountLeft = amountleft;
                    Food.description = description;
                    Food.measure = measure;
                    Food.expireDate = ExpireDate;
                    int n = Globals.Food.Count;
                    Globals.Food.Add(Food);
                    dataGridView1.Rows.Add(Globals.Food[n].name, "Food", Globals.Food[n].date.Print(),
                    Globals.Food[n].price, Globals.Food[n].country, Globals.Food[n].description);
                }
                catch
                {
                    MessageBox.Show("Enter parameters as asked, please");
                    textboxName.Text = "";
                    textBoxPrice.Text = "";
                    textBoxDate.Text = "";
                    textBoxCountry.Text = "";
                    txtboxDateEnd_Pages.Text = "";
                    txtboxAuthor_Amount.Text = "";
                    txtboxMeasure_House.Text = "";
                }
            }

            //add book mode
            else if (Globals.AddBookMode)
            {
                try
                {
                    string name = textboxName.Text;
                    double price = double.Parse(textBoxPrice.Text);
                    string date = textBoxDate.Text;
                    int day = int.Parse("" + date[0] + date[1]);
                    int month = int.Parse("" + date[3] + date[4]);
                    int year = int.Parse("" + date[6] + date[7] + date[8] + date[9]);
                    Date Date = new Date(day, month, year);
                    string country = textBoxCountry.Text;
                    int pages = int.Parse(txtboxDateEnd_Pages.Text);
                    string author = txtboxAuthor_Amount.Text;
                    string pubhouse = txtboxMeasure_House.Text;
                    string description = textBoxDescryption.Text;
                    Books book = new Books(price, name, Date, country);
                    book.author = author;
                    book.description = description;
                    book.amountPages = pages;
                    book.pubHouse = pubhouse;
                    int n = Globals.Books.Count;
                    Globals.Books.Add(book);
                    dataGridView1.Rows.Add(Globals.Books[n].name, "Book", Globals.Books[n].date.Print(),
                    Globals.Books[n].price, Globals.Books[n].country, Globals.Books[n].description);
                }
                catch
                {
                    MessageBox.Show("Enter parameters as asked, please");
                    textboxName.Text = "";
                    textBoxPrice.Name = "";
                    textBoxDate.Text = "";
                    textBoxDescryption.Text = "";
                    textBoxCountry.Text = "";
                    txtboxDateEnd_Pages.Text = "";
                    txtboxAuthor_Amount.Text = "";
                    txtboxMeasure_House.Text = "";
                }
            }

            //error
            else
            {
                MessageBox.Show("No mode selected, try pressing some buttons");
            }
        }
        void DisplayNeeded(bool food,bool book, bool remove)
        {
            //if remove mode
            textboxRow.Visible = remove;
            lableRow.Visible = remove;

            //common for food and book
            textboxName.Visible = food || book;
            labelName.Visible = food || book;

            textBoxCountry.Visible = food || book;
            labelCountry.Visible = food || book;

            textBoxDate.Visible = food|| book;
            labelDate.Visible = food || book;

            textBoxPrice.Visible = food || book;
            labelPrice.Visible = food || book;

            textBoxDescryption.Visible = food || book;
            labelDescription.Visible = food || book;

            //not so common but common for food and book
            txtboxDateEnd_Pages.Visible = food || book;
            labelPages_Date.Visible = food || book;

            txtboxAuthor_Amount.Visible = food || book;
            labelAuthor_Amount.Visible= food || book;

            txtboxMeasure_House.Visible = food || book;
            labelHouse_Measure.Visible = food || book;

            //personalised
            if (book) { labelPages_Date.Text = "Pages am-nt: "; }
            if (food) { labelPages_Date.Text = "Expire date: "; }

            if (book) { labelAuthor_Amount.Text = "Author: "; }
            if (food) { labelAuthor_Amount.Text = "Amount: "; }

            if (book) { labelHouse_Measure.Text = "Publisher: "; }
            if (food) { labelHouse_Measure.Text = "Measure: "; }

            //buttons
            buttonAddConfirm.Visible = food || book;
            buttonRemoveConfirm.Visible = remove;
        }

        private void buttonRemoveConfirm_Click(object sender, EventArgs e)
        {
            //remove mode
            if (Globals.RemoveMode)
            {

                try
                {
                    int n = int.Parse(textboxRow.Text) - 1;
                    dataGridView1.Rows.RemoveAt(n);
                    textboxRow.Text = "";
                    MessageBox.Show("Deleted");
                }
                catch (Exception ex)
                {
                    if (dataGridView1.RowCount - 1 == 0)
                    {
                        MessageBox.Show("Nothing to delete");
                    }
                    else
                    {
                        MessageBox.Show("Enter row number in textbox please. It must be from 1 to " + (dataGridView1.RowCount - 1));
                    }
                }
            }
            else
            {
                MessageBox.Show("No mode selected, try pressing some buttons");
            }
        }
    }
}