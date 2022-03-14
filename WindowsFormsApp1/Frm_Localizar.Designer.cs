
namespace WindowsFormsApp1
{
    partial class Frm_Localizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Localizar = new System.Windows.Forms.TextBox();
            this.Cb_Maiusculo_Minusculo = new System.Windows.Forms.CheckBox();
            this.Cb_AoRedor = new System.Windows.Forms.CheckBox();
            this.Rb_Abaixo = new System.Windows.Forms.RadioButton();
            this.Rb_Acima = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Localizar = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localizar:";
            // 
            // Tb_Localizar
            // 
            this.Tb_Localizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Tb_Localizar.ForeColor = System.Drawing.Color.White;
            this.Tb_Localizar.Location = new System.Drawing.Point(70, 22);
            this.Tb_Localizar.Name = "Tb_Localizar";
            this.Tb_Localizar.Size = new System.Drawing.Size(281, 20);
            this.Tb_Localizar.TabIndex = 1;
            // 
            // Cb_Maiusculo_Minusculo
            // 
            this.Cb_Maiusculo_Minusculo.AutoSize = true;
            this.Cb_Maiusculo_Minusculo.ForeColor = System.Drawing.Color.White;
            this.Cb_Maiusculo_Minusculo.Location = new System.Drawing.Point(14, 53);
            this.Cb_Maiusculo_Minusculo.Name = "Cb_Maiusculo_Minusculo";
            this.Cb_Maiusculo_Minusculo.Size = new System.Drawing.Size(202, 17);
            this.Cb_Maiusculo_Minusculo.TabIndex = 2;
            this.Cb_Maiusculo_Minusculo.Text = "Diferenciar maiúsculas de minúsculas";
            this.Cb_Maiusculo_Minusculo.UseVisualStyleBackColor = true;
            // 
            // Cb_AoRedor
            // 
            this.Cb_AoRedor.AutoSize = true;
            this.Cb_AoRedor.ForeColor = System.Drawing.Color.White;
            this.Cb_AoRedor.Location = new System.Drawing.Point(14, 77);
            this.Cb_AoRedor.Name = "Cb_AoRedor";
            this.Cb_AoRedor.Size = new System.Drawing.Size(66, 17);
            this.Cb_AoRedor.TabIndex = 3;
            this.Cb_AoRedor.Text = "Ao redor";
            this.Cb_AoRedor.UseVisualStyleBackColor = true;
            // 
            // Rb_Abaixo
            // 
            this.Rb_Abaixo.AutoSize = true;
            this.Rb_Abaixo.ForeColor = System.Drawing.Color.White;
            this.Rb_Abaixo.Location = new System.Drawing.Point(66, 16);
            this.Rb_Abaixo.Name = "Rb_Abaixo";
            this.Rb_Abaixo.Size = new System.Drawing.Size(57, 17);
            this.Rb_Abaixo.TabIndex = 4;
            this.Rb_Abaixo.TabStop = true;
            this.Rb_Abaixo.Text = "Abaixo";
            this.Rb_Abaixo.UseVisualStyleBackColor = true;
            // 
            // Rb_Acima
            // 
            this.Rb_Acima.AutoSize = true;
            this.Rb_Acima.ForeColor = System.Drawing.Color.White;
            this.Rb_Acima.Location = new System.Drawing.Point(6, 16);
            this.Rb_Acima.Name = "Rb_Acima";
            this.Rb_Acima.Size = new System.Drawing.Size(54, 17);
            this.Rb_Acima.TabIndex = 5;
            this.Rb_Acima.TabStop = true;
            this.Rb_Acima.Text = "Acima";
            this.Rb_Acima.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Acima);
            this.groupBox1.Controls.Add(this.Rb_Abaixo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(222, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 39);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direção";
            // 
            // Btn_Localizar
            // 
            this.Btn_Localizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Localizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Localizar.Location = new System.Drawing.Point(368, 22);
            this.Btn_Localizar.Name = "Btn_Localizar";
            this.Btn_Localizar.Size = new System.Drawing.Size(95, 23);
            this.Btn_Localizar.TabIndex = 7;
            this.Btn_Localizar.Text = "Localizar";
            this.Btn_Localizar.UseVisualStyleBackColor = true;
            this.Btn_Localizar.Click += new System.EventHandler(this.Btn_Localizar_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Location = new System.Drawing.Point(368, 53);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(95, 23);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            
            // 
            // Frm_Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(482, 122);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Localizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cb_AoRedor);
            this.Controls.Add(this.Cb_Maiusculo_Minusculo);
            this.Controls.Add(this.Tb_Localizar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Localizar";
            this.Text = "Localizar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Localizar;
        private System.Windows.Forms.CheckBox Cb_Maiusculo_Minusculo;
        private System.Windows.Forms.CheckBox Cb_AoRedor;
        private System.Windows.Forms.RadioButton Rb_Abaixo;
        private System.Windows.Forms.RadioButton Rb_Acima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Localizar;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}