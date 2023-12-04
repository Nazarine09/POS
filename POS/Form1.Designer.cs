namespace POS
{
    partial class FrmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelItem=new Label();
            LabelQty=new Label();
            LabelPrice=new Label();
            LabelDiscount=new Label();
            LabelTAmount=new Label();
            LabelAmount=new Label();
            LabelPReceived=new Label();
            LabelChange=new Label();
            LabelChng=new Label();
            TextBoxItem=new TextBox();
            TextBoxQty=new TextBox();
            TextBoxPrice=new TextBox();
            TextBoxDiscount=new TextBox();
            TextBoxPayment=new TextBox();
            ButtonCompute=new Button();
            ButtonSubmit=new Button();
            ButtonAItem=new Button();
            dataGridView1=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LabelItem
            // 
            LabelItem.AutoSize=true;
            LabelItem.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelItem.Location=new Point(12, 23);
            LabelItem.Name="LabelItem";
            LabelItem.Size=new Size(48, 21);
            LabelItem.TabIndex=0;
            LabelItem.Text="Item:";
            // 
            // LabelQty
            // 
            LabelQty.AutoSize=true;
            LabelQty.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelQty.Location=new Point(478, 23);
            LabelQty.Name="LabelQty";
            LabelQty.Size=new Size(40, 21);
            LabelQty.TabIndex=1;
            LabelQty.Text="Qty:";
            // 
            // LabelPrice
            // 
            LabelPrice.AutoSize=true;
            LabelPrice.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrice.Location=new Point(590, 23);
            LabelPrice.Name="LabelPrice";
            LabelPrice.Size=new Size(50, 21);
            LabelPrice.TabIndex=2;
            LabelPrice.Text="Price:";
            // 
            // LabelDiscount
            // 
            LabelDiscount.AutoSize=true;
            LabelDiscount.Font=new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDiscount.Location=new Point(811, 81);
            LabelDiscount.Name="LabelDiscount";
            LabelDiscount.Size=new Size(105, 21);
            LabelDiscount.TabIndex=3;
            LabelDiscount.Text="Discount (%):";
            // 
            // LabelTAmount
            // 
            LabelTAmount.AutoSize=true;
            LabelTAmount.Font=new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTAmount.Location=new Point(767, 233);
            LabelTAmount.Name="LabelTAmount";
            LabelTAmount.Size=new Size(97, 19);
            LabelTAmount.TabIndex=4;
            LabelTAmount.Text="Total Amount:";
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize=true;
            LabelAmount.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAmount.Location=new Point(870, 235);
            LabelAmount.Name="LabelAmount";
            LabelAmount.Size=new Size(92, 15);
            LabelAmount.TabIndex=5;
            LabelAmount.Text="<total amount>";
            LabelAmount.TextAlign=ContentAlignment.TopCenter;
            // 
            // LabelPReceived
            // 
            LabelPReceived.AutoSize=true;
            LabelPReceived.Font=new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPReceived.Location=new Point(767, 295);
            LabelPReceived.Name="LabelPReceived";
            LabelPReceived.Size=new Size(122, 17);
            LabelPReceived.TabIndex=6;
            LabelPReceived.Text="Payment Received:";
            // 
            // LabelChange
            // 
            LabelChange.AutoSize=true;
            LabelChange.Font=new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelChange.Location=new Point(800, 399);
            LabelChange.Name="LabelChange";
            LabelChange.Size=new Size(57, 17);
            LabelChange.TabIndex=7;
            LabelChange.Text="Change:";
            // 
            // LabelChng
            // 
            LabelChng.AutoSize=true;
            LabelChng.Location=new Point(882, 401);
            LabelChng.Name="LabelChng";
            LabelChng.Size=new Size(62, 15);
            LabelChng.TabIndex=8;
            LabelChng.Text="<change>";
            LabelChng.TextAlign=ContentAlignment.TopCenter;
            // 
            // TextBoxItem
            // 
            TextBoxItem.Location=new Point(66, 20);
            TextBoxItem.Name="TextBoxItem";
            TextBoxItem.Size=new Size(370, 23);
            TextBoxItem.TabIndex=9;
            // 
            // TextBoxQty
            // 
            TextBoxQty.Location=new Point(525, 20);
            TextBoxQty.Name="TextBoxQty";
            TextBoxQty.Size=new Size(56, 23);
            TextBoxQty.TabIndex=10;
            TextBoxQty.TextAlign=HorizontalAlignment.Center;
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.Location=new Point(646, 20);
            TextBoxPrice.Name="TextBoxPrice";
            TextBoxPrice.Size=new Size(56, 23);
            TextBoxPrice.TabIndex=11;
            TextBoxPrice.TextAlign=HorizontalAlignment.Center;
            // 
            // TextBoxDiscount
            // 
            TextBoxDiscount.Location=new Point(828, 117);
            TextBoxDiscount.Name="TextBoxDiscount";
            TextBoxDiscount.Size=new Size(76, 23);
            TextBoxDiscount.TabIndex=12;
            TextBoxDiscount.TextAlign=HorizontalAlignment.Center;
            // 
            // TextBoxPayment
            // 
            TextBoxPayment.Location=new Point(895, 289);
            TextBoxPayment.Name="TextBoxPayment";
            TextBoxPayment.Size=new Size(67, 23);
            TextBoxPayment.TabIndex=13;
            TextBoxPayment.TextAlign=HorizontalAlignment.Center;
            // 
            // ButtonCompute
            // 
            ButtonCompute.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCompute.Location=new Point(800, 165);
            ButtonCompute.Name="ButtonCompute";
            ButtonCompute.Size=new Size(133, 32);
            ButtonCompute.TabIndex=14;
            ButtonCompute.Text="Compute";
            ButtonCompute.UseVisualStyleBackColor=true;
            ButtonCompute.Click+=ButtonCompute_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSubmit.Location=new Point(800, 349);
            ButtonSubmit.Name="ButtonSubmit";
            ButtonSubmit.Size=new Size(133, 33);
            ButtonSubmit.TabIndex=15;
            ButtonSubmit.Text="Submit";
            ButtonSubmit.UseVisualStyleBackColor=true;
            ButtonSubmit.Click+=ButtonSubmit_Click;
            // 
            // ButtonAItem
            // 
            ButtonAItem.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAItem.Location=new Point(12, 455);
            ButtonAItem.Name="ButtonAItem";
            ButtonAItem.Size=new Size(119, 35);
            ButtonAItem.TabIndex=16;
            ButtonAItem.Text="Add Item";
            ButtonAItem.UseVisualStyleBackColor=true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(14, 52);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowTemplate.Height=25;
            dataGridView1.Size=new Size(743, 397);
            dataGridView1.TabIndex=17;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(972, 495);
            Controls.Add(dataGridView1);
            Controls.Add(ButtonAItem);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonCompute);
            Controls.Add(TextBoxPayment);
            Controls.Add(TextBoxDiscount);
            Controls.Add(TextBoxPrice);
            Controls.Add(TextBoxQty);
            Controls.Add(TextBoxItem);
            Controls.Add(LabelChng);
            Controls.Add(LabelChange);
            Controls.Add(LabelPReceived);
            Controls.Add(LabelAmount);
            Controls.Add(LabelTAmount);
            Controls.Add(LabelDiscount);
            Controls.Add(LabelPrice);
            Controls.Add(LabelQty);
            Controls.Add(LabelItem);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelItem;
        private Label LabelQty;
        private Label LabelPrice;
        private Label LabelDiscount;
        private Label LabelTAmount;
        private Label LabelAmount;
        private Label LabelPReceived;
        private Label LabelChange;
        private Label LabelChng;
        private TextBox TextBoxItem;
        private TextBox TextBoxQty;
        private TextBox TextBoxPrice;
        private TextBox TextBoxDiscount;
        private TextBox TextBoxPayment;
        private Button ButtonCompute;
        private Button ButtonSubmit;
        private Button ButtonAItem;
        private DataGridView dataGridView1;
    }
}