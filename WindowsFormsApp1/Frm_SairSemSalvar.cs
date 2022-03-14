using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_SairSemSalvar : Form
    {
        public Frm_SairSemSalvar()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
        private void Btn_NotSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lbl_Confirmação_Click(object sender, EventArgs e)
        {

        }
    }
}
