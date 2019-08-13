using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BI_coursework
{
    public partial class Form1 : Form
    {

        //Leave this alone
        public Form1()
        {
            InitializeComponent();
        }

        //Leave this alone
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //This needs replacing with whatever button we decide to make
        private void GetDataFromSource_Click(object sender, EventArgs e)
        {
            GetDatesFromSource();
            GetProductFromSource();
            GetCustomerFromSource();
        }

        private void GetDatesFromSource()
        {
            //Create a list

            //Connect to the source

            //Get the data

            //Add data to temp list

            //Create a new list for the formatted data.

            //Format the data and add to new list

        }

        private void GetProductFromSource()
        {
            //Create a list

            //Connect to the source

            //Get the data

            //Add data to list

        }

        private void GetCustomerFromSource()
        {
            //Create a list

            //Connect to the source

            //Get the data

            //Add data to list
        }


        private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear)
        {
           
        }

        private void insertProductDimension(string category, string subcategory, string name, string reference)
        {
            //Create a connection to the MDF file

            //Build the query

            //Insert the data
        }

        private void insertCustomerDimension(string name, string country, string city, string state, string postCode, string region, string reference)
        {
            //Create a connection to the MDF file

            //Build the query

            //Insert the data
        }

        //This needs replacing with whatever button we decide to make
        private void GetFromDestinationButton_Click(object sender, EventArgs e)
        {
            GetAllDatesFromDimension();
            GetAllProductsFromDimension();
            GetAllCustomersFromDimension();
        }

        private void GetAllDatesFromDimension()
        {
            //Create new list to store the named results in.

            //Create the database string

            //Run the query

            //Bind the listbox to the list.

        }
        private void GetAllProductsFromDimension()
        {
            //Create new list to store the named results in.

            //Create the database string

            //Run the query

            //Bind the listbox to the list.
        }

        private void GetAllCustomersFromDimension()
        {
            //Create new list to store the named results in.

            //Create the database string

            //Run the query

            //Bind the listbox to the list.
        }


        


        private int GetDateId(string date)
        {
            // Split Date
            string[] arrayDate = date.Split('/');
            Int32 year = Convert.ToInt32(arrayDate[2]);
            Int32 month = Convert.ToInt32(arrayDate[1]);
            Int32 day = Convert.ToInt32(arrayDate[0]);

            DateTime myDate = new DateTime(year, month, day);
            string dbDate = myDate.ToString("M/dd/yyyy");

            // Create A Connection TO MDF File
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                // Open The SQL Connection
                myConnection.Open();
                // Check If The Date Exists In The Database - No Duplicating
                SqlCommand command = new SqlCommand("SELECT id FROM Time Where date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));

                // Create A Variable & Assign As False Default
                Boolean exists = false;

                // Run & Read Results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // If Rows Exists - Date Exists - Update The Var
                    if (reader.HasRows)
                    {
                        exists = true;
                        return Convert.ToInt32(reader["id"]);
                    }
                }

            }

            return 0;

        }
        private int GetProductId(string reference)
        {
            // Create A MDF Connection
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                // Open Connection
                myConnection.Open();
                // Sql Command
                SqlCommand command = new SqlCommand(" SELECT Id FROM Product WHERE name = @name", myConnection);
                //command.Parameters.Add(new SqlParameter("ProductID", ProductID));


                // Create A Variable & Assign It As False
                bool exists = false;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // If There Are Rows - Name Exists
                    if (reader.HasRows)
                    {
                        exists = true;
                        return Convert.ToInt32(reader["ID"]);
                    }
                }
            }
            return 0;
        }

        private int GetCustomerId(string reference)
        {

            //Remove the timestamps

            //Split the clean date down and assign it to variables for later use.

            //Create a connection to the MDF file

            //Run the command & read the results

            //return the details
            return 0;
        }
        private void insertIntoFactTable(int productId, int timeId, int customerId, double value, double discount, double profit, double quantity)
        {
            //Create a connection to the MDF file

            //Build the query

            //Insert the data
        }

        private void GetFactTable()
        {
            //Create new list to store the named results in.

            //Create the database string

            //Run the query

            //Bind the listbox to the list.
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            // Create A List To Store Dates In
            List<string> Dates = new List<string>();
            // Clear List Box
            lstGetDates.Items.Clear();

            // Create The Database String
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open The Connection
                connection.Open();
                OleDbDataReader reader = null;
                // Run The Query
                OleDbCommand getDates = new OleDbCommand(" SELECT [Order Date], [Ship Date] from SHeet1", connection);

                // Read Query Results
                reader = getDates.ExecuteReader();
                // Loop To Retrieve All Results
                while (reader.Read())
                {
                    // Column 1
                    Dates.Add(reader[0].ToString());
                    // Column 2
                    Dates.Add(reader[1].ToString());
                }

            }

            // Format Results
            List<string> DatesFormatted = new List<string>();
            // Remove Time - New List Looped Through Old - Splitting Data & Adding Back Only Dates
            foreach (string date in Dates)
            {
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                DatesFormatted.Add(dates[0]);
            }

            // Bind Formatted List To ListBox
            lstGetDates.DataSource = DatesFormatted;

            // Split Dates & Insert
            foreach(string date in DatesFormatted)
            {
                splitDates(date);
            }
            splitDates(DatesFormatted[0]);

            // Variables
            string[] arrayDate = DatesFormatted[0].ToString().Split('/');
            Int32 year = Convert.ToInt32(arrayDate[2]);
            Int32 month = Convert.ToInt32(arrayDate[1]);
            Int32 day = Convert.ToInt32(arrayDate[0]);

            Console.WriteLine(DatesFormatted[0].ToString());

            DateTime myDate = new DateTime(year, month, day);
            Console.WriteLine(" Day Of Week: " + myDate.DayOfWeek);

            String dayOfWeek = myDate.DayOfWeek.ToString();
            Int32 dayOfYear = myDate.DayOfYear;
            String monthName = myDate.ToString("MMMM");
            Int32 weekNumber = dayOfYear / 7;
            Boolean weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") weekend = true;

            // Convert To Database Friendly Format
            string dbDate = myDate.ToString("M/dd/yyyy");

            insertTimedimension(dbDate, dayOfWeek, day, monthName, month, weekNumber, year, weekend, dayOfYear);
        }
   

        private void insertTimedimension(string date, string dayName, Int32 dayNumber, string monthName, Int32 monthNumber, Int32 weekNumber, Int32 year, Boolean weekend, Int32 dayOfYear)
        {
            // Create A Connection To THe MDF File
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                // Open The SQL Connection
                myConnection.Open();
                // Check If The Date Exists In The Database - No Duplicating
                SqlCommand command = new SqlCommand("SELECT id FROM Time Where date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));

                // Create A Variable & Assign As False Default
                Boolean exists = false;

                // Run & Read Results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // If Rows Exists - Date Exists - Update The Var
                    if (reader.HasRows) exists = true;     
                }
         
                if(exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                   " INSERT INTO Time (dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear) " +
                   " VALUES (@dayName, @dayNumber, @monthName, @monthNumber, @weekNumber, @year, @weekend, @date, @dayOfYear) ", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));

                    // Insert The Line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records Affected: " + recordsAffected);

                }
            }
        }

            private void splitDates (string rawDate)
         {
            // Split The Date Down & Assign It To Variable For Later Use
            string[] arrayDate = rawDate.Split('/');
            Int32 year = Convert.ToInt32(arrayDate[2]);
            Int32 month = Convert.ToInt32(arrayDate[1]);
            Int32 day = Convert.ToInt32(arrayDate[0]);
         }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            // Create A List To Store Products In
            List<string> Products = new List<string>();
            // Clear Items
            lstGetProducts.Items.Clear();

            // Create Database String 
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getProducts = new OleDbCommand(" SELECT [Product ID], [Product Name], Category, [Sub-Category] from Sheet1", connection);

                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(reader[0].ToString());
                    Products.Add(reader[1].ToString());
                    Products.Add(reader[2].ToString());
                    Products.Add(reader[3].ToString());
                    

                    string Name = reader[0].ToString();
                    string Reference = reader[1].ToString();
                    string Category = reader[2].ToString();
                    string SubCategory = reader[3].ToString();
                    insertProductdimension(Name, Reference, Category, SubCategory);

                }

                


            }

            lstGetProducts.DataSource = Products;
            
    
        }

        private void insertProductdimension(string Name, string Reference, string Category, string SubCategory)
        {
            // Create A MDF Connection
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                // Open Connection
                myConnection.Open();
                // Sql Command
                SqlCommand command = new SqlCommand(" SELECT Id FROM Product WHERE name = @name", myConnection);
                command.Parameters.Add(new SqlParameter("Name", Name));
                command.Parameters.Add(new SqlParameter("Reference", Reference));
                command.Parameters.Add(new SqlParameter("Category", Category));
                command.Parameters.Add(new SqlParameter("SubCategory", SubCategory));
                

                // Create A Variable & Assign It As False
                bool exists = false;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // If There Are Rows - Name Exists
                    if (reader.HasRows)
                    {
                        exists = true;
                    }
                }

                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                    "INSERT INTO Product (Name, Reference, Category, SubCategory)" + "VALUES (@name, @reference, @category, @subcategory)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("Name", Name));
                    insertCommand.Parameters.Add(new SqlParameter("Reference", Reference));
                    insertCommand.Parameters.Add(new SqlParameter("Category", Category));
                    insertCommand.Parameters.Add(new SqlParameter("SubCategory", SubCategory));
                   

                    // Insert The Line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                        
                }
            }

        }

        private void btnGetDatesDimension_Click(object sender, EventArgs e)
        {
            // Create A List
            List<string> DestinationDates = new List<string>();

            // Clear
            lstGetDatesDimension.DataSource = null;
            lstGetDatesDimension.Items.Clear();

            // Create A Connection To The MDF File
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                // Open Connection
                myConnection.Open();
                // Check If Date Exists
                SqlCommand command = new SqlCommand("SELECT id, dayName, dayNumber, monthName, monthNumber, weekNumber, year, " + " weekend, date, dayOfYear FROM Time", myConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["id"].ToString();
                            string dayName = reader["dayName"].ToString();
                            string dayNumber = reader["dayNumber"].ToString();
                            string monthName = reader["monthName"].ToString();
                            string monthNumber = reader["monthName"].ToString();
                            string weekNumber = reader["weekNumber"].ToString();
                            string year = reader["year"].ToString();
                            string weekend = reader["weekend"].ToString();
                            string date = reader["date"].ToString();
                            string dayOfYear = reader["dayOfYear"].ToString();

                            string text;
                            text = "ID = " + id + ", Day Name = " + dayName + ", Day Number = " + dayNumber + ", Month Name" + monthName + ", Month Number" + monthNumber + ", Week Number" + weekNumber + ", Year" + year + ", Weekend" + weekend + ", Date" + date + ", Day Of Year" + dayOfYear;

                            DestinationDates.Add(text);
                        }

                    }

                    else
                    {
                        DestinationDates.Add("No Data Present In Dimension");
                    }
                }
            }
            // Bind
            lstGetDatesDimension.DataSource = DestinationDates;
        }

        private void btnGetProductsDimension_Click(object sender, EventArgs e)
        {
            // Create A List
            List<string> DestinationProducts = new List<string>();
            // Clear
            lstGetProductsDimension.DataSource = null;
            lstGetDatesDimension.Items.Clear();

            // Create A Connection To MDF File
            string connectionStringDatabase = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDatabase))
            {
                // Open The Connection
                myConnection.Open();
                // Check If The Product Exists
                SqlCommand command = new SqlCommand(" SELECT Name, Reference, Category, SubCategory FROM Product", myConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            string ProductId = reader["Name"].ToString();
                            string ProductName = reader["Reference"].ToString();
                            string Category = reader["Category"].ToString();
                            string SubCategory = reader["SubCategory"].ToString();

                            string text;
                            text = "Name = " + Name + ", ProductName =" + Name + ", Category =" + Category + ", SubCategory =" + SubCategory;
                            DestinationProducts.Add(text);
                        }
                    }
                    else
                    {
                        DestinationProducts.Add("No Data Present In Dimension");
                    }
                }

                // Bind
                lstGetProductsDimension.DataSource = DestinationProducts;
            }
        }
    }
}


