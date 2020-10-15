namespace Calculator
{
    partial class MainWin
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
            this.textBox_Solution = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_DeleteOne = new System.Windows.Forms.Button();
            this.button_Subdivide = new System.Windows.Forms.Button();
            this.button_Sqrt = new System.Windows.Forms.Button();
            this.button_power = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_Equals = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button__0 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.labelComputation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Solution
            // 
            this.textBox_Solution.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Solution.Location = new System.Drawing.Point(12, 41);
            this.textBox_Solution.MaxLength = 9;
            this.textBox_Solution.Name = "textBox_Solution";
            this.textBox_Solution.ReadOnly = true;
            this.textBox_Solution.Size = new System.Drawing.Size(319, 38);
            this.textBox_Solution.TabIndex = 0;
            this.textBox_Solution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(174, 85);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 53);
            this.button_C.TabIndex = 4;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Visible = false;
            // 
            // button_DeleteOne
            // 
            this.button_DeleteOne.Location = new System.Drawing.Point(258, 85);
            this.button_DeleteOne.Name = "button_DeleteOne";
            this.button_DeleteOne.Size = new System.Drawing.Size(75, 53);
            this.button_DeleteOne.TabIndex = 5;
            this.button_DeleteOne.Text = "<=";
            this.button_DeleteOne.UseVisualStyleBackColor = true;
            this.button_DeleteOne.Click += new System.EventHandler(this.button_DeleteOne_Click);
            // 
            // button_Subdivide
            // 
            this.button_Subdivide.Location = new System.Drawing.Point(258, 144);
            this.button_Subdivide.Name = "button_Subdivide";
            this.button_Subdivide.Size = new System.Drawing.Size(75, 53);
            this.button_Subdivide.TabIndex = 9;
            this.button_Subdivide.Text = "%";
            this.button_Subdivide.UseVisualStyleBackColor = true;
            this.button_Subdivide.Click += new System.EventHandler(this.button_Subdivide_Click);
            // 
            // button_Sqrt
            // 
            this.button_Sqrt.Location = new System.Drawing.Point(174, 144);
            this.button_Sqrt.Name = "button_Sqrt";
            this.button_Sqrt.Size = new System.Drawing.Size(75, 53);
            this.button_Sqrt.TabIndex = 8;
            this.button_Sqrt.Text = "sqrt(x)";
            this.button_Sqrt.UseVisualStyleBackColor = true;
            this.button_Sqrt.Visible = false;
            // 
            // button_power
            // 
            this.button_power.Location = new System.Drawing.Point(93, 144);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(75, 53);
            this.button_power.TabIndex = 7;
            this.button_power.Text = "X^2";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 144);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 53);
            this.button8.TabIndex = 6;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(174, 203);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(75, 53);
            this.button_9.TabIndex = 12;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(93, 203);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(75, 53);
            this.button_8.TabIndex = 11;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(12, 203);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(75, 53);
            this.button_7.TabIndex = 10;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_Subtract
            // 
            this.button_Subtract.Location = new System.Drawing.Point(258, 262);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(75, 53);
            this.button_Subtract.TabIndex = 17;
            this.button_Subtract.Text = "-";
            this.button_Subtract.UseVisualStyleBackColor = true;
            this.button_Subtract.Click += new System.EventHandler(this.button_Subtract_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(174, 262);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(75, 53);
            this.button_6.TabIndex = 16;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(93, 262);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(75, 53);
            this.button_5.TabIndex = 15;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(12, 262);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(75, 53);
            this.button_4.TabIndex = 14;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(258, 319);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 53);
            this.button_Add.TabIndex = 21;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(174, 319);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(75, 53);
            this.button_3.TabIndex = 20;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(93, 319);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 53);
            this.button_2.TabIndex = 19;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(12, 319);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 53);
            this.button_1.TabIndex = 18;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_Equals
            // 
            this.button_Equals.Location = new System.Drawing.Point(258, 378);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(75, 53);
            this.button_Equals.TabIndex = 25;
            this.button_Equals.Text = "=";
            this.button_Equals.UseVisualStyleBackColor = true;
            this.button_Equals.Visible = false;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(174, 378);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 53);
            this.button22.TabIndex = 24;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Visible = false;
            // 
            // button__0
            // 
            this.button__0.Location = new System.Drawing.Point(93, 378);
            this.button__0.Name = "button__0";
            this.button__0.Size = new System.Drawing.Size(75, 53);
            this.button__0.TabIndex = 23;
            this.button__0.Text = "0";
            this.button__0.UseVisualStyleBackColor = true;
            this.button__0.Click += new System.EventHandler(this.button__0_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(12, 378);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 53);
            this.button24.TabIndex = 22;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Visible = false;
            // 
            // labelComputation
            // 
            this.labelComputation.AutoSize = true;
            this.labelComputation.Location = new System.Drawing.Point(13, 13);
            this.labelComputation.Name = "labelComputation";
            this.labelComputation.Size = new System.Drawing.Size(0, 13);
            this.labelComputation.TabIndex = 26;
            this.labelComputation.Visible = false;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 443);
            this.Controls.Add(this.labelComputation);
            this.Controls.Add(this.button_Equals);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button__0);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_Subdivide);
            this.Controls.Add(this.button_Sqrt);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button_DeleteOne);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Solution);
            this.Name = "MainWin";
            this.Text = "Kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Solution;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_DeleteOne;
        private System.Windows.Forms.Button button_Subdivide;
        private System.Windows.Forms.Button button_Sqrt;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_Equals;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button__0;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label labelComputation;
    }
}

