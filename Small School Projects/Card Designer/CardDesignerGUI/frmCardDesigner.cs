using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDesignerGUI
{
    public partial class frmCardDesigner : Form
    {
        public frmCardDesigner()
        {
            InitializeComponent();
        }
        const decimal SPRING = 1.25m;
        const decimal OCEAN = 1.50m;
        const decimal MOUNTAIN = 1.75m;
        const decimal ENVELOPE = .25m;
        const decimal STAMP = .50m;
        const decimal CUSTOMMESSAGE = .25m;

        string[] occassion =
        {
            "Birthday",
            "Thank you",
            "Get Well Soon"
        };

        string[] style =
        {
            "Spring ($1.25)",
            "Ocean ($1.50)",
            "Mountain ($1.75)"
        };

        string[] styleImages =
        {
            @"C:\\Users\\Grant\\Desktop\\AWD1100-Fall2022-GrantDescher\\HOTs\\HOTs\\CardDesignerGUI\\Images\\Spring.jpg",
            @"C:\\Users\\Grant\\Desktop\\AWD1100-Fall2022-GrantDescher\\HOTs\\HOTs\\CardDesignerGUI\\Images\\ocean.jpg",
            @"C:\\Users\\Grant\\Desktop\\AWD1100-Fall2022-GrantDescher\\HOTs\\HOTs\\CardDesignerGUI\\Images\\mountain.jpg"
        };

        private void frmCardDesigner_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < occassion.Length; i++)
            {
                ddlOccassion.Items.Add(occassion[i]);
                ddlStyle.Items.Add(style[i]);
                pbxPreview.Image = Image.FromFile(styleImages[i]);
            }

            ddlOccassion.SelectedIndex = 0;
            ddlStyle.SelectedIndex = 0;
            pbxPreview.Image = Image.FromFile(styleImages[0]);
            txtCustomMessage.ReadOnly = true;
        }

        private void ddlStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStyleImage();
        }

        private void showStyleImage()
        {
            if (ddlStyle.SelectedIndex == 0)
            {
                pbxPreview.Image = Image.FromFile(styleImages[0]);
            }
            if (ddlStyle.SelectedIndex == 1)
            {
                pbxPreview.Image = Image.FromFile(styleImages[1]);
            }
            if (ddlStyle.SelectedIndex == 2)
            {
                pbxPreview.Image = Image.FromFile(styleImages[2]);
            }
        }

        private void cbxCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustomMessage.Checked)
            {
                txtCustomMessage.ReadOnly = false;
            }

            if (!cbxCustomMessage.Checked)
            {
                txtCustomMessage.ReadOnly = true;
                txtCustomMessage.Text = "";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            showMsg();
            calculateCost();
        }

        private void showMsg()
        {
            if (ddlOccassion.SelectedIndex == 0)
            {
                MessageBox.Show("Occassion: Birthday" + "\n\nCustom Message: " + txtCustomMessage.Text, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ddlOccassion.SelectedIndex == 1)
            {
                MessageBox.Show("Occassion: Thank you" + "\n\nCustom Message: " + txtCustomMessage.Text, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ddlOccassion.SelectedIndex == 2)
            {
                MessageBox.Show("Occassion: Get Well Soon" + "\n\nCustom Message: " + txtCustomMessage.Text, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void calculateCost()
        {
            decimal totalCost = 0m;
            if (ddlStyle.SelectedIndex == 0)
            {
                totalCost += SPRING;
            }

            if (ddlStyle.SelectedIndex == 1)
            {
                totalCost += OCEAN;
            }

            if (ddlStyle.SelectedIndex == 2)
            {
                totalCost += MOUNTAIN;
            }

            if (cbxEnvelope.Checked)
            {
                totalCost += ENVELOPE;
            }

            if (cbxStamp.Checked)
            {
                totalCost += STAMP;
            }

            if (cbxCustomMessage.Checked)
            {
                totalCost += CUSTOMMESSAGE;
            }

            lblCost.Text = "Cost: " + totalCost.ToString("c");
        }
    }
}
