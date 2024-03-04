using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchNames
{
    public partial class frmSearchNames : Form
    {
        string[] firstNames = {"Joe","Jake", "Josh", "Ron", "Blake" };

        string[] lastNames = {"Shmoe", "Smith", "Zing", "Fon", "Rake"  };

        const string SNF = "Student Not Found";
        const string N = "Course:\t";
        const string DIR = "Course Grade:\t";
        const string DES = "GPA:\t";

        string[] Course = {"AWD 1000", "AWD 1100", "AWD 1500", "AWD 1600", "AWD 1700" };

        string[] CourseG = { "A", "B", "C", "D", "F"};

        string[] GPA = {"3.5", "4.0", "2.7", "2.9", "3.0" };



        public frmSearchNames()
        {
            InitializeComponent();
        }

        private void frmSearchNames_Load(object sender, EventArgs e)
        {
            //  Populate first name dropdown list
            for (int lcv = 0; lcv < firstNames.Length; ++lcv)
            {
                ddlFirstName.Items.Add(firstNames[lcv]);
            }

            //  Populate last name dropdown list
            for (int lcv = 0; lcv < lastNames.Length; ++lcv)
            {
                ddlLastName.Items.Add(lastNames[lcv]);
            }
        }

        private void btnFirstName_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoFirstNameChosen();

           
            if (keepGoing)
            {
                CheckForNoLastNameChosen();
            }
            else
            {
                return;
            }

           
            if (keepGoing)
            {
                CheckForMatch();
            }
        }

        private bool CheckForNoFirstNameChosen()
        {
            bool retVal = true;

            if (ddlFirstName.SelectedIndex < 0)
            {
                ShowMessage("No First Name Selected!",
                            "NO FIRST NAME");
                retVal = false;
            }

            return retVal;
        }

        private bool CheckForNoLastNameChosen()
        {
            bool retVal = true;

            if (ddlLastName.SelectedIndex < 0)
            {
                ShowMessage("No Last Name Selected!",
                            "NO LAST NAME");
                retVal = false;
            }

            return retVal;
        }


        private void CheckForMatch()
        {
            string term = ddlFirstName.Text.Trim();
            bool isFound = false;
            int indexNumber = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < firstNames.Length; lcv++)
            {
                //search name and publisher

                if (firstNames[lcv].ToLower().Contains(term.ToLower()) || lastNames[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    indexNumber = lcv;
                    break;
                }


                if (isFound)
                {
                    outputStr += ($"{N} {Course[indexNumber]}\r\t\r\n");
                    outputStr += ($"{DES} {CourseG[indexNumber]}\r\n");
                    outputStr += ($"{DIR} {GPA[indexNumber]}\r\n");
                }
                else
                {
                    outputStr += ($"{N} {SNF[indexNumber]}\r\t\r\n");
                    outputStr += ($"{DIR} {SNF[indexNumber]}\r\n");
                    outputStr += ($"{DES} {SNF[indexNumber]}\r\n");
                }

                lblResult.Text = outputStr;

            }

        }


        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
