using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace JobDatabase
{
    public partial class frmJobDatabase : Form
    {
        public frmJobDatabase()
        {
            InitializeComponent();
        }

        string[] IJobs = { "Data Scientist", "Cyber Security Engineer", "IT Systems Security Manager" };

        string[] AJobs = { "Auto mechanic", "Automotive Sales Manager", "Automotive Designer" };

        string[] DJobs = { "Diesel Truck Mechanic", "Truck and Transport Mechanic", "Heavy Truck Mechanic" };

        string[] EJobs = { "Electrical Estimator", "High Voltage Electrician", "Electrical Designer" };

        string[] CJobs = { "Boilermakers", "Tapers", "Pile Driver Operators" };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();
            if (keepGoing)
            {
                PerformTheSearch();
            }
        }

        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = lbJob.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You Must Select a Search Term",
                    "Search Term Empty");

                
                retVal = false;
            }

            return retVal;
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }


        private void PerformTheSearch()
        {
            switch (lbJob.FindString(lbJob.SelectedItem.ToString()))//find the index of the selected string
            {
                case 0:
                    lblResult.Text = "Data Scientist, Cyber Security Engineer, IT Systems Security Manager";
                    break;
                   
                    case 1:
                    lblResult.Text = "Auto mechanic, Automotive Sales Manager, Automotive Designer";
                    break;

                    case 2:
                    lblResult.Text = "Diesel Truck Mechanic, Truck and Transport Mechanic, Heavy Truck Mechanic";
                    break;

                    case 3:
                    lblResult.Text = "Electrical Estimator, High Voltage Electrician, Electrical Designer";
                    break;

                    case 4:
                    lblResult.Text = "Boilermakers, Tapers, Pile Driver Operators";
                    break;


            }

            

            }

        private void lbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                    
}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exitform();
        }

        private void Exitform()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
    }

