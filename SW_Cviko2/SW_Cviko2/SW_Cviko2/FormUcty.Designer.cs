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
            // FormUcty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.button_Transaction);
            this.Controls.Add(this.label_Ucty);
            this.Controls.Add(this.dataGridView_Ucty);
            this.Name = "FormUcty";
            this.Text = "Ucet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ucty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Ucty;
        private System.Windows.Forms.Label label_Ucty;
        private System.Windows.Forms.Button button_Transaction;
    }
}

