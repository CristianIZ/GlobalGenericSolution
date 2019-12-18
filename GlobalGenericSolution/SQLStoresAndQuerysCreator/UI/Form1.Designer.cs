namespace SQLStoresAndQuerysCreator
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.lstCampo = new System.Windows.Forms.ListBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProcedureType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCampo
            // 
            this.lstCampo.FormattingEnabled = true;
            this.lstCampo.ItemHeight = 20;
            this.lstCampo.Location = new System.Drawing.Point(570, 60);
            this.lstCampo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCampo.Name = "lstCampo";
            this.lstCampo.Size = new System.Drawing.Size(367, 284);
            this.lstCampo.TabIndex = 0;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(13, 96);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTable.Size = new System.Drawing.Size(541, 212);
            this.txtTable.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(442, 318);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(112, 35);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResult.Location = new System.Drawing.Point(17, 363);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(920, 379);
            this.txtResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campo - Tipo de dato";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(18, 60);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(148, 26);
            this.txtTableName.TabIndex = 5;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(212, 60);
            this.txtDbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(148, 26);
            this.txtDbName.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(411, 60);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(148, 26);
            this.txtAutor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataBase Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autor";
            // 
            // cmbProcedureType
            // 
            this.cmbProcedureType.FormattingEnabled = true;
            this.cmbProcedureType.Location = new System.Drawing.Point(105, 321);
            this.cmbProcedureType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProcedureType.Name = "cmbProcedureType";
            this.cmbProcedureType.Size = new System.Drawing.Size(326, 28);
            this.cmbProcedureType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Procedure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 756);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbProcedureType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lstCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCampo;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProcedureType;
        private System.Windows.Forms.Label label5;
    }
}

