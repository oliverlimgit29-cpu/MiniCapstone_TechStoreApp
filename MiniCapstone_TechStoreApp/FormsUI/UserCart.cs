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
    public partial class UserCart : Form
    {
        public UserCart()
        {
            InitializeComponent();
            cbPaymentMethod.Items.Add("Cash on Delivery");
            cbPaymentMethod.Items.Add("Credit Card");
        }
    }
}
