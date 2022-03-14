
namespace WindowsFormsApp1
{
    partial class Frm_SairSemSalvar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbl_Confirmação;
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_NotSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            lbl_Confirmação = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Confirmação
            // 
            lbl_Confirmação.AutoSize = true;
            lbl_Confirmação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbl_Confirmação.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Confirmação.ForeColor = System.Drawing.Color.Black;
            lbl_Confirmação.Location = new System.Drawing.Point(12, 22);
            lbl_Confirmação.Name = "lbl_Confirmação";
            lbl_Confirmação.Size = new System.Drawing.Size(358, 25);
            lbl_Confirmação.TabIndex = 3;
            lbl_Confirmação.Text = "Deseja sair sem salvar as alterações?";
            lbl_Confirmação.Click += new System.EventHandler(this.lbl_Confirmação_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salvar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.Btn_Salvar.FlatAppearance.BorderSize = 2;
            this.Btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salvar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salvar.Location = new System.Drawing.Point(18, 15);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(91, 27);
            this.Btn_Salvar.TabIndex = 0;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.Btn_Cancel.FlatAppearance.BorderSize = 2;
            this.Btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cancel.Location = new System.Drawing.Point(272, 15);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(99, 27);
            this.Btn_Cancel.TabIndex = 1;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_NotSave
            // 
            this.Btn_NotSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NotSave.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Btn_NotSave.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.Btn_NotSave.FlatAppearance.BorderSize = 2;
            this.Btn_NotSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_NotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NotSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NotSave.ForeColor = System.Drawing.Color.Black;
            this.Btn_NotSave.Location = new System.Drawing.Point(130, 15);
            this.Btn_NotSave.Name = "Btn_NotSave";
            this.Btn_NotSave.Size = new System.Drawing.Size(112, 27);
            this.Btn_NotSave.TabIndex = 2;
            this.Btn_NotSave.Text = "Não Salvar";
            this.Btn_NotSave.UseVisualStyleBackColor = true;
            this.Btn_NotSave.Click += new System.EventHandler(this.Btn_NotSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_NotSave);
            this.panel1.Controls.Add(this.Btn_Cancel);
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Location = new System.Drawing.Point(-2, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 65);
            this.panel1.TabIndex = 4;
            // 
            // Frm_SairSemSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.CancelButton = this.Btn_NotSave;
            this.ClientSize = new System.Drawing.Size(410, 127);
            this.Controls.Add(this.panel1);
            this.Controls.Add(lbl_Confirmação);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_SairSemSalvar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloco de notas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_NotSave;
        private System.Windows.Forms.Panel panel1;
    }
}