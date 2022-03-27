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
    public partial class logpass : Form
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public logpass()
        {
            InitializeComponent();
        }

        private void logpass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //sign in
            var person = await firebaseHelper.GetPerson(textBox1.Text.ToString(), textBox2.Text.ToString());
            if (person != null)
            {

                // Navigation.PushAsync(new hesablama());
                mmenu m = new mmenu();
                m.Show();

            }
          //  else
            //{
            //    await DisplayAlert("Xəta", "Belə bir şəxs yoxdur", "OK");
            //}
        }
    }
}
