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
using UPS_Periyodik_Bakım_Takip.Formlar;

namespace UPS_Periyodik_Bakım_Takip
{
    public partial class UpsList : Form
    {
        public UpsList()
        {
            InitializeComponent();
        }

        
        private async void Form1_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret= "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath= "https://ups-bakim-takip.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("UPSList/"+Data.CurrentUPS);

            Dictionary<string, Ups> upsList = data.ResultAs<Dictionary<string, Ups>>();

            foreach( var ups in upsList)
            {
                ups1DataGridView.Rows.Add(ups.Value.SıraNo, ups.Value.BulunduğuYerleşke, ups.Value.BulunduğuYerBölüm, ups.Value.UpsMarkaModel, ups.Value.Güç, ups.Value.SeriNo, ups.Value.BakımTarihi, ups.Value.BirSonrakiBakimTarihi, ups.Value.SorumluKişi, ups.Value.Açıklama);
            }
        }

        private void ups1DataGridView_DoubleClick(object sender, EventArgs e)
        {
            Data.Currentups = ups1DataGridView.CurrentRow.Cells[0].Value.ToString();
            Takvim tk = new Takvim();
            tk.Show();
            this.Close();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Close();
        }
    }
}
