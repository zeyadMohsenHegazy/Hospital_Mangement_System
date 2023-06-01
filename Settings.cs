using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            HospitalEntities hospitalEntities = new HospitalEntities();
            string name = UserNameTxt.Text;
            string pass = PasswordTxt.Text;
            var selectedItems = RoleList.SelectedItems;
            string Role ="";
            foreach (var selectedItem in selectedItems)
            {
                 Role = selectedItem.ToString();
            }

            hospitalEntities.Users.Add(new User() {UserName=name,Password=pass,role=Role});
            hospitalEntities.SaveChanges();

        }
    }
}
