using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5_JobEstimat
{
    public partial class frmJobEstimate : Form
    {
        public frmJobEstimate()
        {
            InitializeComponent();
        }

        // Global Constant
        const decimal TRIPFEE = 35.00m;

        // Global Variables
        List<Job> jobs = new List<Job>();
        decimal hoursToComplete = 0.00m;
        decimal hourlyRate      = 0.00m;
        decimal totalFee        = 0.00m;

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void clearAndSetFocus()
        {
            txtDescription.Text = "";
            txtHoursToComplete.Text = "";
            txtHourlyRate.Text = "";
            lblDescriptionCurrent.Text = "";
            lblHoursToCompleteCurrent.Text = "";
            lblHourlyRateCurrent.Text = "";
            lblTotalFee.Text = "";
            txtDescription.Focus();
        }

        private void frmJobEstimate_Load(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal result = 0.00m;

            bool keepGoing = validateDescription();
            if (keepGoing)
            {
                keepGoing = validateHoursToComplete();
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing = validateHourlyRate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                // Instantiate new job object
                Job theJob = new Job(txtDescription.Text, hoursToComplete, hourlyRate);

                result = theJob.HoursToComplete * theJob.HourlyFee + TRIPFEE;

                lblTotalFeeCurrent.Text = result.ToString("c");
                jobs.Add(theJob);

                MessageBox.Show("Description: " + theJob.Description + "\n" +
                                "Hours To Complete: " + theJob.HoursToComplete.ToString("n2") + "\n" +
                                "Hourly Fee: " + theJob.HourlyFee.ToString("c") +
                                "Total Fee: " + theJob.TotalFee.ToString("c"));
            }
        }

        public bool validateDescription()
        {
            bool retVal = true;

            if (txtDescription.Text.Trim() == "")
            {
                showMessageBox("Cannot Have an Empty Description",
                                "EMPTY DESCRIPTION");
                txtDescription.Focus();
                retVal = false;
            }

            return retVal;
        }

        public bool validateHoursToComplete()
        {
            bool retVal = true;
            bool result;

            if (txtHoursToComplete.Text.Trim() == "")
            {
                showMessageBox("Cannot Have an Empty Hours To Complete",
                                "EMPTY HOURS TO COMPLETE");
                txtHoursToComplete.Focus();
                retVal = false;
            }
            else
            {
                result = Decimal.TryParse(txtHoursToComplete.Text, out hoursToComplete);

                if (!result)
                {
                    showMessageBox("Cannot Have an Non-Numeric Hours To Complete",
                                "NON-NUMERIC HOURS TO COMPLETE");
                    txtHoursToComplete.Focus();
                    txtHoursToComplete.Text = "";
                    retVal = false;
                }
                else
                {
                    if (hoursToComplete <= 0)
                    {
                        showMessageBox("Cannot Have an Negative or 0 Hours To Complete",
                                        "OUT-OF-RANGE HOURS TO COMPLETE");
                        txtHoursToComplete.Focus();
                        txtHoursToComplete.Text = "";
                        retVal = false;
                    }
                }
            }

            return retVal;
        }

        public bool validateHourlyRate()
        {
            bool retVal = true;
            bool result;

            if (txtHourlyRate.Text.Trim() == "")
            {
                showMessageBox("Cannot Have an Empty Hourly Rate",
                                "EMPTY HOURLY RATE");
                txtHourlyRate.Focus();
                retVal = false;
            }
            else
            {
                result = Decimal.TryParse(txtHourlyRate.Text, out hourlyRate);

                if (!result)
                {
                    showMessageBox("Cannot Have an Non-Numeric Hourly Rate",
                                "NON-NUMERIC HOURLY RATE");
                    txtHourlyRate.Focus();
                    txtHourlyRate.Text = "";
                    retVal = false;
                }
                else
                {
                    if (hourlyRate <= 0)
                    {
                        showMessageBox("Cannot Have an Negative or 0 Hourly Rate",
                                        "OUT-OF-RANGE HOURLY RATE");
                        txtHourlyRate.Focus();
                        txtHourlyRate.Text = "";
                        retVal = false;
                    }
                }
            }

            return retVal;
        }

        private void showMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
