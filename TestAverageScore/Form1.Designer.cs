namespace TestAverageScore
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Test1Box = new System.Windows.Forms.TextBox();
            this.Test3Box = new System.Windows.Forms.TextBox();
            this.Test2Box = new System.Windows.Forms.TextBox();
            this.CalcAvg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AverageBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Test 3:";
            // 
            // Test1Box
            // 
            this.Test1Box.Location = new System.Drawing.Point(167, 61);
            this.Test1Box.Name = "Test1Box";
            this.Test1Box.Size = new System.Drawing.Size(127, 20);
            this.Test1Box.TabIndex = 5;
            // 
            // Test3Box
            // 
            this.Test3Box.Location = new System.Drawing.Point(167, 136);
            this.Test3Box.Name = "Test3Box";
            this.Test3Box.Size = new System.Drawing.Size(127, 20);
            this.Test3Box.TabIndex = 6;
            // 
            // Test2Box
            // 
            this.Test2Box.Location = new System.Drawing.Point(167, 98);
            this.Test2Box.Name = "Test2Box";
            this.Test2Box.Size = new System.Drawing.Size(127, 20);
            this.Test2Box.TabIndex = 7;
            // 
            // CalcAvg
            // 
            this.CalcAvg.Location = new System.Drawing.Point(23, 251);
            this.CalcAvg.Name = "CalcAvg";
            this.CalcAvg.Size = new System.Drawing.Size(96, 37);
            this.CalcAvg.TabIndex = 8;
            this.CalcAvg.Text = "Calculate Average";
            this.CalcAvg.UseVisualStyleBackColor = true;
            this.CalcAvg.Click += new System.EventHandler(this.CalcAvg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average Test Score:";
            // 
            // AverageBox
            // 
            this.AverageBox.Location = new System.Drawing.Point(167, 190);
            this.AverageBox.Name = "AverageBox";
            this.AverageBox.Size = new System.Drawing.Size(127, 20);
            this.AverageBox.TabIndex = 10;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(135, 251);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(83, 36);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(233, 252);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(83, 36);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 319);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AverageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalcAvg);
            this.Controls.Add(this.Test2Box);
            this.Controls.Add(this.Test3Box);
            this.Controls.Add(this.Test1Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Test1Box;
        private System.Windows.Forms.TextBox Test3Box;
        private System.Windows.Forms.TextBox Test2Box;
        private System.Windows.Forms.Button CalcAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AverageBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

