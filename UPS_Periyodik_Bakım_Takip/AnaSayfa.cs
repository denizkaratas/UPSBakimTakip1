using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPS_Periyodik_Bakım_Takip
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UserList ul = new UserList();
            ul.Show();
            this.Close();
        }

        private async void AnaSayfa_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = "https://ups-bakim-takip.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("UPSList");

            Dictionary<string, Ups> upsList = data.ResultAs<Dictionary<string, Ups>>();

            foreach (var ups in upsList)
            {
                dataGridView1.Rows.Add(ups.Key);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Data.CurrentUPS = str;

            UpsList f1 = new UpsList();
            f1.Show();
            this.Close();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
