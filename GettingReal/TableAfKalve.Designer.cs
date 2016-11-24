namespace GettingReal
{
    partial class TableAfKalve
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
            this.NyKalv = new System.Windows.Forms.Button();
            this.SeTidligere = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NyKalv
            // 
            this.NyKalv.Location = new System.Drawing.Point(12, 208);
            this.NyKalv.Name = "NyKalv";
            this.NyKalv.Size = new System.Drawing.Size(87, 32);
            this.NyKalv.TabIndex = 7;
            this.NyKalv.Text = "Ny kalv";
            this.NyKalv.UseVisualStyleBackColor = true;
            // 
            // SeTidligere
            // 
            this.SeTidligere.Location = new System.Drawing.Point(185, 208);
            this.SeTidligere.Name = "SeTidligere";
            this.SeTidligere.Size = new System.Drawing.Size(87, 32);
            this.SeTidligere.TabIndex = 6;
            this.SeTidligere.Text = "Se tidligere";
            this.SeTidligere.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.28571F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.71429F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.Table.Location = new System.Drawing.Point(12, 70);
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
            this.Table.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(49, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table af kalve";
            // 
            // TableAfKalve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NyKalv);
            this.Controls.Add(this.SeTidligere);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label2);
            this.Name = "TableAfKalve";
            this.Text = "TableAfKalve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NyKalv;
        private System.Windows.Forms.Button SeTidligere;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label label2;
    }
}