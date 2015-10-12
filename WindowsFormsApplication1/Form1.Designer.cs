namespace WindowsFormsApplication1
{
    partial class FormiPhonePurchase
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
            this.groupBoxiPhoneSelection = new System.Windows.Forms.GroupBox();
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.groupBoxColour = new System.Windows.Forms.GroupBox();
            this.groupBoxCapacity = new System.Windows.Forms.GroupBox();
            this.groupBoxAccessories = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelOurName = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton6s = new System.Windows.Forms.RadioButton();
            this.radioButtonGrey = new System.Windows.Forms.RadioButton();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton64 = new System.Windows.Forms.RadioButton();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.labelBasePrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBoxiPhoneSelection.SuspendLayout();
            this.groupBoxModel.SuspendLayout();
            this.groupBoxColour.SuspendLayout();
            this.groupBoxCapacity.SuspendLayout();
            this.groupBoxAccessories.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxiPhoneSelection
            // 
            this.groupBoxiPhoneSelection.Controls.Add(this.pictureBox1);
            this.groupBoxiPhoneSelection.Controls.Add(this.groupBoxCapacity);
            this.groupBoxiPhoneSelection.Controls.Add(this.groupBoxColour);
            this.groupBoxiPhoneSelection.Controls.Add(this.groupBoxModel);
            this.groupBoxiPhoneSelection.Location = new System.Drawing.Point(13, 13);
            this.groupBoxiPhoneSelection.Name = "groupBoxiPhoneSelection";
            this.groupBoxiPhoneSelection.Size = new System.Drawing.Size(435, 407);
            this.groupBoxiPhoneSelection.TabIndex = 0;
            this.groupBoxiPhoneSelection.TabStop = false;
            this.groupBoxiPhoneSelection.Text = "iPhone Selection";
            // 
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.radioButton6s);
            this.groupBoxModel.Controls.Add(this.radioButton6);
            this.groupBoxModel.Location = new System.Drawing.Point(7, 36);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Size = new System.Drawing.Size(156, 100);
            this.groupBoxModel.TabIndex = 0;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = "Model";
            // 
            // groupBoxColour
            // 
            this.groupBoxColour.Controls.Add(this.radioButtonSilver);
            this.groupBoxColour.Controls.Add(this.radioButtonGold);
            this.groupBoxColour.Controls.Add(this.radioButtonGrey);
            this.groupBoxColour.Location = new System.Drawing.Point(7, 158);
            this.groupBoxColour.Name = "groupBoxColour";
            this.groupBoxColour.Size = new System.Drawing.Size(156, 100);
            this.groupBoxColour.TabIndex = 1;
            this.groupBoxColour.TabStop = false;
            this.groupBoxColour.Text = "Colour";
            // 
            // groupBoxCapacity
            // 
            this.groupBoxCapacity.Controls.Add(this.radioButton128);
            this.groupBoxCapacity.Controls.Add(this.radioButton64);
            this.groupBoxCapacity.Controls.Add(this.radioButton16);
            this.groupBoxCapacity.Location = new System.Drawing.Point(7, 282);
            this.groupBoxCapacity.Name = "groupBoxCapacity";
            this.groupBoxCapacity.Size = new System.Drawing.Size(156, 100);
            this.groupBoxCapacity.TabIndex = 2;
            this.groupBoxCapacity.TabStop = false;
            this.groupBoxCapacity.Text = "Capacity";
            // 
            // groupBoxAccessories
            // 
            this.groupBoxAccessories.Controls.Add(this.checkBox3);
            this.groupBoxAccessories.Controls.Add(this.checkBox2);
            this.groupBoxAccessories.Controls.Add(this.checkBox1);
            this.groupBoxAccessories.Location = new System.Drawing.Point(489, 22);
            this.groupBoxAccessories.Name = "groupBoxAccessories";
            this.groupBoxAccessories.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAccessories.TabIndex = 1;
            this.groupBoxAccessories.TabStop = false;
            this.groupBoxAccessories.Text = "Accessories";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.labelBasePrice);
            this.groupBox6.Location = new System.Drawing.Point(489, 147);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 273);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelOurName
            // 
            this.labelOurName.AutoSize = true;
            this.labelOurName.Location = new System.Drawing.Point(635, 490);
            this.labelOurName.Name = "labelOurName";
            this.labelOurName.Size = new System.Drawing.Size(147, 13);
            this.labelOurName.TabIndex = 6;
            this.labelOurName.Text = "Jose Mathew / Vandit Kothari";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 33);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "iPhone &6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton6s
            // 
            this.radioButton6s.AutoSize = true;
            this.radioButton6s.Location = new System.Drawing.Point(7, 65);
            this.radioButton6s.Name = "radioButton6s";
            this.radioButton6s.Size = new System.Drawing.Size(72, 17);
            this.radioButton6s.TabIndex = 1;
            this.radioButton6s.TabStop = true;
            this.radioButton6s.Text = "iPhone 6&s";
            this.radioButton6s.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrey
            // 
            this.radioButtonGrey.AutoSize = true;
            this.radioButtonGrey.Location = new System.Drawing.Point(7, 20);
            this.radioButtonGrey.Name = "radioButtonGrey";
            this.radioButtonGrey.Size = new System.Drawing.Size(81, 17);
            this.radioButtonGrey.TabIndex = 0;
            this.radioButtonGrey.TabStop = true;
            this.radioButtonGrey.Text = "Space &Grey";
            this.radioButtonGrey.UseVisualStyleBackColor = true;
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(6, 44);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(47, 17);
            this.radioButtonGold.TabIndex = 1;
            this.radioButtonGold.TabStop = true;
            this.radioButtonGold.Text = "G&old";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(6, 68);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSilver.TabIndex = 2;
            this.radioButtonSilver.TabStop = true;
            this.radioButtonSilver.Text = "Silve&r";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(7, 29);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(55, 17);
            this.radioButton16.TabIndex = 0;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "&16 GB";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton64
            // 
            this.radioButton64.AutoSize = true;
            this.radioButton64.Location = new System.Drawing.Point(7, 53);
            this.radioButton64.Name = "radioButton64";
            this.radioButton64.Size = new System.Drawing.Size(55, 17);
            this.radioButton64.TabIndex = 1;
            this.radioButton64.TabStop = true;
            this.radioButton64.Text = "6&4 GB";
            this.radioButton64.UseVisualStyleBackColor = true;
            // 
            // radioButton128
            // 
            this.radioButton128.AutoSize = true;
            this.radioButton128.Location = new System.Drawing.Point(7, 77);
            this.radioButton128.Name = "radioButton128";
            this.radioButton128.Size = new System.Drawing.Size(61, 17);
            this.radioButton128.TabIndex = 2;
            this.radioButton128.TabStop = true;
            this.radioButton128.Text = "12&8 GB";
            this.radioButton128.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(184, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&AppleCare Protection Plan";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "L&eather Case";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "&Screen Protector";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelBasePrice
            // 
            this.labelBasePrice.AutoSize = true;
            this.labelBasePrice.Location = new System.Drawing.Point(7, 24);
            this.labelBasePrice.Name = "labelBasePrice";
            this.labelBasePrice.Size = new System.Drawing.Size(58, 13);
            this.labelBasePrice.TabIndex = 0;
            this.labelBasePrice.Text = "Base Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Accessories";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // FormiPhonePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 512);
            this.Controls.Add(this.labelOurName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBoxAccessories);
            this.Controls.Add(this.groupBoxiPhoneSelection);
            this.Name = "FormiPhonePurchase";
            this.Text = "Robellus iPhone Purchase Tool";
            this.groupBoxiPhoneSelection.ResumeLayout(false);
            this.groupBoxModel.ResumeLayout(false);
            this.groupBoxModel.PerformLayout();
            this.groupBoxColour.ResumeLayout(false);
            this.groupBoxColour.PerformLayout();
            this.groupBoxCapacity.ResumeLayout(false);
            this.groupBoxCapacity.PerformLayout();
            this.groupBoxAccessories.ResumeLayout(false);
            this.groupBoxAccessories.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxiPhoneSelection;
        private System.Windows.Forms.GroupBox groupBoxCapacity;
        private System.Windows.Forms.GroupBox groupBoxColour;
        private System.Windows.Forms.GroupBox groupBoxModel;
        private System.Windows.Forms.GroupBox groupBoxAccessories;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelOurName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton128;
        private System.Windows.Forms.RadioButton radioButton64;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonGrey;
        private System.Windows.Forms.RadioButton radioButton6s;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBasePrice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

