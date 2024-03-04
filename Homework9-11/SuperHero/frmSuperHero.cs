using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHero
{
   


    public partial class frmSuperHero : Form
    {
        string[] superHeroNames =
   {
        "Hulk",
        "Spiderman",
        "Thor",
        "Black Panther",
        "Venom"
    };

        string[] AlterEgo = {"Docter Banner", 
            "Peter Parker", 
            "NA", 
            "T'Challa", 
            "Eddie Brock"
        };

        string[] Bio = {"Dr. Bruce Banner lives a life caught between the soft-spoken scientist he's always been and the uncontrollable green monster powered by his rage.",
            "American teenager Peter Parker, a poor sickly orphan, is bitten by a radioactive spider. As a result of the bite, he gains superhuman strength, speed, and agility, along with the ability to cling to walls, turning him into Spider-Man.",

            "The God of Thunder. Thor was born to the King of the Asgardian Gods, Odin Borson, and the Earth Goddess Gaea. ",

            "Black Panther is the title held by T'Challa, a member of the royal family of the fictional African country of Wakanda." ,

            "The first and most infamous man to call himself Venom, Eddie Brock was bound to an alien symbiote following its rejection by Peter Parker. Driven by all-consuming hatred, Venom's sole desire was to kill Spider-Man."
};

        string[] Superpictures = { "C:\\Users\\janic\\Downloads\\chapter 9-11 homework\\Homework9-11\\SuperHero\\images\\hulks.jpg",

        "C:\\Users\\janic\\Downloads\\chapter 9-11 homework\\Homework9-11\\SuperHero\\images\\spiderman.jpg",

        "C:\\Users\\janic\\Downloads\\chapter 9-11 homework\\Homework9-11\\SuperHero\\images\\Thor.jpg",

        "C:\\Users\\janic\\Downloads\\chapter 9-11 homework\\Homework9-11\\SuperHero\\images\\Balck Panther.jpg",

        "C:\\Users\\janic\\Downloads\\chapter 9-11 homework\\Homework9-11\\SuperHero\\images\\Venom.jpg"

        };

        public frmSuperHero()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            pbSuperHero.Image = System.Drawing.Image.FromFile(Superpictures[0]);

            lblName.Text = "";
            lblAlterEgo.Text = "";
            lblBio.Text = "";
            lblUrl.Text = "";
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }


        private void ddlSuperHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSuper();
        }

        private void FillSuper()
        {
            int selection = ddlSuperHero.SelectedIndex;

            if (ddlSuperHero.SelectedIndex == -1)
            {
                ShowMessage("You must chose a superhero", "No Super hero chosen");

                return;
            }

            switch (selection)
            {
                case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    CreateSuper(selection);
                    break;

                default:
                    break;

            }

            
        }

        private void CreateSuper(int s)
        {
            pbSuperHero.Image = Image.FromFile(Superpictures[s]);

            lblName.Text = $"Name: {superHeroNames[s]}";
            lblAlterEgo.Text = $"Alter Ego: {AlterEgo[s]}";
            lblBio.Text = $"Bio: {Bio[s]}";
        }

        private void frmSuperHero_Load(object sender, EventArgs e)
        {
            LoadDDL();
        }

        private void LoadDDL()
        {
            for (int lcv = 0; lcv < superHeroNames.Length; lcv++)
            {
                ddlSuperHero.Items.Add(superHeroNames[lcv]);


               
            }
        }

    }
}
