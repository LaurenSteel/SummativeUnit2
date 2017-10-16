//Lauren Steel, Oct 5 2017, Cash register summative, to demonstrate understanding of variables, constants, inputs and outputs. 
using System;
using System.Media;
using System.Windows.Forms;

namespace SummativeUnit2
{
    public partial class cashRegister : Form
    {
        //Global Variables 
        int sundaeNumber;
        int flurriesNumber;
        int milkshakeNumber;
        int coneNumber;
        double sundaeTotal, flurriesTotal, milkshakeTotal, coneTotal, subTotal, tax, total, changeDue, tenderedNumber;

        //Global Constants 
        const double SUNDAE_CHARGE = 6.49;
        const double FLURRIES_CHARGE = 4.99;
        const double MILKSHAKE_CHARGE = 2.99;
        const double CONE_CHARGE = 1.99;
        const double HST = 0.13;

        public cashRegister()
        {
            InitializeComponent();
        }     
        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert Numbers from Textboxes
                sundaeNumber = Convert.ToInt16(sundaeTextBox.Text);
                flurriesNumber = Convert.ToInt16(flurrieTextBox.Text);
                milkshakeNumber = Convert.ToInt16(milkshakeTextBox.Text);
                coneNumber = Convert.ToInt16(coneTextBox.Text);

                //Calculations for SubTotal, Tax, Total
                sundaeTotal = sundaeNumber * SUNDAE_CHARGE;
                flurriesTotal = flurriesNumber * FLURRIES_CHARGE;
                milkshakeTotal = milkshakeNumber * MILKSHAKE_CHARGE;
                coneTotal = coneNumber * CONE_CHARGE;
                subTotal = sundaeTotal + flurriesTotal + milkshakeTotal + coneTotal;
                tax = HST * subTotal;
                total = tax + subTotal;

                //Input Calculations to SubTotal, Tax, Total 
                subTotalOutputLabel.Text = subTotal.ToString("C");
                taxOutputLabel.Text = tax.ToString("C");
                totalOutputLabel.Text = total.ToString("C");
            }
            catch
            {
                receiptOutputLabel.Text = "You must enter a number for your order to go through.";
                return;
            }
        }
        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Sound Player Cash 
                SoundPlayer cashPlayer = new SoundPlayer(Properties.Resources.cashSound);
                cashPlayer.Play();

                //Convert Tendered Number from Textbox
                tenderedNumber = Convert.ToInt16(tenderedTextBox.Text);

                //Calculations for Change Due
                changeDue = tenderedNumber - total;

                //Input Calculations to Change Due
                changeDueOutputLabel.Text = changeDue.ToString("C");
            }
            catch
            {
                receiptOutputLabel.Text = "You must enter a number.";
                return;
            }
        }
        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //Sound Player Reciept
            SoundPlayer recieptPlayer = new SoundPlayer(Properties.Resources.recieptSound);
            recieptPlayer.Play();
            //Output Text for Receipt
            receiptOutputLabel.Text = "\n";
            //Titel
            receiptOutputLabel.Text += "                      Soft Serve Parlour Recpt.";
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "\n";
            //Order Number
            receiptOutputLabel.Text += "Order Number 3094";
            receiptOutputLabel.Text += "\n";
            //Date
            receiptOutputLabel.Text += "October 16, 2017";
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "\n";
            //Order
            receiptOutputLabel.Text += "Sundae          x" + sundaeNumber + " @ " + SUNDAE_CHARGE;
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "Flurries          x" + flurriesNumber + " @ " + FLURRIES_CHARGE;
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "Milkshake          x" + milkshakeNumber + " @ " + MILKSHAKE_CHARGE;
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "Cone          x" + coneNumber + " @ " + CONE_CHARGE;
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "\n";
            //SubTotal
            receiptOutputLabel.Text += "SubTotal          " + subTotal.ToString("C");
            receiptOutputLabel.Text += "\n";
            //Tax
            receiptOutputLabel.Text += "Tax          " + tax.ToString("C");
            receiptOutputLabel.Text += "\n";
            //Total
            receiptOutputLabel.Text += "Total          " + total.ToString("C");
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "\n";
            //Tendered
            receiptOutputLabel.Text += "Tendered          " + tenderedNumber.ToString("C");
            receiptOutputLabel.Text += "\n";
            //Change Due
            receiptOutputLabel.Text += "Change          " + changeDue.ToString("C");
            receiptOutputLabel.Text += "\n";
            receiptOutputLabel.Text += "\n";
            //End Message
            receiptOutputLabel.Text += "Have a great day!";
        }
            private void newOrderButton_Click(object sender, EventArgs e)
            {
            //Clear Register
            receiptOutputLabel.Text = "";
            subTotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
            changeDueOutputLabel.Text = "";
            sundaeTextBox.Text = "";
            flurrieTextBox.Text = "";
            milkshakeTextBox.Text = "";
            coneTextBox.Text = "";
            tenderedTextBox.Text = "";
            }
        }
    }
