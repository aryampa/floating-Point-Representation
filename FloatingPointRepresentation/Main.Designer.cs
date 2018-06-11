namespace FloatingPointRepresentation
{
    partial class Main
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
            this.rbtnTyptical32 = new System.Windows.Forms.RadioButton();
            this.rbtn32Bit = new System.Windows.Forms.RadioButton();
            this.rbtn64Bit = new System.Windows.Forms.RadioButton();
            this.tbxDecInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnsHEX = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnsBin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExponent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSignificand = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblHEX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conver to HEX";
            // 
            // rbtnTyptical32
            // 
            this.rbtnTyptical32.AutoSize = true;
            this.rbtnTyptical32.Location = new System.Drawing.Point(13, 32);
            this.rbtnTyptical32.Name = "rbtnTyptical32";
            this.rbtnTyptical32.Size = new System.Drawing.Size(112, 17);
            this.rbtnTyptical32.TabIndex = 1;
            this.rbtnTyptical32.TabStop = true;
            this.rbtnTyptical32.Text = "Typical 32 Bit Rep";
            this.rbtnTyptical32.UseVisualStyleBackColor = true;
            // 
            // rbtn32Bit
            // 
            this.rbtn32Bit.AutoSize = true;
            this.rbtn32Bit.Location = new System.Drawing.Point(13, 69);
            this.rbtn32Bit.Name = "rbtn32Bit";
            this.rbtn32Bit.Size = new System.Drawing.Size(138, 17);
            this.rbtn32Bit.TabIndex = 2;
            this.rbtn32Bit.TabStop = true;
            this.rbtn32Bit.Text = "IEEE/INTEL 32 Bit Rep";
            this.rbtn32Bit.UseVisualStyleBackColor = true;
            // 
            // rbtn64Bit
            // 
            this.rbtn64Bit.AutoSize = true;
            this.rbtn64Bit.Location = new System.Drawing.Point(13, 113);
            this.rbtn64Bit.Name = "rbtn64Bit";
            this.rbtn64Bit.Size = new System.Drawing.Size(138, 17);
            this.rbtn64Bit.TabIndex = 3;
            this.rbtn64Bit.TabStop = true;
            this.rbtn64Bit.Text = "IEEE/INTEL 64 Bit Rep";
            this.rbtn64Bit.UseVisualStyleBackColor = true;
            this.rbtn64Bit.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tbxDecInput
            // 
            this.tbxDecInput.Location = new System.Drawing.Point(164, 48);
            this.tbxDecInput.Name = "tbxDecInput";
            this.tbxDecInput.Size = new System.Drawing.Size(244, 20);
            this.tbxDecInput.TabIndex = 4;
            this.tbxDecInput.TextChanged += new System.EventHandler(this.tbxDecInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decimal Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Conversion: HEX";
            // 
            // lblAnsHEX
            // 
            this.lblAnsHEX.BackColor = System.Drawing.Color.White;
            this.lblAnsHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsHEX.ForeColor = System.Drawing.Color.Red;
            this.lblAnsHEX.Location = new System.Drawing.Point(164, 96);
            this.lblAnsHEX.Name = "lblAnsHEX";
            this.lblAnsHEX.Size = new System.Drawing.Size(244, 34);
            this.lblAnsHEX.TabIndex = 7;
            this.lblAnsHEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(434, 32);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(245, 37);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Conversion: Binary.";
            // 
            // lblAnsBin
            // 
            this.lblAnsBin.BackColor = System.Drawing.Color.White;
            this.lblAnsBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsBin.ForeColor = System.Drawing.Color.Lime;
            this.lblAnsBin.Location = new System.Drawing.Point(431, 96);
            this.lblAnsBin.Name = "lblAnsBin";
            this.lblAnsBin.Size = new System.Drawing.Size(248, 34);
            this.lblAnsBin.TabIndex = 10;
            this.lblAnsBin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sign:";
            // 
            // lblSign
            // 
            this.lblSign.BackColor = System.Drawing.Color.White;
            this.lblSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.ForeColor = System.Drawing.Color.Red;
            this.lblSign.Location = new System.Drawing.Point(16, 164);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(28, 23);
            this.lblSign.TabIndex = 12;
            this.lblSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Exponent:";
            // 
            // lblExponent
            // 
            this.lblExponent.BackColor = System.Drawing.Color.White;
            this.lblExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExponent.ForeColor = System.Drawing.Color.Blue;
            this.lblExponent.Location = new System.Drawing.Point(51, 164);
            this.lblExponent.Name = "lblExponent";
            this.lblExponent.Size = new System.Drawing.Size(131, 23);
            this.lblExponent.TabIndex = 14;
            this.lblExponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Significand";
            // 
            // lblSignificand
            // 
            this.lblSignificand.BackColor = System.Drawing.Color.White;
            this.lblSignificand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignificand.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblSignificand.Location = new System.Drawing.Point(188, 164);
            this.lblSignificand.Name = "lblSignificand";
            this.lblSignificand.Size = new System.Drawing.Size(216, 23);
            this.lblSignificand.TabIndex = 16;
            this.lblSignificand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(428, 147);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(140, 13);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Representation in HEX:";
            // 
            // lblHEX
            // 
            this.lblHEX.BackColor = System.Drawing.Color.White;
            this.lblHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEX.ForeColor = System.Drawing.Color.Red;
            this.lblHEX.Location = new System.Drawing.Point(428, 164);
            this.lblHEX.Name = "lblHEX";
            this.lblHEX.Size = new System.Drawing.Size(248, 23);
            this.lblHEX.TabIndex = 18;
            this.lblHEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 217);
            this.Controls.Add(this.lblHEX);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblSignificand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblExponent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnsBin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblAnsHEX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDecInput);
            this.Controls.Add(this.rbtn64Bit);
            this.Controls.Add(this.rbtn32Bit);
            this.Controls.Add(this.rbtnTyptical32);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTyptical32;
        private System.Windows.Forms.RadioButton rbtn32Bit;
        private System.Windows.Forms.RadioButton rbtn64Bit;
        private System.Windows.Forms.TextBox tbxDecInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnsHEX;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnsBin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExponent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSignificand;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblHEX;
    }
}

