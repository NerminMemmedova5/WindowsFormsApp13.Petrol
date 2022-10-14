namespace WindowsFormsApp13.View
{
    partial class HomeWindow
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
            this.oilstationLbl = new System.Windows.Forms.Label();
            this.petrolnameLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.moneyRadioB = new System.Windows.Forms.RadioButton();
            this.literRadioB = new System.Windows.Forms.RadioButton();
            this.sumpriceLbl = new System.Windows.Forms.Label();
            this.petrolComboB = new System.Windows.Forms.ComboBox();
            this.priceTxtB = new System.Windows.Forms.TextBox();
            this.moneyTxtB = new System.Windows.Forms.TextBox();
            this.literTxtB = new System.Windows.Forms.TextBox();
            this.sumpriceTxtB = new System.Windows.Forms.TextBox();
            this.usdLbl = new System.Windows.Forms.Label();
            this.lLbl = new System.Windows.Forms.Label();
            this.checkListB = new System.Windows.Forms.ListBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oilstationLbl
            // 
            this.oilstationLbl.BackColor = System.Drawing.Color.SteelBlue;
            this.oilstationLbl.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilstationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oilstationLbl.Location = new System.Drawing.Point(28, 9);
            this.oilstationLbl.Name = "oilstationLbl";
            this.oilstationLbl.Size = new System.Drawing.Size(454, 78);
            this.oilstationLbl.TabIndex = 0;
            this.oilstationLbl.Text = "Oil Station";
            this.oilstationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petrolnameLbl
            // 
            this.petrolnameLbl.AutoSize = true;
            this.petrolnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolnameLbl.Location = new System.Drawing.Point(35, 129);
            this.petrolnameLbl.Name = "petrolnameLbl";
            this.petrolnameLbl.Size = new System.Drawing.Size(91, 31);
            this.petrolnameLbl.TabIndex = 1;
            this.petrolnameLbl.Text = "Petrol";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(35, 185);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(81, 31);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Price";
            // 
            // moneyRadioB
            // 
            this.moneyRadioB.AutoSize = true;
            this.moneyRadioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyRadioB.Location = new System.Drawing.Point(41, 264);
            this.moneyRadioB.Name = "moneyRadioB";
            this.moneyRadioB.Size = new System.Drawing.Size(118, 35);
            this.moneyRadioB.TabIndex = 2;
            this.moneyRadioB.TabStop = true;
            this.moneyRadioB.Text = "Money";
            this.moneyRadioB.UseVisualStyleBackColor = true;
            this.moneyRadioB.CheckedChanged += new System.EventHandler(this.moneyRadioB_CheckedChanged);
            // 
            // literRadioB
            // 
            this.literRadioB.AutoSize = true;
            this.literRadioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literRadioB.Location = new System.Drawing.Point(41, 319);
            this.literRadioB.Name = "literRadioB";
            this.literRadioB.Size = new System.Drawing.Size(90, 35);
            this.literRadioB.TabIndex = 2;
            this.literRadioB.TabStop = true;
            this.literRadioB.Text = "Liter";
            this.literRadioB.UseVisualStyleBackColor = true;
            this.literRadioB.CheckedChanged += new System.EventHandler(this.literRadioB_CheckedChanged);
            // 
            // sumpriceLbl
            // 
            this.sumpriceLbl.AutoSize = true;
            this.sumpriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumpriceLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sumpriceLbl.Location = new System.Drawing.Point(35, 460);
            this.sumpriceLbl.Name = "sumpriceLbl";
            this.sumpriceLbl.Size = new System.Drawing.Size(147, 31);
            this.sumpriceLbl.TabIndex = 1;
            this.sumpriceLbl.Text = "Sum Price";
            // 
            // petrolComboB
            // 
            this.petrolComboB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petrolComboB.FormattingEnabled = true;
            this.petrolComboB.Location = new System.Drawing.Point(246, 121);
            this.petrolComboB.Name = "petrolComboB";
            this.petrolComboB.Size = new System.Drawing.Size(177, 39);
            this.petrolComboB.TabIndex = 3;
            this.petrolComboB.SelectedIndexChanged += new System.EventHandler(this.petrolComboB_SelectedIndexChanged);
            // 
            // priceTxtB
            // 
            this.priceTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtB.Location = new System.Drawing.Point(246, 185);
            this.priceTxtB.Name = "priceTxtB";
            this.priceTxtB.Size = new System.Drawing.Size(177, 38);
            this.priceTxtB.TabIndex = 4;
            // 
            // moneyTxtB
            // 
            this.moneyTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyTxtB.Location = new System.Drawing.Point(246, 264);
            this.moneyTxtB.Name = "moneyTxtB";
            this.moneyTxtB.Size = new System.Drawing.Size(177, 38);
            this.moneyTxtB.TabIndex = 4;
            this.moneyTxtB.TextChanged += new System.EventHandler(this.moneyTxtB_TextChanged);
            // 
            // literTxtB
            // 
            this.literTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literTxtB.Location = new System.Drawing.Point(246, 319);
            this.literTxtB.Name = "literTxtB";
            this.literTxtB.Size = new System.Drawing.Size(177, 38);
            this.literTxtB.TabIndex = 4;
            this.literTxtB.TextChanged += new System.EventHandler(this.literTxtB_TextChanged);
            // 
            // sumpriceTxtB
            // 
            this.sumpriceTxtB.Enabled = false;
            this.sumpriceTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumpriceTxtB.Location = new System.Drawing.Point(246, 448);
            this.sumpriceTxtB.Name = "sumpriceTxtB";
            this.sumpriceTxtB.Size = new System.Drawing.Size(177, 62);
            this.sumpriceTxtB.TabIndex = 4;
            // 
            // usdLbl
            // 
            this.usdLbl.AutoSize = true;
            this.usdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdLbl.Location = new System.Drawing.Point(429, 266);
            this.usdLbl.Name = "usdLbl";
            this.usdLbl.Size = new System.Drawing.Size(30, 31);
            this.usdLbl.TabIndex = 1;
            this.usdLbl.Text = "$";
            // 
            // lLbl
            // 
            this.lLbl.AutoSize = true;
            this.lLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLbl.Location = new System.Drawing.Point(429, 323);
            this.lLbl.Name = "lLbl";
            this.lLbl.Size = new System.Drawing.Size(39, 31);
            this.lLbl.TabIndex = 1;
            this.lLbl.Text = "L.";
            // 
            // checkListB
            // 
            this.checkListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListB.FormattingEnabled = true;
            this.checkListB.ItemHeight = 25;
            this.checkListB.Location = new System.Drawing.Point(587, 15);
            this.checkListB.Name = "checkListB";
            this.checkListB.Size = new System.Drawing.Size(336, 379);
            this.checkListB.TabIndex = 5;
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(587, 423);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(146, 58);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(777, 423);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(146, 58);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "$";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 522);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.checkListB);
            this.Controls.Add(this.sumpriceTxtB);
            this.Controls.Add(this.literTxtB);
            this.Controls.Add(this.moneyTxtB);
            this.Controls.Add(this.priceTxtB);
            this.Controls.Add(this.petrolComboB);
            this.Controls.Add(this.literRadioB);
            this.Controls.Add(this.moneyRadioB);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.sumpriceLbl);
            this.Controls.Add(this.lLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usdLbl);
            this.Controls.Add(this.petrolnameLbl);
            this.Controls.Add(this.oilstationLbl);
            this.Name = "HomeWindow";
            this.Text = "HomeWindow";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oilstationLbl;
        private System.Windows.Forms.Label petrolnameLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.RadioButton moneyRadioB;
        private System.Windows.Forms.RadioButton literRadioB;
        private System.Windows.Forms.Label sumpriceLbl;
        private System.Windows.Forms.ComboBox petrolComboB;
        private System.Windows.Forms.TextBox priceTxtB;
        private System.Windows.Forms.TextBox moneyTxtB;
        private System.Windows.Forms.TextBox literTxtB;
        private System.Windows.Forms.TextBox sumpriceTxtB;
        private System.Windows.Forms.Label usdLbl;
        private System.Windows.Forms.Label lLbl;
        private System.Windows.Forms.ListBox checkListB;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label1;
    }
}