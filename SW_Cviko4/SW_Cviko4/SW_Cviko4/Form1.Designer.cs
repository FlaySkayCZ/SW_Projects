namespace SW_Cviko4
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
            this.dataGridView_Zakaznici = new System.Windows.Forms.DataGridView();
            this.dataGridView_Sklad = new System.Windows.Forms.DataGridView();
            this.dataGridView_Vypujceno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Vypujcit = new System.Windows.Forms.Button();
            this.button_Vratit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zakaznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vypujceno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Zakaznici
            // 
            this.dataGridView_Zakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Zakaznici.Location = new System.Drawing.Point(15, 43);
            this.dataGridView_Zakaznici.Name = "dataGridView_Zakaznici";
            this.dataGridView_Zakaznici.Size = new System.Drawing.Size(530, 335);
            this.dataGridView_Zakaznici.TabIndex = 0;
            // 
            // dataGridView_Sklad
            // 
            this.dataGridView_Sklad.AllowDrop = true;
            this.dataGridView_Sklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sklad.Location = new System.Drawing.Point(766, 43);
            this.dataGridView_Sklad.Name = "dataGridView_Sklad";
            this.dataGridView_Sklad.Size = new System.Drawing.Size(530, 335);
            this.dataGridView_Sklad.TabIndex = 1;
            // 
            // dataGridView_Vypujceno
            // 
            this.dataGridView_Vypujceno.AllowDrop = true;
            this.dataGridView_Vypujceno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Vypujceno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Vypujceno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vypujceno.Location = new System.Drawing.Point(15, 409);
            this.dataGridView_Vypujceno.Name = "dataGridView_Vypujceno";
            this.dataGridView_Vypujceno.Size = new System.Drawing.Size(1284, 195);
            this.dataGridView_Vypujceno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zakaznici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Výpůjčky";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sklad";
            // 
            // button_Vypujcit
            // 
            this.button_Vypujcit.Location = new System.Drawing.Point(622, 38);
            this.button_Vypujcit.Name = "button_Vypujcit";
            this.button_Vypujcit.Size = new System.Drawing.Size(75, 167);
            this.button_Vypujcit.TabIndex = 6;
            this.button_Vypujcit.Text = "Vypůjčit";
            this.button_Vypujcit.UseVisualStyleBackColor = true;
            this.button_Vypujcit.Click += new System.EventHandler(this.buttonx_Vypujcit);
            // 
            // button_Vratit
            // 
            this.button_Vratit.Location = new System.Drawing.Point(622, 211);
            this.button_Vratit.Name = "button_Vratit";
            this.button_Vratit.Size = new System.Drawing.Size(75, 167);
            this.button_Vratit.TabIndex = 7;
            this.button_Vratit.Text = "Vrátit";
            this.button_Vratit.UseVisualStyleBackColor = true;
            this.button_Vratit.Click += new System.EventHandler(this.buttonx_Vratit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 616);
            this.Controls.Add(this.button_Vratit);
            this.Controls.Add(this.button_Vypujcit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Vypujceno);
            this.Controls.Add(this.dataGridView_Sklad);
            this.Controls.Add(this.dataGridView_Zakaznici);
            this.Name = "Form1";
            this.Text = "Videopůjčovna";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zakaznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vypujceno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Zakaznici;
        private System.Windows.Forms.DataGridView dataGridView_Sklad;
        private System.Windows.Forms.DataGridView dataGridView_Vypujceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Vypujcit;
        private System.Windows.Forms.Button button_Vratit;
    }
}

