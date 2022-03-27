using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shebeke
{
    public partial class sgnup : Form
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public sgnup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sign up
            await firebaseHelper.AddPerson(textBox1.Text, textBox2.Text);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            //await DisplayAlert("Success", "Uğurla daxil edildi", "OK");
        }
    }
}
