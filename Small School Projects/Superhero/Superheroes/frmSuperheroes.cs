using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superheroes
{
    public partial class frmSuperheroes : Form
    {
        public frmSuperheroes()
        {
            InitializeComponent();
        }

        //  Global Arrays
        string[] superHeroNames = {
            "Marvel SuperHeroes",
            "Captain America",
            "The Incredible Hulk",
            "The Invincible Iron Man",
            "The Mighty Thor",
            "The Sub-Mariner"
        };

        string[] superHeroAlterEgo = {
            "Not Applicable",
            "Steve Rogers",
            "Bruce Banner",
            "Tony Stark",
            "Thor Odinson",
            "Prince Namor"
        };

        string[] superHeroImages = {
            @"C:\\Users\\Grant\\Desktop\\AWD1100-Fall2022-GrantDescher\\Labs\\LabsCh9-10\\Superheroes\\Images\\00-all.png",
            @"C:\Users\Grant\Desktop\AWD1100-Fall2022-GrantDescher\Labs\LabsCh9-10\Superheroes\Images\01-captainamerica.png",
            @"C:\Users\Grant\Desktop\AWD1100-Fall2022-GrantDescher\Labs\LabsCh9-10\Superheroes\Images\02-hulk.png",
            @"C:\Users\Grant\Desktop\AWD1100-Fall2022-GrantDescher\Labs\LabsCh9-10\Superheroes\Images\03-ironman.png",
            @"C:\Users\Grant\Desktop\AWD1100-Fall2022-GrantDescher\Labs\LabsCh9-10\Superheroes\Images\04-thor.png",
            @"C:\Users\Grant\Desktop\AWD1100-Fall2022-GrantDescher\Labs\LabsCh9-10\Superheroes\Images\05-submariner.png"
        };

        string[] superHeroBio = {
            "The Marvel Super Heroes is an American animated television series starring five comic book superheroes from Marvel Comics. The first TV series based on Marvel characters, it debuted in syndication on U.S. television in 1966. The segments were Captain America, The Incredible Hulk, Iron Man, The Mighty Thor and The Sub-Mariner.",
            "Captain America was designed as a patriotic supersoldier who often fought the Axis powers of World War II. Captain America is the alter ego of Steve Rogers, a frail young artist enhanced to the peak of human perfection by an experimental super-soldier serum after joining the military to aid the United States government's efforts in World War II.",
            "The Hulk is a green-skinned, hulking and muscular humanoid possessing a limitless degree of physical strength, and his alter ego Dr. Robert Bruce Banner, a physically weak, socially withdrawn, and emotionally reserved physicist. The two exist as independent dissociative personalities, and resent each other, following Banner's accidental exposure to gamma rays,",
            "Iron Man is a superhero appearing in comic books published by Marvel Comics. Wealthy business magnate, playboy, philanthropist, inventor and scientist Anthony Edward Stark suffers a severe chest injury during a kidnapping. When his captors attempt to force him to build a weapon of mass destruction, he instead creates a mechanized suit of armor to save his life and escape captivity.",
            "Thor Odinson, or simply Thor, is a fictional character appearing in American comic books published by Marvel Comics. The character is based on the Norse deity of the same name, the Asgardian god of thunder whose enchanted hammer Mjolnir enables him to fly and manipulate weather, among his other superhuman attributes.",
            "Namor McKenzie, also known as the Sub-Mariner, is a fictional character appearing in American comic books published by Marvel Comics. The mutant son of a human sea captain and a princess of the mythical undersea kingdom of Atlantis, Namor possesses the super-strength and aquatic abilities of the Homo mermanus race, as well as the mutant ability of flight, along with other superhuman powers."
        };

        string[] superHeroURL = {
            "https://en.wikipedia.org/wiki/The_Marvel_Super_Heroes",
            "https://en.wikipedia.org/wiki/Captain_America",
            "https://en.wikipedia.org/wiki/Hulk",
            "https://en.wikipedia.org/wiki/Iron_Man",
            "https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)",
            "https://en.wikipedia.org/wiki/Namor"
        };

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void clearAndSetFocus()
        {
            picSuperheroImage.Image = Image.FromFile(superHeroImages[0]);
            lblName.Text        = "";
            lblAlterEgo.Text    = "";
            lblBio.Text         = "";
            lblURL.Text         = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void ddlSuperhero_SelectedIndexChanged(object sender, EventArgs e)
        {
            callTheDriver();
        }

        private void callTheDriver()
        {
            int selection = ddlSuperhero.SelectedIndex;

            // Was nothing in ddlist selected
            if (ddlSuperhero.SelectedIndex == -1)
            {
                showMsg("You Must Pick a Super Hero!",
                        "No Superhero Chosen");

                return;
            }

            //Something in the drop down list was chosen
            switch (selection)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    createSuperHero(selection);
                    break;

                default:
                    break;
            }
        }

        private void showMsg(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void createSuperHero(int lcv)
        {
            picSuperheroImage.Image = Image.FromFile(superHeroImages[lcv]);
            lblName.Text = "Name: " + superHeroNames[lcv];
            lblAlterEgo.Text = "Alter Ego: " + superHeroAlterEgo[lcv];
            lblBio.Text = "Bio: " + superHeroBio[lcv];
            lblURL.Text = "URL: " + superHeroURL[lcv];
        }

        private void frmSuperheroes_Load(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < superHeroNames.Length; lcv++)
            {
                ddlSuperhero.Items.Add(superHeroNames[lcv]);
            }

            createSuperHero(0);
        }
    }
}
