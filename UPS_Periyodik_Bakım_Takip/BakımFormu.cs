using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPS_Periyodik_Bakım_Takip.Formlar;

namespace UPS_Periyodik_Bakım_Takip
{
    public partial class BakımFormu : Form
    {
        public BakımFormu()
        {
            InitializeComponent();
        }

        public string path;
        private void loadPath()
        {
            path = "https://ups-bakim-takip.firebaseio.com/UPSList/"+Data.CurrentUPS;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            loadPath();

            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = path
            };
            IFirebaseClient client = new FirebaseClient(config);

            var set2 = await client.SetAsync(@"/ups"+ Data.Currentups + "/Yıllar/"+Data.CurrentYıl+"/"+Data.CurrentAy+"/", "true");

            var set3 = await client.SetAsync(@"/ups"+ Data.Currentups + "/BakımTarihi/", textBox1.Text);
            var set4 = await client.SetAsync(@"/ups"+ Data.Currentups + "/BirSonrakiBakimTarihi/" , textBox2.Text);
            var set5 = await client.SetAsync(@"/ups"+ Data.Currentups + "/SorumluKişi/", textBox3.Text);
            var set6 = await client.SetAsync(@"/ups"+ Data.Currentups + "/Açıklama/" , textBox4.Text);

            UpsList f1 = new UpsList();
            f1.Show();
            this.Close();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Takvim t = new Takvim();
            t.Show();
            this.Close();
        }

    }
}
