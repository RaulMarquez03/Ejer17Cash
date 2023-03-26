namespace Ejer17Cash
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblJoeCash = new System.Windows.Forms.Label();
            this.lblBobCash = new System.Windows.Forms.Label();
            this.lblBankCash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bob receives 10$ from Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Joe receives 10$ from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Give 10$ to bob";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Give 10$ to Joe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblJoeCash
            // 
            this.lblJoeCash.AutoSize = true;
            this.lblJoeCash.Location = new System.Drawing.Point(377, 75);
            this.lblJoeCash.Name = "lblJoeCash";
            this.lblJoeCash.Size = new System.Drawing.Size(93, 20);
            this.lblJoeCash.TabIndex = 4;
            this.lblJoeCash.Text = "Joe has 100$";
            // 
            // lblBobCash
            // 
            this.lblBobCash.AutoSize = true;
            this.lblBobCash.Location = new System.Drawing.Point(377, 118);
            this.lblBobCash.Name = "lblBobCash";
            this.lblBobCash.Size = new System.Drawing.Size(90, 20);
            this.lblBobCash.TabIndex = 5;
            this.lblBobCash.Text = "Bob has 50$";
            // 
            // lblBankCash
            // 
            this.lblBankCash.AutoSize = true;
            this.lblBankCash.Location = new System.Drawing.Point(377, 168);
            this.lblBankCash.Name = "lblBankCash";
            this.lblBankCash.Size = new System.Drawing.Size(103, 20);
            this.lblBankCash.TabIndex = 6;
            this.lblBankCash.Text = "Bank has 100$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBankCash);
            this.Controls.Add(this.lblBobCash);
            this.Controls.Add(this.lblJoeCash);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblJoeCash;
        private Label lblBobCash;
        private Label lblBankCash;
    }
}