using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Model;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new Context();
            var a = new birthday();
            a.name = textBox1.Text ;
            a.family =textBox2.Text ;
            a.birth = Convert.ToDateTime(textBox3.Text);
            db.birthdaydbset.Add(a);
            db.SaveChanges();

            MessageBox.Show("ثبت شد");
        }
    }
}
