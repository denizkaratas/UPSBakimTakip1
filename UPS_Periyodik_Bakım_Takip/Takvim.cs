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

namespace UPS_Periyodik_Bakım_Takip.Formlar
{
    public partial class Takvim : Form
    {
        public Takvim()
        {
            InitializeComponent();
        }
        public string path;


        private void loadPath()
        {
                path = "https://ups-bakim-takip.firebaseio.com/UPSList/"+Data.CurrentUPS+"/ups" + Data.Currentups;
        }

        private void ayDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            IFirebaseConfig config2 = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = "https://ups-bakim-takip.firebaseio.com/"
            };
            IFirebaseClient client2 = new FirebaseClient(config2);


            FirebaseResponse res = client2.Get(@"Users/" + Data.CurrentUser + "/Yetki");
            string data = res.ResultAs<string>();
            if (data == "true")
            {
                BakımFormu bf = new BakımFormu();
                bf.Show();
                Data.CurrentAy = ayDataGridView.Columns[ayDataGridView.CurrentCell.ColumnIndex].Name.ToString();
                Data.CurrentYıl = ayDataGridView.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            
        }

        private void buttonYıl_Click(object sender, EventArgs e)
        {

            loadPath();

            Date dt = new Date();
            dt.Yıl = textBoxYıl.Text;
            dt.Ocak = "false";
            dt.Şubat = "false";
            dt.Mart = "false";
            dt.Nisan = "false";
            dt.Mayıs = "false";
            dt.Haziran = "false";
            dt.Temmuz = "false";
            dt.Ağustos = "false";
            dt.Eylül = "false";
            dt.Ekim = "false";
            dt.Kasım = "false";
            dt.Aralık = "false";

            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = path
            };
            IFirebaseClient client = new FirebaseClient(config);

            var set = client.Set(@"/Yıllar/"+dt.Yıl, dt);

            ayDataGridView.Rows.Clear();
            Takvim_Load(sender, e);
        }

        private void Takvim_Load(object sender, EventArgs e)
        {
            loadPath();
            loadData();

        }
        
        public async void loadData()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = path
            };
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("Yıllar");

            Dictionary<string, Date> takvim = data.ResultAs<Dictionary<string, Date>>();

            foreach (var tk in takvim)
            {
                ayDataGridView.Rows.Add(tk.Value.Yıl, tk.Value.Ocak, tk.Value.Şubat, tk.Value.Mart, tk.Value.Nisan, tk.Value.Mayıs, tk.Value.Haziran, tk.Value.Temmuz, tk.Value.Ağustos, tk.Value.Eylül, tk.Value.Ekim, tk.Value.Kasım, tk.Value.Aralık);
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            UpsList ul = new UpsList();
            ul.Show();
            this.Close();
        }


    }
}
