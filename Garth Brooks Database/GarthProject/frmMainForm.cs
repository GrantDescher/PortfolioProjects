using System;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using MusicLibrary;

namespace GarthProject
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        // Establishes the AlbumsDAO class as the binding source for the database
        BindingSource albumBindingSource = new BindingSource();
        BindingSource songBindingSource = new BindingSource();
        BindingSource factsBindingSource = new BindingSource();
        AlbumsDAO albumsDAO = new AlbumsDAO();
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadAllMusicData();
        }

        // Connects the project to the database and displays the data in the datagridview on the main page
        private void loadAllMusicData()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //  Connect list of albums to DataGridView
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();
            dgvAlbums.DataSource = albumBindingSource;
        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
           gotoSplashScreen();
        }

        // Closes Main Form and opens the SplashScreen when either the menu or button is clicked
        private void gotoSplashScreen()
        {
            Form splashScreen = new frmSplashScreen();
            this.Hide();
            splashScreen.ShowDialog();
        }

        private void loadDataMenuItem_Click(object sender, EventArgs e)
        {
            loadAllMusicData();
        }

        private void splashScreenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gotoSplashScreen();
        }

        private void btnAlbumSearch_Click(object sender, EventArgs e)
        {
            loadSearchMusicData();
        }

        // Loads all data if no search term is entered. If search term is entered, displays the albums from the database that contain the search term
        private void loadSearchMusicData()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //  Connect list of albums to DataGridView
            albumBindingSource.DataSource = albumsDAO.getSearchAlbums(txtAlbumSearch.Text);
            dgvAlbums.DataSource = albumBindingSource;
        }

        private void loadAlbumFacts()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //  Connect list of albums to DataGridView
            dgvAlbumFacts.DataSource = factsBindingSource;
        }

        private void albumSearchMenuItem_Click(object sender, EventArgs e)
        {
            loadSearchMusicData();
        }

        // Displays the picture of the album when the album is clicked in the datagridview
        private void dgvAlbums_CellClick(object sender, 
                                         DataGridViewCellEventArgs e)
        {
            //  https://www.c-sharpcorner.com/UploadFile/74ce7b/static-class-in-C-Sharp/
            DataGridView dgv = (DataGridView)sender;
            int rowClicked = dgv.CurrentRow.Index;

            AlbumsDAO albumsDAO = new AlbumsDAO();

            songBindingSource.DataSource = albumsDAO.getSongsForAlbum((int)dgvAlbums.Rows[rowClicked].Cells[0].Value);

            factsBindingSource.DataSource = albumsDAO.getAlbumFacts((int)dgvAlbums.Rows[rowClicked].Cells[0].Value);

            dgvSongs.DataSource = songBindingSource;

            dgvAlbumFacts.DataSource = factsBindingSource;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        // Exits the program when the menu is clicked
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
    }
}
