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

namespace UPS_Periyodik_Bakım_Takip
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }
        private string str, st2;
        private async void UserList_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = "https://ups-bakim-takip.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("Users");

            Dictionary<string, User> userList = data.ResultAs<Dictionary<string, User>>();

            foreach (var user in userList)
            {
                userDataGridView.Rows.Add(user.Value.KullanıcıAdı, user.Value.Yetki);
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa asf = new AnaSayfa();
            asf.Show();
            this.Close();
        }


        private async void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = "https://ups-bakim-takip.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);

            str = userDataGridView.CurrentRow.Cells[0].Value.ToString();

            FirebaseResponse res = client.Get(@"Users/" + str + "/Yetki");
            string data = res.ResultAs<string>();

            if (data =="true")
            {
                st2 = "false";
            }
            else
            {
                st2 = "true";
            }

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kişinin Yetkisini Değiştirmek İstiyor Musunuz?", "YETKİ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                var set2 = await client.SetAsync(@"Users/"+str+"/Yetki/", st2);

                userDataGridView.Rows.Clear();
                UserList_Load(sender, e);

                MessageBox.Show("Yetki Değiştirildi!!!","BİLGİLENDİRME", MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
            else
            {
                MessageBox.Show("Yetki Değiştirilmedi!!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
