namespace GettingReal
{
    partial class Kalve
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NyKalv = new System.Windows.Forms.Button();
            this.SeTidligere = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CHR = new System.Windows.Forms.TextBox();
            this.BirthWeight = new System.Windows.Forms.NumericUpDown();
            this.BirtheDate = new System.Windows.Forms.DateTimePicker();
            this.Registere = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NavnText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NyKalv);
            this.tabPage1.Controls.Add(this.SeTidligere);
            this.tabPage1.Controls.Add(this.Table);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table af kalve";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NyKalv
            // 
            this.NyKalv.Location = new System.Drawing.Point(8, 195);
            this.NyKalv.Name = "NyKalv";
            this.NyKalv.Size = new System.Drawing.Size(87, 32);
            this.NyKalv.TabIndex = 11;
            this.NyKalv.Text = "Ny kalv";
            this.NyKalv.UseVisualStyleBackColor = true;
            // 
            // SeTidligere
            // 
            this.SeTidligere.Location = new System.Drawing.Point(181, 195);
            this.SeTidligere.Name = "SeTidligere";
            this.SeTidligere.Size = new System.Drawing.Size(87, 32);
            this.SeTidligere.TabIndex = 10;
            this.SeTidligere.Text = "Se tidligere";
            this.SeTidligere.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.28571F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.71429F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.Table.Location = new System.Drawing.Point(8, 57);
            this.Table.Name = "Table";
            this.Table.RowCount = 5;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.Size = new System.Drawing.Size(260, 116);
            this.Table.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(45, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Table af kalve";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CHR);
            this.tabPage2.Controls.Add(this.BirthWeight);
            this.tabPage2.Controls.Add(this.BirtheDate);
            this.tabPage2.Controls.Add(this.Registere);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.NavnText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ny kalv";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CHR
            // 
            this.CHR.Location = new System.Drawing.Point(95, 90);
            this.CHR.Name = "CHR";
            this.CHR.Size = new System.Drawing.Size(156, 20);
            this.CHR.TabIndex = 35;
            // 
            // BirthWeight
            // 
            this.BirthWeight.Location = new System.Drawing.Point(95, 138);
            this.BirthWeight.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BirthWeight.Name = "BirthWeight";
            this.BirthWeight.Size = new System.Drawing.Size(156, 20);
            this.BirthWeight.TabIndex = 34;
            // 
            // BirtheDate
            // 
            this.BirtheDate.Location = new System.Drawing.Point(95, 116);
            this.BirtheDate.Name = "BirtheDate";
            this.BirtheDate.Size = new System.Drawing.Size(156, 20);
            this.BirtheDate.TabIndex = 33;
            // 
            // Registere
            // 
            this.Registere.Location = new System.Drawing.Point(106, 168);
            this.Registere.Name = "Registere";
            this.Registere.Size = new System.Drawing.Size(122, 45);
            this.Registere.TabIndex = 32;
            this.Registere.Text = "Registere";
            this.Registere.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fødselsvægt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fødselsdato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "CHR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Navn";
            // 
            // NavnText
            // 
            this.NavnText.Location = new System.Drawing.Point(95, 64);
            this.NavnText.Name = "NavnText";
            this.NavnText.Size = new System.Drawing.Size(156, 20);
            this.NavnText.TabIndex = 27;
            this.NavnText.TextChanged += new System.EventHandler(this.NavnText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(100, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ny kalv";
            // 
            // Kalve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kalve";
            this.Text = "Kalve";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button NyKalv;
        private System.Windows.Forms.Button SeTidligere;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox CHR;
        private System.Windows.Forms.NumericUpDown BirthWeight;
        private System.Windows.Forms.DateTimePicker BirtheDate;
        private System.Windows.Forms.Button Registere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NavnText;
        private System.Windows.Forms.Label label6;
    }
}