namespace pjt_ordenador_numeros
{
    partial class frm_ordenaNumero
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ordenaNumero));
            this.tbc_ambiente = new System.Windows.Forms.TabControl();
            this.tbp_gravar = new System.Windows.Forms.TabPage();
            this.btn_grava = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.ltb_listaNumeros = new System.Windows.Forms.ListBox();
            this.btn_adiciona = new System.Windows.Forms.Button();
            this.txt_numeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_gravarNumeros = new System.Windows.Forms.Label();
            this.tbp_ler = new System.Windows.Forms.TabPage();
            this.txt_lista = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd_LeArquivo = new System.Windows.Forms.OpenFileDialog();
            this.tbc_ambiente.SuspendLayout();
            this.tbp_gravar.SuspendLayout();
            this.tbp_ler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_ambiente
            // 
            this.tbc_ambiente.Controls.Add(this.tbp_gravar);
            this.tbc_ambiente.Controls.Add(this.tbp_ler);
            this.tbc_ambiente.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbc_ambiente.Location = new System.Drawing.Point(12, 12);
            this.tbc_ambiente.Name = "tbc_ambiente";
            this.tbc_ambiente.SelectedIndex = 0;
            this.tbc_ambiente.Size = new System.Drawing.Size(349, 430);
            this.tbc_ambiente.TabIndex = 0;
            // 
            // tbp_gravar
            // 
            this.tbp_gravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(160)))));
            this.tbp_gravar.Controls.Add(this.btn_grava);
            this.tbp_gravar.Controls.Add(this.btn_remove);
            this.tbp_gravar.Controls.Add(this.ltb_listaNumeros);
            this.tbp_gravar.Controls.Add(this.btn_adiciona);
            this.tbp_gravar.Controls.Add(this.txt_numeros);
            this.tbp_gravar.Controls.Add(this.label1);
            this.tbp_gravar.Controls.Add(this.lbl_gravarNumeros);
            this.tbp_gravar.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbp_gravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.tbp_gravar.Location = new System.Drawing.Point(4, 38);
            this.tbp_gravar.Name = "tbp_gravar";
            this.tbp_gravar.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_gravar.Size = new System.Drawing.Size(341, 388);
            this.tbp_gravar.TabIndex = 0;
            this.tbp_gravar.Text = "Gravar";
            // 
            // btn_grava
            // 
            this.btn_grava.ForeColor = System.Drawing.Color.Black;
            this.btn_grava.Location = new System.Drawing.Point(165, 344);
            this.btn_grava.Name = "btn_grava";
            this.btn_grava.Size = new System.Drawing.Size(127, 31);
            this.btn_grava.TabIndex = 6;
            this.btn_grava.Text = "Gravar Arquivo";
            this.btn_grava.UseVisualStyleBackColor = true;
            this.btn_grava.Click += new System.EventHandler(this.btn_grava_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(33, 344);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(127, 31);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove Selecionado";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // ltb_listaNumeros
            // 
            this.ltb_listaNumeros.FormattingEnabled = true;
            this.ltb_listaNumeros.ItemHeight = 17;
            this.ltb_listaNumeros.Location = new System.Drawing.Point(33, 147);
            this.ltb_listaNumeros.Name = "ltb_listaNumeros";
            this.ltb_listaNumeros.Size = new System.Drawing.Size(259, 191);
            this.ltb_listaNumeros.TabIndex = 4;
            // 
            // btn_adiciona
            // 
            this.btn_adiciona.ForeColor = System.Drawing.Color.Black;
            this.btn_adiciona.Location = new System.Drawing.Point(252, 94);
            this.btn_adiciona.Name = "btn_adiciona";
            this.btn_adiciona.Size = new System.Drawing.Size(40, 32);
            this.btn_adiciona.TabIndex = 3;
            this.btn_adiciona.Text = "ADD";
            this.btn_adiciona.UseVisualStyleBackColor = true;
            this.btn_adiciona.Click += new System.EventHandler(this.btn_adiciona_Click);
            // 
            // txt_numeros
            // 
            this.txt_numeros.Location = new System.Drawing.Point(140, 98);
            this.txt_numeros.Name = "txt_numeros";
            this.txt_numeros.Size = new System.Drawing.Size(100, 25);
            this.txt_numeros.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite 10 números:";
            // 
            // lbl_gravarNumeros
            // 
            this.lbl_gravarNumeros.AutoSize = true;
            this.lbl_gravarNumeros.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gravarNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(90)))), ((int)(((byte)(220)))));
            this.lbl_gravarNumeros.Location = new System.Drawing.Point(22, 24);
            this.lbl_gravarNumeros.Name = "lbl_gravarNumeros";
            this.lbl_gravarNumeros.Size = new System.Drawing.Size(292, 62);
            this.lbl_gravarNumeros.TabIndex = 0;
            this.lbl_gravarNumeros.Text = "GRAVAR NÚMEROS";
            // 
            // tbp_ler
            // 
            this.tbp_ler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(90)))), ((int)(((byte)(220)))));
            this.tbp_ler.Controls.Add(this.txt_lista);
            this.tbp_ler.Controls.Add(this.btn_atualizar);
            this.tbp_ler.Controls.Add(this.label2);
            this.tbp_ler.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbp_ler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.tbp_ler.Location = new System.Drawing.Point(4, 38);
            this.tbp_ler.Name = "tbp_ler";
            this.tbp_ler.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ler.Size = new System.Drawing.Size(341, 388);
            this.tbp_ler.TabIndex = 1;
            this.tbp_ler.Text = "Ler";
            // 
            // txt_lista
            // 
            this.txt_lista.Location = new System.Drawing.Point(27, 79);
            this.txt_lista.Multiline = true;
            this.txt_lista.Name = "txt_lista";
            this.txt_lista.Size = new System.Drawing.Size(290, 233);
            this.txt_lista.TabIndex = 4;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(27, 328);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(81, 33);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(56, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "LER ARQUIVO";
            // 
            // ofd_LeArquivo
            // 
            this.ofd_LeArquivo.FileName = "openFileDialog1";
            // 
            // frm_ordenaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(372, 453);
            this.Controls.Add(this.tbc_ambiente);
            this.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(90)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ordenaNumero";
            this.Text = "Ordenador de Números";
            this.tbc_ambiente.ResumeLayout(false);
            this.tbp_gravar.ResumeLayout(false);
            this.tbp_gravar.PerformLayout();
            this.tbp_ler.ResumeLayout(false);
            this.tbp_ler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbc_ambiente;
        private TabPage tbp_gravar;
        private Button btn_grava;
        private Button btn_remove;
        private ListBox ltb_listaNumeros;
        private Button btn_adiciona;
        private TextBox txt_numeros;
        private Label label1;
        private Label lbl_gravarNumeros;
        private TabPage tbp_ler;
        private Label label2;
        private OpenFileDialog ofd_LeArquivo;
        private Button btn_atualizar;
        private TextBox txt_lista;
    }
}