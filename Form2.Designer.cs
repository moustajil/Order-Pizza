namespace Order_Pizza
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.grSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grTopping = new System.Windows.Forms.GroupBox();
            this.chGreenPapers = new System.Windows.Forms.CheckBox();
            this.chOlivies = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chTomato = new System.Windows.Forms.CheckBox();
            this.chMashrume = new System.Windows.Forms.CheckBox();
            this.chExtraChesse = new System.Windows.Forms.CheckBox();
            this.grCustSize = new System.Windows.Forms.GroupBox();
            this.rdThinkCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.grEat = new System.Windows.Forms.GroupBox();
            this.rdEatOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTopping = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grSize.SuspendLayout();
            this.grTopping.SuspendLayout();
            this.grCustSize.SuspendLayout();
            this.grEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // grSize
            // 
            this.grSize.Controls.Add(this.rdLarge);
            this.grSize.Controls.Add(this.rdMedium);
            this.grSize.Controls.Add(this.rdSmall);
            this.grSize.Location = new System.Drawing.Point(12, 88);
            this.grSize.Name = "grSize";
            this.grSize.Size = new System.Drawing.Size(158, 110);
            this.grSize.TabIndex = 1;
            this.grSize.TabStop = false;
            this.grSize.Text = "Size";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(45, 74);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(63, 20);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Tag = "15";
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(45, 48);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(76, 20);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Tag = "10";
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(45, 22);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(62, 20);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "5";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // grTopping
            // 
            this.grTopping.Controls.Add(this.chGreenPapers);
            this.grTopping.Controls.Add(this.chOlivies);
            this.grTopping.Controls.Add(this.chOnion);
            this.grTopping.Controls.Add(this.chTomato);
            this.grTopping.Controls.Add(this.chMashrume);
            this.grTopping.Controls.Add(this.chExtraChesse);
            this.grTopping.Location = new System.Drawing.Point(176, 88);
            this.grTopping.Name = "grTopping";
            this.grTopping.Size = new System.Drawing.Size(382, 110);
            this.grTopping.TabIndex = 2;
            this.grTopping.TabStop = false;
            this.grTopping.Text = "Topping";
            // 
            // chGreenPapers
            // 
            this.chGreenPapers.AutoSize = true;
            this.chGreenPapers.Location = new System.Drawing.Point(252, 61);
            this.chGreenPapers.Name = "chGreenPapers";
            this.chGreenPapers.Size = new System.Drawing.Size(113, 20);
            this.chGreenPapers.TabIndex = 5;
            this.chGreenPapers.Tag = "10";
            this.chGreenPapers.Text = "Green Papers";
            this.chGreenPapers.UseVisualStyleBackColor = true;
            this.chGreenPapers.CheckedChanged += new System.EventHandler(this.chGreenPapers_CheckedChanged);
            // 
            // chOlivies
            // 
            this.chOlivies.AutoSize = true;
            this.chOlivies.Location = new System.Drawing.Point(252, 22);
            this.chOlivies.Name = "chOlivies";
            this.chOlivies.Size = new System.Drawing.Size(67, 20);
            this.chOlivies.TabIndex = 4;
            this.chOlivies.Tag = "10";
            this.chOlivies.Text = "Olives";
            this.chOlivies.UseVisualStyleBackColor = true;
            this.chOlivies.CheckedChanged += new System.EventHandler(this.chOlivies_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Location = new System.Drawing.Point(142, 61);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(64, 20);
            this.chOnion.TabIndex = 3;
            this.chOnion.Tag = "10";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chTomato
            // 
            this.chTomato.AutoSize = true;
            this.chTomato.Location = new System.Drawing.Point(142, 23);
            this.chTomato.Name = "chTomato";
            this.chTomato.Size = new System.Drawing.Size(76, 20);
            this.chTomato.TabIndex = 2;
            this.chTomato.Tag = "10";
            this.chTomato.Text = "Tomato";
            this.chTomato.UseVisualStyleBackColor = true;
            this.chTomato.CheckedChanged += new System.EventHandler(this.chTomato_CheckedChanged);
            // 
            // chMashrume
            // 
            this.chMashrume.AutoSize = true;
            this.chMashrume.Location = new System.Drawing.Point(26, 61);
            this.chMashrume.Name = "chMashrume";
            this.chMashrume.Size = new System.Drawing.Size(92, 20);
            this.chMashrume.TabIndex = 1;
            this.chMashrume.Tag = "10";
            this.chMashrume.Text = "Mashrume";
            this.chMashrume.UseVisualStyleBackColor = true;
            this.chMashrume.CheckedChanged += new System.EventHandler(this.chMashrume_CheckedChanged);
            // 
            // chExtraChesse
            // 
            this.chExtraChesse.AutoSize = true;
            this.chExtraChesse.Location = new System.Drawing.Point(26, 23);
            this.chExtraChesse.Name = "chExtraChesse";
            this.chExtraChesse.Size = new System.Drawing.Size(101, 20);
            this.chExtraChesse.TabIndex = 0;
            this.chExtraChesse.Tag = "10";
            this.chExtraChesse.Text = "Extra Chase";
            this.chExtraChesse.UseVisualStyleBackColor = true;
            this.chExtraChesse.CheckedChanged += new System.EventHandler(this.chExtraChesse_CheckedChanged);
            // 
            // grCustSize
            // 
            this.grCustSize.Controls.Add(this.rdThinkCrust);
            this.grCustSize.Controls.Add(this.rdThinCrust);
            this.grCustSize.Location = new System.Drawing.Point(564, 88);
            this.grCustSize.Name = "grCustSize";
            this.grCustSize.Size = new System.Drawing.Size(200, 110);
            this.grCustSize.TabIndex = 3;
            this.grCustSize.TabStop = false;
            this.grCustSize.Text = "Cust Size";
            // 
            // rdThinkCrust
            // 
            this.rdThinkCrust.AutoSize = true;
            this.rdThinkCrust.Location = new System.Drawing.Point(45, 60);
            this.rdThinkCrust.Name = "rdThinkCrust";
            this.rdThinkCrust.Size = new System.Drawing.Size(94, 20);
            this.rdThinkCrust.TabIndex = 1;
            this.rdThinkCrust.TabStop = true;
            this.rdThinkCrust.Tag = "25";
            this.rdThinkCrust.Text = "Think Crust";
            this.rdThinkCrust.UseVisualStyleBackColor = true;
            this.rdThinkCrust.CheckedChanged += new System.EventHandler(this.rdThinkCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Location = new System.Drawing.Point(45, 23);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rdThinCrust.TabIndex = 0;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Tag = "15";
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // grEat
            // 
            this.grEat.Controls.Add(this.rdEatOut);
            this.grEat.Controls.Add(this.rdEatIn);
            this.grEat.Location = new System.Drawing.Point(770, 88);
            this.grEat.Name = "grEat";
            this.grEat.Size = new System.Drawing.Size(158, 110);
            this.grEat.TabIndex = 4;
            this.grEat.TabStop = false;
            this.grEat.Text = "Where To Eat";
            // 
            // rdEatOut
            // 
            this.rdEatOut.AutoSize = true;
            this.rdEatOut.Location = new System.Drawing.Point(45, 57);
            this.rdEatOut.Name = "rdEatOut";
            this.rdEatOut.Size = new System.Drawing.Size(71, 20);
            this.rdEatOut.TabIndex = 1;
            this.rdEatOut.TabStop = true;
            this.rdEatOut.Text = "Eat Out";
            this.rdEatOut.UseVisualStyleBackColor = true;
            this.rdEatOut.CheckedChanged += new System.EventHandler(this.rdEatOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Location = new System.Drawing.Point(45, 31);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(61, 20);
            this.rdEatIn.TabIndex = 0;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTopping);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbWher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbCrustType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // lbTopping
            // 
            this.lbTopping.AutoSize = true;
            this.lbTopping.Location = new System.Drawing.Point(124, 63);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(0, 16);
            this.lbTopping.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Topping :";
            // 
            // lbWher
            // 
            this.lbWher.AutoSize = true;
            this.lbWher.Location = new System.Drawing.Point(526, 20);
            this.lbWher.Name = "lbWher";
            this.lbWher.Size = new System.Drawing.Size(0, 16);
            this.lbWher.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Where To Eat : ";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Location = new System.Drawing.Point(283, 21);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(0, 16);
            this.lbCrustType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crust Type : ";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(86, 22);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 16);
            this.lbSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Orange;
            this.lbTotal.Location = new System.Drawing.Point(804, 237);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(82, 89);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "0";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.Orange;
            this.btReset.Location = new System.Drawing.Point(233, 397);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(161, 56);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(420, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Order_Pizza.Properties.Resources.bg_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grEat);
            this.Controls.Add(this.grCustSize);
            this.Controls.Add(this.grTopping);
            this.Controls.Add(this.grSize);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grSize.ResumeLayout(false);
            this.grSize.PerformLayout();
            this.grTopping.ResumeLayout(false);
            this.grTopping.PerformLayout();
            this.grCustSize.ResumeLayout(false);
            this.grCustSize.PerformLayout();
            this.grEat.ResumeLayout(false);
            this.grEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox grTopping;
        private System.Windows.Forms.CheckBox chExtraChesse;
        private System.Windows.Forms.CheckBox chMashrume;
        private System.Windows.Forms.CheckBox chGreenPapers;
        private System.Windows.Forms.CheckBox chOlivies;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chTomato;
        private System.Windows.Forms.GroupBox grCustSize;
        private System.Windows.Forms.RadioButton rdThinkCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.GroupBox grEat;
        private System.Windows.Forms.RadioButton rdEatOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbWher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTopping;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button button2;
    }
}