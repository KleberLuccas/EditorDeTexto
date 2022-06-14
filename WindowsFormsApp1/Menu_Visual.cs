using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Tela : Form
    {
        public Frm_Tela()
        {
            InitializeComponent();

            Tb_Txt.Dock = DockStyle.Fill;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tb_Txt.Text == "")
            {
                
            }
            else {
                Frm_SairSemSalvar S = new Frm_SairSemSalvar("");
                S.ShowDialog();

                if (S.DialogResult == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Thread.Sleep(1500);
                    Tb_Txt.Text = "";
                    this.Cursor = Cursors.Default;
                }
                if (S.DialogResult == DialogResult.No)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Thread.Sleep(500);
                    Tb_Txt.Text = "";
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tela T = new Frm_Tela(); ;
            T.Show();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                Tb_Txt.Font = FDb.Font;
            }
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                Tb_Txt.ForeColor = CDb.Color;
            }
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Localizar L = new Frm_Localizar(Tb_Txt.Text);
            L.Show();
            //string result = ;
            if (L.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Tb_Txt.Text == "")
            {

            }
            else
            {
                Frm_SairSemSalvar S = new Frm_SairSemSalvar(Tb_Txt.Text);
                S.ShowDialog();
                if (S.DialogResult == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Thread.Sleep(1500);
                    Tb_Txt.Text = "";
                    this.Cursor = Cursors.Default;
                }
                if (S.DialogResult == DialogResult.No)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Thread.Sleep(500);
                    Tb_Txt.Text = "";
                    this.Cursor = Cursors.Default;
                    
                }
            }


            OpenFileDialog txt = new OpenFileDialog();
            txt.InitialDirectory = "C:\\WindowsForms\\Curso\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            txt.Filter = "TXT|*.TXT";
            txt.Title = "Escolha o documento";

            if (txt.ShowDialog() == DialogResult.OK)
            {
                using (var leitor = new StreamReader(txt.FileName))
                {
                    Tb_Txt.Text = leitor.ReadToEnd();
                }
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Arquivo de Texto | .txt";
            save.ShowDialog();

            if (string.IsNullOrEmpty(save.FileName) == false)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.UTF8))
                {
                    writer.Write(Tb_Txt.Text);
                    writer.Flush();
                }
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Arquivo de Texto | .txt";
            save.ShowDialog();

            if (string.IsNullOrEmpty(save.FileName) == false)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.UTF8))
                {
                    writer.Write(Tb_Txt.Text);
                    writer.Flush();
                }
            }
        }
    }
}
