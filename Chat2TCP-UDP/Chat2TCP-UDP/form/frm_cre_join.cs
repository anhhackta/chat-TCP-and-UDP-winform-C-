using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat2TCP_UDP.form
{
    public partial class frm_cre_join : Form
    {
        private Form_createroom frmCreateroom;
        public frm_cre_join()
        {
            InitializeComponent();
            frmCreateroom = new Form_Createroom();
        }

        private void hoangbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
