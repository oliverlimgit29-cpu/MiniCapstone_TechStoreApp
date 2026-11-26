using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniCapstone_TechStoreApp.DatabaseMongoDB;

namespace MiniCapstone_TechStoreApp.FormsUI
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        public AdminDashboardForm(string username, string password, bool isAdmin, MongoDBConnector db)
        {
            InitializeComponent();
            //OpenChildForm(new AdminDashboardContent());
            OpenChildForm(new AdminInventoryContent(db));
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            // Close previous child form
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;

            // Configure child form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.Manual;

            // Add to content panel
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);

            childForm.Show();
        }
    }
}
