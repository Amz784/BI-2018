﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            //Create a connection to the MDF file

            //Build the query

            //Insert the data

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
            //Remove the timestamps

            //Split the clean date down and assign it to variables for later use.

            //Create a connection to the MDF file

            //Run the command & read the results

            //return the details
            return 0;

        }
        private int GetProductId(string reference)
        {
            //Remove the timestamps

            //Split the clean date down and assign it to variables for later use.

            //Create a connection to the MDF file

            //Run the command & read the results

            //return the details
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
            foreach(string date in Dates)
            {
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                DatesFormatted.Add(dates[0]);
            }

            // Bind Formatted List To ListBox
            lstGetDates.DataSource = DatesFormatted;

            // Variables
            Int32 year = 0;
            Int32 month = 0;
            Int32 day = 0;

            Console.WriteLine(DatesFormatted[0].ToString());
        }
    }
}
