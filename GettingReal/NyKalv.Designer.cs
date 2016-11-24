namespace GettingReal
{
    partial class NyKalv
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
            this.Registere = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NavnText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirtheDate = new System.Windows.Forms.DateTimePicker();
            this.BirthWeight = new System.Windows.Forms.NumericUpDown();
            this.CHR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BirthWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Registere
            // 
            this.Registere.Location = new System.Drawing.Point(89, 171);
            this.Registere.Name = "Registere";
            this.Registere.Size = new System.Drawing.Size(122, 45);
            this.Registere.TabIndex = 22;
            this.Registere.Text = "Registere";
            this.Registere.UseVisualStyleBackColor = true;
            this.Registere.Click += new System.EventHandler(this.Registere_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fødselsvægt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fødselsdato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CHR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Navn";
            // 
            // NavnText
            // 
            this.NavnText.Location = new System.Drawing.Point(78, 67);
            this.NavnText.Name = "NavnText";
            this.NavnText.Size = new System.Drawing.Size(156, 20);
            this.NavnText.TabIndex = 14;
            this.NavnText.TextChanged += new System.EventHandler(this.NavnText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(83, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ny kalv";
            // 
            // BirtheDate
            // 
            this.BirtheDate.Location = new System.Drawing.Point(78, 119);
            this.BirtheDate.Name = "BirtheDate";
            this.BirtheDate.Size = new System.Drawing.Size(156, 20);
            this.BirtheDate.TabIndex = 23;
            this.BirtheDate.ValueChanged += new System.EventHandler(this.BirtheDate_ValueChanged);
            // 
            // BirthWeight
            // 
            this.BirthWeight.Location = new System.Drawing.Point(78, 141);
            this.BirthWeight.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BirthWeight.Name = "BirthWeight";
            this.BirthWeight.Size = new System.Drawing.Size(156, 20);
            this.BirthWeight.TabIndex = 24;
            this.BirthWeight.ValueChanged += new System.EventHandler(this.BirthWeight_ValueChanged);
            // 
            // CHR
            // 
            this.CHR.Location = new System.Drawing.Point(78, 93);
            this.CHR.Name = "CHR";
            this.CHR.Size = new System.Drawing.Size(156, 20);
            this.CHR.TabIndex = 25;
            this.CHR.TextChanged += new System.EventHandler(this.CHR_TextChanged);
            // 
            // NyKalv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CHR);
            this.Controls.Add(this.BirthWeight);
            this.Controls.Add(this.BirtheDate);
            this.Controls.Add(this.Registere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NavnText);
            this.Controls.Add(this.label2);
            this.Name = "NyKalv";
            this.Text = "NyKalv";
            ((System.ComponentModel.ISupportInitialize)(this.BirthWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NavnText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BirtheDate;
        private System.Windows.Forms.NumericUpDown BirthWeight;
        private System.Windows.Forms.TextBox CHR;
    }
}