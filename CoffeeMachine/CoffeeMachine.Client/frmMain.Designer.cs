namespace CoffeeMachine.Client
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSugarQty = new System.Windows.Forms.Label();
            this.lblCreamQty = new System.Windows.Forms.Label();
            this.btnRemoveSugar = new System.Windows.Forms.Button();
            this.btnRemoveCream = new System.Windows.Forms.Button();
            this.btnAddSugar = new System.Windows.Forms.Button();
            this.btnAddCream = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.btnAddCoffee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAmount = new System.Windows.Forms.ComboBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentPayment = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVend = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDispenseChange = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSugarQty);
            this.groupBox1.Controls.Add(this.lblCreamQty);
            this.groupBox1.Controls.Add(this.btnRemoveSugar);
            this.groupBox1.Controls.Add(this.btnRemoveCream);
            this.groupBox1.Controls.Add(this.btnAddSugar);
            this.groupBox1.Controls.Add(this.btnAddCream);
            this.groupBox1.Controls.Add(this.cbSize);
            this.groupBox1.Controls.Add(this.btnAddCoffee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(163, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a coffee";
            // 
            // lblSugarQty
            // 
            this.lblSugarQty.AutoSize = true;
            this.lblSugarQty.Location = new System.Drawing.Point(106, 76);
            this.lblSugarQty.Name = "lblSugarQty";
            this.lblSugarQty.Size = new System.Drawing.Size(13, 13);
            this.lblSugarQty.TabIndex = 9;
            this.lblSugarQty.Text = "0";
            // 
            // lblCreamQty
            // 
            this.lblCreamQty.AutoSize = true;
            this.lblCreamQty.Location = new System.Drawing.Point(106, 52);
            this.lblCreamQty.Name = "lblCreamQty";
            this.lblCreamQty.Size = new System.Drawing.Size(13, 13);
            this.lblCreamQty.TabIndex = 9;
            this.lblCreamQty.Text = "0";
            // 
            // btnRemoveSugar
            // 
            this.btnRemoveSugar.Location = new System.Drawing.Point(72, 72);
            this.btnRemoveSugar.Name = "btnRemoveSugar";
            this.btnRemoveSugar.Size = new System.Drawing.Size(21, 21);
            this.btnRemoveSugar.TabIndex = 8;
            this.btnRemoveSugar.Text = "-";
            this.btnRemoveSugar.UseVisualStyleBackColor = true;
            this.btnRemoveSugar.Click += new System.EventHandler(this.btnRemoveSugar_Click);
            // 
            // btnRemoveCream
            // 
            this.btnRemoveCream.Location = new System.Drawing.Point(72, 48);
            this.btnRemoveCream.Name = "btnRemoveCream";
            this.btnRemoveCream.Size = new System.Drawing.Size(21, 21);
            this.btnRemoveCream.TabIndex = 8;
            this.btnRemoveCream.Text = "-";
            this.btnRemoveCream.UseVisualStyleBackColor = true;
            this.btnRemoveCream.Click += new System.EventHandler(this.btnRemoveCream_Click);
            // 
            // btnAddSugar
            // 
            this.btnAddSugar.Location = new System.Drawing.Point(130, 72);
            this.btnAddSugar.Name = "btnAddSugar";
            this.btnAddSugar.Size = new System.Drawing.Size(21, 21);
            this.btnAddSugar.TabIndex = 8;
            this.btnAddSugar.Text = "+";
            this.btnAddSugar.UseVisualStyleBackColor = true;
            this.btnAddSugar.Click += new System.EventHandler(this.btnAddSugar_Click);
            // 
            // btnAddCream
            // 
            this.btnAddCream.Location = new System.Drawing.Point(130, 48);
            this.btnAddCream.Name = "btnAddCream";
            this.btnAddCream.Size = new System.Drawing.Size(21, 21);
            this.btnAddCream.TabIndex = 8;
            this.btnAddCream.Text = "+";
            this.btnAddCream.UseVisualStyleBackColor = true;
            this.btnAddCream.Click += new System.EventHandler(this.btnAddCream_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(72, 20);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(79, 21);
            this.cbSize.TabIndex = 7;
            this.cbSize.SelectedValueChanged += new System.EventHandler(this.cbSize_SelectedValueChanged);
            // 
            // btnAddCoffee
            // 
            this.btnAddCoffee.Location = new System.Drawing.Point(72, 104);
            this.btnAddCoffee.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddCoffee.Name = "btnAddCoffee";
            this.btnAddCoffee.Size = new System.Drawing.Size(79, 22);
            this.btnAddCoffee.TabIndex = 6;
            this.btnAddCoffee.Text = "Add to Order";
            this.btnAddCoffee.UseVisualStyleBackColor = true;
            this.btnAddCoffee.Click += new System.EventHandler(this.btnAddCoffee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // txtCurrentOrder
            // 
            this.txtCurrentOrder.Location = new System.Drawing.Point(196, 34);
            this.txtCurrentOrder.Margin = new System.Windows.Forms.Padding(1);
            this.txtCurrentOrder.Multiline = true;
            this.txtCurrentOrder.Name = "txtCurrentOrder";
            this.txtCurrentOrder.Size = new System.Drawing.Size(277, 105);
            this.txtCurrentOrder.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current order:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAmount);
            this.groupBox2.Controls.Add(this.btnAddPayment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(11, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(163, 83);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // cbAmount
            // 
            this.cbAmount.FormattingEnabled = true;
            this.cbAmount.Location = new System.Drawing.Point(72, 22);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(76, 21);
            this.cbAmount.TabIndex = 8;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(72, 49);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(76, 22);
            this.btnAddPayment.TabIndex = 7;
            this.btnAddPayment.Text = "Add to Order";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current payment:";
            // 
            // lblCurrentPayment
            // 
            this.lblCurrentPayment.AutoSize = true;
            this.lblCurrentPayment.Location = new System.Drawing.Point(302, 186);
            this.lblCurrentPayment.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCurrentPayment.Name = "lblCurrentPayment";
            this.lblCurrentPayment.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentPayment.TabIndex = 10;
            this.lblCurrentPayment.Text = "--";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(302, 164);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(13, 13);
            this.lblOrderTotal.TabIndex = 12;
            this.lblOrderTotal.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Order total:";
            // 
            // btnVend
            // 
            this.btnVend.Location = new System.Drawing.Point(202, 214);
            this.btnVend.Margin = new System.Windows.Forms.Padding(1);
            this.btnVend.Name = "btnVend";
            this.btnVend.Size = new System.Drawing.Size(76, 22);
            this.btnVend.TabIndex = 9;
            this.btnVend.Text = "Vend!";
            this.btnVend.UseVisualStyleBackColor = true;
            this.btnVend.Click += new System.EventHandler(this.btnVend_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 259);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(491, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDispenseChange
            // 
            this.btnDispenseChange.Location = new System.Drawing.Point(280, 214);
            this.btnDispenseChange.Margin = new System.Windows.Forms.Padding(1);
            this.btnDispenseChange.Name = "btnDispenseChange";
            this.btnDispenseChange.Size = new System.Drawing.Size(76, 22);
            this.btnDispenseChange.TabIndex = 9;
            this.btnDispenseChange.Text = "Get Change";
            this.btnDispenseChange.UseVisualStyleBackColor = true;
            this.btnDispenseChange.Click += new System.EventHandler(this.btnDispenseChange_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(358, 214);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(1);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(76, 22);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 281);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnDispenseChange);
            this.Controls.Add(this.btnVend);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCurrentPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrentOrder);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMain";
            this.Text = "Jolly Jim\'s Java Junction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddCoffee;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCurrentOrder;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAddPayment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblCurrentPayment;
		private System.Windows.Forms.Label lblOrderTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnVend;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbAmount;
        private System.Windows.Forms.Button btnAddCream;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label lblSugarQty;
        private System.Windows.Forms.Label lblCreamQty;
        private System.Windows.Forms.Button btnRemoveSugar;
        private System.Windows.Forms.Button btnRemoveCream;
        private System.Windows.Forms.Button btnAddSugar;
        private System.Windows.Forms.Button btnDispenseChange;
        private System.Windows.Forms.Button btnComplete;
    }
}

