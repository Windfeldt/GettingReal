using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingReal
{
    public partial class Kalve : Form
    {
        public string tempName;
        public int tempCHR;
        public DateTime tempBirtheDate;
        public int tempBirhtWeight;
        public Kalve()
        {
            InitializeComponent();
        }

        public void NavnText_TextChanged(object sender, EventArgs e)
        {
            TextBox NavnText = (TextBox)sender;
            tempName = NavnText.Text;
        }

        private void Registere_Click(object sender, EventArgs e)
        {
            //Cow kalv = new Cow();
            //kalv.name = tempName;
            //kalv.CHR = tempCHR;
            //kalv.birthdate = tempBirtheDate;
            //kalv.birthweight = tempBirhtWeight;
        }



        private void BirtheDate_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker birtheDate = (DateTimePicker)sender;
            tempBirtheDate = birtheDate.Value.Date;
        }

        private void BirthWeight_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown birthWeight = (NumericUpDown)sender;
            tempBirhtWeight = Convert.ToInt32(birthWeight.Value);
        }

        private void CHR_TextChanged(object sender, EventArgs e)
        {
            TextBox CHR = (TextBox)sender;
            tempCHR = Convert.ToInt32(CHR);
        }
    }
}
