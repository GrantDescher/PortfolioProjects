using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GarthProject
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            gotoMainPage();
        }

        // Closes SplashScreen and opens the Main Form when either the menu or button is clicked
        private void gotoMainPage()
        {
            Form mainForm = new frmMainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        // Exits the program when either the menu or button is clicked
        private void exitProgramOrNot()
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

        // Loads images to appropriate picture boxes when the form loads
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            pb00.Image = Image.FromFile(AlbumImages.images[0]);
            pb01.Image = Image.FromFile(AlbumImages.images[1]);
            pb02.Image = Image.FromFile(AlbumImages.images[2]);
            pb03.Image = Image.FromFile(AlbumImages.images[3]);
            pb05.Image = Image.FromFile(AlbumImages.images[5]);
            pb09.Image = Image.FromFile(AlbumImages.images[9]);
            pb11.Image = Image.FromFile(AlbumImages.images[11]);
            pb12.Image = Image.FromFile(AlbumImages.images[12]);
            pb13.Image = Image.FromFile(AlbumImages.images[13]);
            pb15.Image = Image.FromFile(AlbumImages.images[15]);
        }

        private void mainPageMenuItem_Click(object sender, EventArgs e)
        {
            gotoMainPage();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to Use the Garth Brooks Database Application: \n" +
                            "Use the on-screen buttons or the menu at the top of the application to navigate between pages.\n" +
                            "On the main page, click 'Load Data' to open the database.\n" +
                            "Use the textbox and the 'Album Search' button to search for albums in the database.\n" +
                            "To add an album to the database, use the interface at the bottom of the main page and click 'Add New Album'.",
                            "Database Application Help Menu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
    }
}
