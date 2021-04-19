namespace calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnplsmin = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn79 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btngaring = new System.Windows.Forms.Button();
            this.btnsamadengan = new System.Windows.Forms.Button();
            this.btnaja = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(350, 62);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBS.Font = new System.Drawing.Font("Wingdings 3", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBS.Location = new System.Drawing.Point(28, 80);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(75, 79);
            this.btnBS.TabIndex = 1;
            this.btnBS.Text = "";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCE.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(109, 80);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(77, 79);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(190, 80);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(77, 79);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnplsmin
            // 
            this.btnplsmin.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnplsmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplsmin.Location = new System.Drawing.Point(271, 80);
            this.btnplsmin.Name = "btnplsmin";
            this.btnplsmin.Size = new System.Drawing.Size(77, 79);
            this.btnplsmin.TabIndex = 4;
            this.btnplsmin.Text = "±";
            this.btnplsmin.UseVisualStyleBackColor = false;
            this.btnplsmin.Click += new System.EventHandler(this.btnplsmin_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnplus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(271, 165);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(77, 79);
            this.btnplus.TabIndex = 8;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn79
            // 
            this.btn79.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn79.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn79.Location = new System.Drawing.Point(190, 165);
            this.btn79.Name = "btn79";
            this.btn79.Size = new System.Drawing.Size(77, 79);
            this.btn79.TabIndex = 7;
            this.btn79.Text = "9";
            this.btn79.UseVisualStyleBackColor = false;
            this.btn79.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(109, 165);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 79);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnmin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.Location = new System.Drawing.Point(271, 250);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(77, 79);
            this.btnmin.TabIndex = 12;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(190, 250);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 79);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(109, 250);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 79);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnkali
            // 
            this.btnkali.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnkali.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkali.Location = new System.Drawing.Point(271, 335);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(77, 79);
            this.btnkali.TabIndex = 16;
            this.btnkali.Text = "*";
            this.btnkali.UseVisualStyleBackColor = false;
            this.btnkali.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(190, 335);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 79);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(109, 335);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 79);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumericValue);
            // 
            // btngaring
            // 
            this.btngaring.BackColor = System.Drawing.SystemColors.Desktop;
            this.btngaring.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngaring.Location = new System.Drawing.Point(271, 419);
            this.btngaring.Name = "btngaring";
            this.btngaring.Size = new System.Drawing.Size(77, 79);
            this.btngaring.TabIndex = 20;
            this.btngaring.Text = "/";
            this.btngaring.UseVisualStyleBackColor = false;
            this.btngaring.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btnsamadengan
            // 
            this.btnsamadengan.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnsamadengan.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsamadengan.Location = new System.Drawing.Point(190, 419);
            this.btnsamadengan.Name = "btnsamadengan";
            this.btnsamadengan.Size = new System.Drawing.Size(77, 79);
            this.btnsamadengan.TabIndex = 19;
            this.btnsamadengan.Text = "=";
            this.btnsamadengan.UseVisualStyleBackColor = false;
            this.btnsamadengan.Click += new System.EventHandler(this.btnsamadengan_Click);
            // 
            // btnaja
            // 
            this.btnaja.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnaja.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaja.Location = new System.Drawing.Point(109, 419);
            this.btnaja.Name = "btnaja";
            this.btnaja.Size = new System.Drawing.Size(77, 79);
            this.btnaja.TabIndex = 18;
            this.btnaja.Text = ".";
            this.btnaja.UseVisualStyleBackColor = false;
            this.btnaja.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(28, 165);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(77, 79);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(28, 250);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(77, 79);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(28, 335);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 79);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn0.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(26, 420);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(77, 79);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumericValue);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 514);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btngaring);
            this.Controls.Add(this.btnsamadengan);
            this.Controls.Add(this.btnaja);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn79);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnplsmin);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.txtDisplay);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnplsmin;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn79;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btngaring;
        private System.Windows.Forms.Button btnsamadengan;
        private System.Windows.Forms.Button btnaja;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
    }
}

