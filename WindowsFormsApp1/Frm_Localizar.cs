using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Localizar : Form
    {

        string Texto;
        public string textoDigitado;
        public Frm_Localizar(String texto)
        {
            InitializeComponent();

            Texto = texto;
            
        }

        
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Btn_Localizar_Click(object sender1, EventArgs e1)
        {
            if (Texto.Contains(Tb_Localizar.Text))
            {
                DialogResult = DialogResult.Yes;
                textoDigitado = Tb_Localizar.Text;
                this.Close();
            }
            else
            {
                 MessageBox.Show("A palavra " + Tb_Localizar.Text + " não foi encontrada", "Bloco de notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
