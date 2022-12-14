using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_FlashCards
{
    public partial class frmFlashCards : Form
    {
        public frmFlashCards()
        {
            InitializeComponent();
        }

        const int MAXLENGTH = 10;

        List<FlashCard> flashcards = new List<FlashCard>()
        {
            new FlashCard("input" , "data entered into a computer"),
            new FlashCard("processing" , "converting data into information"),
            new FlashCard("output" , "information generated from data"),
            new FlashCard("data" , "unprocessing information"),
            new FlashCard("information" , "processed data")
        };

        private void btnDefine_Click(object sender, EventArgs e)
        {
            if (txtSearchTerm.Text == "")
            {
                MessageBox.Show("No Term Entered Into TextBox",
                                "TERM TEXTBOX EMPTY",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtSearchTerm.Focus();
                return;
            }

            searchForTerm();
        }

        private void searchForTerm()
        {
            for (int i = 0; i < flashcards.Count; i++)
            {
                if (txtSearchTerm.Text.ToLower() == flashcards[i].GetTerm().ToLower())
                {
                    lblDefinition.Text = flashcards[i].GetDefinition();
                    clearBottom();
                    lblDefinition.Visible = true;
                    return;
                }
            }

            if (flashcards.Count < MAXLENGTH)
            {
                lblNewTerm.Visible = true;
                txtNewDefinition.Visible = true;
                btnAdd.Visible = true;
                txtNewDefinition.Focus();
            }
            else
            {
                MessageBox.Show("The List is Already Full",
                                "NO MORE ROOM IN LIST",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                lblNewTerm.Visible = false;
                txtNewDefinition.Visible = false;
                btnAdd.Visible = false;
                clearStuff();
                txtSearchTerm.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTop();
            clearBottom();
        }

        private void clearTop()
        {
            txtSearchTerm.Text = "";
            lblDefinition.Text = "";
            txtSearchTerm.Focus();
        }

        private void clearBottom()
        {
            lblNewTerm.Visible = false;
            txtNewDefinition.Text = "";
            txtNewDefinition.Visible = false;
            btnAdd.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            handleNewTerm();
            clearStuff();
        }

        private void handleNewTerm()
        {
            flashcards.Add(new FlashCard(txtSearchTerm.Text, txtNewDefinition.Text));
            lblDefinition.Text = txtNewDefinition.Text;
            MessageBox.Show("Term added to List",
                                "SUCCESSFUL ADD",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void frmFlashCards_Load(object sender, EventArgs e)
        {
            clearStuff();
        }

        private void clearStuff()
        {
            clearTop();
            clearBottom();
        }
    }
}
