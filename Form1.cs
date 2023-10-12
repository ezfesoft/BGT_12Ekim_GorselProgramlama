using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_gorsel_12Ekim_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Parlak ismini verdiğimiz butona tıklandığında aşağıdaki komutlar çalışır.

        private void parlak_Click(object sender, EventArgs e)
        {
            //Form1 nesnesinin özellikleri değiştirdik.
            this.BackColor=Color.Aqua;
            this.Text = "Merhaba";

            //label1 nesnesinin özelliklerini değiştirdik.
            label1.Text = "Aydınlık Mod Aktif";
            label1.ForeColor = Color.Black;

            //button1(parlak ismi ile değiştirmiştik) 
            //  nesnesinin özelliklerini değiştirdik.
            parlak.Text = "Aktif";
            parlak.ForeColor = Color.Black;
            parlak.BackColor = Color.White;

            koyu.Text = "Pasif";
            koyu.ForeColor = Color.Black;
            koyu.BackColor = Color.White;
            koyu.Visible = true;
            parlak.Visible = false;
        }

        private void koyu_Click(object sender, EventArgs e)
        {

            //Form1 nesnesinin özellikleri değiştirdik.
            this.BackColor = Color.Silver;
            this.Text = "Merhaba";

            //label1 nesnesinin özelliklerini değiştirdik.
            label1.Text = "Karanlık Mod Aktif";
            label1.ForeColor = Color.Black;

            //button1(parlak ismi ile değiştirmiştik) 
            //  nesnesinin özelliklerini değiştirdik.
            parlak.Text = "Pasif";
            parlak.ForeColor = Color.White;
            parlak.BackColor = Color.Black;
            koyu.Text = "Aktif";
            koyu.ForeColor = Color.White;
            koyu.BackColor = Color.Black;
            koyu.Visible = false;
            parlak.Visible = true;
        }
    }

}
