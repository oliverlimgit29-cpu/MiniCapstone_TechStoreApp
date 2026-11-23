using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp.FormsUI
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        public AdminDashboardForm(string username, string password, bool isAdmin)
        {
            InitializeComponent();
        }

        private void btn_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}
