using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_SairSemSalvar : Form
    {
        string Texto;
        public Frm_SairSemSalvar(String texto)
        {
            InitializeComponent();
            Texto = texto;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Arquivo de Texto | .txt";
            save.ShowDialog();

            if (string.IsNullOrEmpty(save.FileName) == false)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.UTF8))
                {
                    writer.Write(Texto);
                    writer.Flush();
                }
            }
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
