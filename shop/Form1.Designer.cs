namespace shop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.receipt = new System.Windows.Forms.Button();
            this.cacTotal = new System.Windows.Forms.Button();
            this.cacChange = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.amntElfo = new System.Windows.Forms.TextBox();
            this.amntBean = new System.Windows.Forms.TextBox();
            this.amntBottle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.outputSub = new System.Windows.Forms.Label();
            this.outputChange = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.outputTax = new System.Windows.Forms.Label();
            this.inputTender = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.errorOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(93, 1046);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(317, 72);
            this.receipt.TabIndex = 2;
            this.receipt.Text = "Print Receipt";
            this.receipt.UseVisualStyleBackColor = true;
            this.receipt.Click += new System.EventHandler(this.Receipt_Click);
            // 
            // cacTotal
            // 
            this.cacTotal.Location = new System.Drawing.Point(93, 409);
            this.cacTotal.Name = "cacTotal";
            this.cacTotal.Size = new System.Drawing.Size(317, 72);
            this.cacTotal.TabIndex = 3;
            this.cacTotal.Text = "Caculate Zogs Due";
            this.cacTotal.UseVisualStyleBackColor = true;
            this.cacTotal.Click += new System.EventHandler(this.CacTotal_Click);
            // 
            // cacChange
            // 
            this.cacChange.Location = new System.Drawing.Point(93, 898);
            this.cacChange.Name = "cacChange";
            this.cacChange.Size = new System.Drawing.Size(317, 72);
            this.cacChange.TabIndex = 4;
            this.cacChange.Text = "Caculate Zogs Back";
            this.cacChange.UseVisualStyleBackColor = true;
            this.cacChange.Click += new System.EventHandler(this.CacChange_Click);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(692, 1046);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(317, 72);
            this.newOrder.TabIndex = 5;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hi Im Elfo\r\n(Hi Im Elfo)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 812);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zogs Given";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sub Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shouting Tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 58);
            this.label5.TabIndex = 10;
            this.label5.Text = "The Bean Special\r\n(Helps With Buck Teeth)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 58);
            this.label6.TabIndex = 11;
            this.label6.Text = "This Ones So Poiso-\r\n(Cant hold it in a bottle)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 989);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zogs Returned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 705);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Zogs Due";
            // 
            // amntElfo
            // 
            this.amntElfo.Location = new System.Drawing.Point(310, 147);
            this.amntElfo.Name = "amntElfo";
            this.amntElfo.Size = new System.Drawing.Size(100, 35);
            this.amntElfo.TabIndex = 14;
            // 
            // amntBean
            // 
            this.amntBean.Location = new System.Drawing.Point(310, 306);
            this.amntBean.Name = "amntBean";
            this.amntBean.Size = new System.Drawing.Size(100, 35);
            this.amntBean.TabIndex = 15;
            // 
            // amntBottle
            // 
            this.amntBottle.Location = new System.Drawing.Point(310, 225);
            this.amntBottle.Name = "amntBottle";
            this.amntBottle.Size = new System.Drawing.Size(100, 35);
            this.amntBottle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(38, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(761, 69);
            this.label9.TabIndex = 17;
            this.label9.Text = "Little Seizures Poison Shop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Amount";
            // 
            // outputSub
            // 
            this.outputSub.AutoSize = true;
            this.outputSub.Location = new System.Drawing.Point(319, 548);
            this.outputSub.Name = "outputSub";
            this.outputSub.Size = new System.Drawing.Size(69, 29);
            this.outputSub.TabIndex = 19;
            this.outputSub.Text = "0.00z";
            // 
            // outputChange
            // 
            this.outputChange.AutoSize = true;
            this.outputChange.Location = new System.Drawing.Point(319, 989);
            this.outputChange.Name = "outputChange";
            this.outputChange.Size = new System.Drawing.Size(69, 29);
            this.outputChange.TabIndex = 21;
            this.outputChange.Text = "0.00z";
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Location = new System.Drawing.Point(319, 705);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(69, 29);
            this.outputTotal.TabIndex = 23;
            this.outputTotal.Text = "0.00z";
            // 
            // outputTax
            // 
            this.outputTax.AutoSize = true;
            this.outputTax.Location = new System.Drawing.Point(319, 630);
            this.outputTax.Name = "outputTax";
            this.outputTax.Size = new System.Drawing.Size(69, 29);
            this.outputTax.TabIndex = 24;
            this.outputTax.Text = "0.00z";
            // 
            // inputTender
            // 
            this.inputTender.Location = new System.Drawing.Point(310, 806);
            this.inputTender.Name = "inputTender";
            this.inputTender.Size = new System.Drawing.Size(100, 35);
            this.inputTender.TabIndex = 25;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(416, 306);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 29);
            this.label.TabIndex = 26;
            this.label.Text = "9.00z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 29);
            this.label12.TabIndex = 27;
            this.label12.Text = "5.00z";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 29);
            this.label13.TabIndex = 28;
            this.label13.Text = "1.00z";
            // 
            // errorOutput
            // 
            this.errorOutput.AutoSize = true;
            this.errorOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.errorOutput.Location = new System.Drawing.Point(574, 124);
            this.errorOutput.Name = "errorOutput";
            this.errorOutput.Size = new System.Drawing.Size(0, 55);
            this.errorOutput.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1335, 1155);
            this.Controls.Add(this.errorOutput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label);
            this.Controls.Add(this.inputTender);
            this.Controls.Add(this.outputTax);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.outputChange);
            this.Controls.Add(this.outputSub);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amntBottle);
            this.Controls.Add(this.amntBean);
            this.Controls.Add(this.amntElfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.cacChange);
            this.Controls.Add(this.cacTotal);
            this.Controls.Add(this.receipt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.Button cacTotal;
        private System.Windows.Forms.Button cacChange;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amntElfo;
        private System.Windows.Forms.TextBox amntBean;
        private System.Windows.Forms.TextBox amntBottle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label outputSub;
        private System.Windows.Forms.Label outputChange;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Label outputTax;
        private System.Windows.Forms.TextBox inputTender;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label errorOutput;
    }
}

