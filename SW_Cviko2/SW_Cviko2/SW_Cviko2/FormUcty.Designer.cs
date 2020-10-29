namespace SW_Cviko2
{
    partial class FormUcty
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
            this.dataGridView_Ucty = new System.Windows.Forms.DataGridView();
            this.label_Ucty = new System.Windows.Forms.Label();
            this.button_Transaction = new System.Windows.Forms.Button();
            this.button_Filter = new System.Windows.Forms.Button();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.button_NewAccount = new System.Windows.Forms.Button();
            this.button_deleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ucty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ucty
            // 
            this.dataGridView_Ucty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ucty.Location = new System.Drawing.Point(15, 90);
            this.dataGridView_Ucty.Name = "dataGridView_Ucty";
            this.dataGridView_Ucty.Size = new System.Drawing.Size(776, 426);
            this.dataGridView_Ucty.TabIndex = 0;
            // 
            // label_Ucty
            // 
            this.label_Ucty.AutoSize = true;
            this.label_Ucty.Location = new System.Drawing.Point(12, 9);
            this.label_Ucty.Name = "label_Ucty";
            this.label_Ucty.Size = new System.Drawing.Size(29, 13);
            this.label_Ucty.TabIndex = 1;
            this.label_Ucty.Text = "Účty";
            // 
            // button_Transaction
            // 
            this.button_Transaction.Location = new System.Drawing.Point(15, 522);
            this.button_Transaction.Name = "button_Transaction";
            this.button_Transaction.Size = new System.Drawing.Size(120, 30);
            this.button_Transaction.TabIndex = 2;
            this.button_Transaction.Text = "Proveď";
            this.button_Transaction.UseVisualStyleBackColor = true;
            this.button_Transaction.Click += new System.EventHandler(this.button_Transaction_Click);
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(713, 61);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 23);
            this.button_Filter.TabIndex = 3;
            this.button_Filter.Text = "Filtruj";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Location = new System.Drawing.Point(512, 63);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(195, 20);
            this.textBox_Filter.TabIndex = 4;
            // 
            // button_NewAccount
            // 
            this.button_NewAccount.Location = new System.Drawing.Point(540, 529);
            this.button_NewAccount.Name = "button_NewAccount";
            this.button_NewAccount.Size = new System.Drawing.Size(121, 23);
            this.button_NewAccount.TabIndex = 5;
            this.button_NewAccount.Text = "Přidat Nový účet";
            this.button_NewAccount.UseVisualStyleBackColor = true;
            this.button_NewAccount.Click += new System.EventHandler(this.button_NewAccount_Click);
            // 
            // button_deleteAccount
            // 
            this.button_deleteAccount.Location = new System.Drawing.Point(667, 529);
            this.button_deleteAccount.Name = "button_deleteAccount";
            this.button_deleteAccount.Size = new System.Drawing.Size(121, 23);
            this.button_deleteAccount.TabIndex = 6;
            this.button_deleteAccount.Text = "Smazat účet";
            this.button_deleteAccount.UseVisualStyleBackColor = true;
            this.button_deleteAccount.Click += new System.EventHandler(this.button_deleteAccount_Click);
            // 
            // FormUcty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.button_deleteAccount);
            this.Controls.Add(this.button_NewAccount);
            this.Controls.Add(this.textBox_Filter);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.button_Transaction);
            this.Controls.Add(this.label_Ucty);
            this.Controls.Add(this.dataGridView_Ucty);
            this.Name = "FormUcty";
            this.Text = "Ucet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUcty_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ucty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Ucty;
        private System.Windows.Forms.Label label_Ucty;
        private System.Windows.Forms.Button button_Transaction;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.TextBox textBox_Filter;
        private System.Windows.Forms.Button button_NewAccount;
        private System.Windows.Forms.Button button_deleteAccount;
    }
}

