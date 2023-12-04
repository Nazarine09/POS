using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmPurchaseDiscountedItem : Form
    {
        private double item;
        private int quantity;
        private double price;
        private double discount;
        public FrmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void ButtonCompute_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(TextBoxQty.Text);
            price = Convert.ToDouble(TextBoxPrice.Text);
            discount = Convert.ToDouble(TextBoxDiscount.Text);

            item = (price * quantity) - ((discount * 0.01) * (price * quantity));
            LabelAmount.Text = item.ToString();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            double paymentReceived = Convert.ToDouble(TextBoxPayment.Text);
            double change = paymentReceived - item;
            LabelChng.Text = change.ToString();
        }
    }
}