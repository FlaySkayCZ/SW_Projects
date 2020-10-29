namespace SW_Cviko2
{
    partial class NewAccount
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
            this.button_AddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.numericUpDown_Zustatek = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Kontokorent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Zustatek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Kontokorent)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddClient
            // 
            this.button_AddClient.Location = new System.Drawing.Point(32, 177);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(149, 37);
            this.button_AddClient.TabIndex = 0;
            this.button_AddClient.Text = "Přidat";
            this.button_AddClient.UseVisualStyleBackColor = true;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zůstatek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kontokorent";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(32, 25);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(149, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // numericUpDown_Zustatek
            // 
            this.numericUpDown_Zustatek.Location = new System.Drawing.Point(32, 73);
            this.numericUpDown_Zustatek.Name = "numericUpDown_Zustatek";
            this.numericUpDown_Zustatek.Size = new System.Drawing.Size(149, 20);
            this.numericUpDown_Zustatek.TabIndex = 5;
            // 
            // numericUpDown_Kontokorent
            // 
            this.numericUpDown_Kontokorent.Location = new System.Drawing.Point(32, 126);
            this.numericUpDown_Kontokorent.Name = "numericUpDown_Kontokorent";
            this.numericUpDown_Kontokorent.Size = new System.Drawing.Size(149, 20);
            this.numericUpDown_Kontokorent.TabIndex = 6;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 258);
            this.Controls.Add(this.numericUpDown_Kontokorent);
            this.Controls.Add(this.numericUpDown_Zustatek);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddClient);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Zustatek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Kontokorent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.NumericUpDown numericUpDown_Zustatek;
        private System.Windows.Forms.NumericUpDown numericUpDown_Kontokorent;
    }
}