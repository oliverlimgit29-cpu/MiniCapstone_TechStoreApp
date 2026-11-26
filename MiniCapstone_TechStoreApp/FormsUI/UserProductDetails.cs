using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp
{
    public partial class UserProductDetails : Form
    {
        public UserProductDetails()
        {
            InitializeComponent();
            cbRating.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cbRating.SelectedIndex = 4;
        }
    }
}
