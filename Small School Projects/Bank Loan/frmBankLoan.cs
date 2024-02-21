using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT7
{
    public partial class frmBankLoan : Form
    {
        public frmBankLoan()
        {
            InitializeComponent();
        }

        const int SHORTTERMPAYMENT = 450;
        const int LONGTERMPAYMENT  = 200;
        const double SHORTTERMINTEREST =  1.1;
        const double LONGTERMINTEREST  = 1.05;
        const double MINIMUMAMOUNT = 0;
         
        string name;
        string type;
        double balance;
        double payment;
        double interest;



        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            bool success;

            if ((!radShortTerm.Checked) && (!radLongTerm.Checked))
            {
                showMessage("You must choose a loan type", "NO LOAN TYPE CHOSEN");
                return;
            }

            success = validateTextBoxesNotEmpty();

            if (success)
            {
                success = validateAmount();
            }

            else
            {
                return;
            }

            if (radShortTerm.Checked)
            {
                string name = txtName.Text;
                string type = "Short Term";
                double balance = double.Parse(txtAmount.Text);
                double payment = SHORTTERMPAYMENT;
                double interest = SHORTTERMINTEREST;

                ShortTerm s = new ShortTerm(name, type, balance, payment, interest);

                lblManageName.Text = name;
                lblManageType.Text = type;
                lblManageAmount.Text = balance.ToString("c");
                btnMakePayment.Enabled = true;
            }

            if (radLongTerm.Checked)
            {
                string name = txtName.Text;
                string type = "Long Term";
                double balance = double.Parse(txtAmount.Text);
                double payment = LONGTERMPAYMENT;
                double interest = LONGTERMINTEREST;

                LongTerm l = new LongTerm(name, type, balance, payment, interest);

                lblManageName.Text = name;
                lblManageType.Text = type;
                lblManageAmount.Text = balance.ToString("c");
                btnMakePayment.Enabled = true;
            }

        }

        private bool validateTextBoxesNotEmpty()
        {
            bool success = true;

            if (txtName.Text.Trim() == "" || txtAmount.Text.Trim() == "")
            {
                showMessage("Please fill out all fields", "EMPTY FIELD");
                return false;
            }

            else
            {
                success = true;
            }

            return success;
        }

        private bool validateAmount()
        {
            bool success = true;
            double amount;

            if (!Double.TryParse(txtAmount.Text, out amount))
            {
                showMessage("Amount must be a number", "INVALID AMOUNT");
                success = false;
            }
            else
            {
                if (amount <= MINIMUMAMOUNT)
                {
                    showMessage("Amount must be greater than 0", "INVALID AMOUNT");
                    success = false;
                }
            }

            return success;
        }

        private void ConfigureShortTermStats()
        {
            string name = txtName.Text;
            string type = "Short Term";
            double balance = Double.Parse(lblManageAmount.Text); 
            double payment = SHORTTERMPAYMENT;
            double interest = SHORTTERMINTEREST;
            double temp;

            ShortTerm s = new ShortTerm(name, type, balance, payment, interest);

            balance -= SHORTTERMPAYMENT;
            temp = balance;
            ApplyInterest();
            balance += interest;

            btnMakePayment.Enabled = true;

            if (balance < 0)
            {
                balance = 0;
                btnMakePayment.Enabled = false;
            }

            FillBottomLabels(name, type, balance, payment, interest, temp);
        }

        private void ConfigureLongTermStats()
        {
            string name = txtName.Text;
            string type = "Long Term";
            double balance = Double.Parse(lblManageAmount.Text);
            double payment = LONGTERMPAYMENT;
            double interest = LONGTERMINTEREST;
            double temp;

            LongTerm s = new LongTerm(name, type, balance, payment, interest);

            balance -= LONGTERMPAYMENT;
            temp = balance;
            ApplyInterest();
            balance += interest;

            btnMakePayment.Enabled = true;

            if (balance < 0)
            {
                balance = 0;
                btnMakePayment.Enabled = false;
            }

            FillBottomLabels(name, type, balance, payment, interest, temp);
        }

        private void ApplyInterest()
        {
            if (radShortTerm.Checked)
            {
                interest = balance * SHORTTERMINTEREST;
            }
            else if (radLongTerm.Checked)
            {
                interest = balance * LONGTERMINTEREST;
            }
        }

        private void FillBottomLabels(string name, string type, double balance, double payment, double interest, double temp)
        {
            lblManageName.Text = name;
            lblManageType.Text = type;
            lblManageAmount.Text = balance.ToString("c");
            if (temp <= 0)
            {
                lblAmountAfterPayment.Text = "After the last payment the loan is down to $0.00";
            }
            else
            {
                lblAmountAfterPayment.Text = "After the last payment the loan is down to " + temp.ToString("c");
            }
            
            if (balance <= 0)
            {
                lblAmountAfterInterest.Text = "After the last interest accumulation the loan is now $0.00";
                btnMakePayment.Enabled = false;
            }
            else
            {
                lblAmountAfterInterest.Text = "After the last interest accumulation the loan is now " + balance.ToString("c");
            }
        }

        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void clearAndSetFocus()
        {
            txtName.Text = "";
            txtAmount.Text = "";
            txtName.Focus();
            radShortTerm.Checked = false;
            radLongTerm.Checked = false;
            lblManageName.Text = "";
            lblManageType.Text = "";
            lblManageAmount.Text = "";
            lblAmountAfterPayment.Text = "";
            lblAmountAfterInterest.Text = "";
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (radShortTerm.Checked)
            {
                ConfigureShortTermStats();
            }
            else if (radLongTerm.Checked)
            {
                ConfigureLongTermStats();
            }

            MakePayment();
        }

        private void MakePayment()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

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

        private void frmBankLoan_Load(object sender, EventArgs e)
        {
            btnMakePayment.Enabled = false;
        }
    }
}
