namespace projeto_Dora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.gbxJogo = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxAnimalUm = new System.Windows.Forms.PictureBox();
            this.pbxAnimaldois = new System.Windows.Forms.PictureBox();
            this.tmr_Animal_um = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbxJogo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimalUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimaldois)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(231, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparação de tamanho";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnComecar);
            this.panel3.Controls.Add(this.btnAutores);
            this.panel3.Controls.Add(this.btnReiniciar);
            this.panel3.Location = new System.Drawing.Point(16, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 100);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "erros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Acertos:";
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(157, 19);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(179, 63);
            this.btnComecar.TabIndex = 1;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Location = new System.Drawing.Point(572, 19);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(176, 63);
            this.btnAutores.TabIndex = 2;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(359, 19);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(192, 63);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar Jogo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // gbxJogo
            // 
            this.gbxJogo.Controls.Add(this.pbxAnimaldois);
            this.gbxJogo.Controls.Add(this.pbxAnimalUm);
            this.gbxJogo.Location = new System.Drawing.Point(15, 123);
            this.gbxJogo.Name = "gbxJogo";
            this.gbxJogo.Size = new System.Drawing.Size(773, 198);
            this.gbxJogo.TabIndex = 3;
            this.gbxJogo.TabStop = false;
            this.gbxJogo.Text = "Jogo de:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 58);
            this.panel2.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(312, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(158, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(191, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seu nome:";
            // 
            // pbxAnimalUm
            // 
            this.pbxAnimalUm.Location = new System.Drawing.Point(258, 19);
            this.pbxAnimalUm.Name = "pbxAnimalUm";
            this.pbxAnimalUm.Size = new System.Drawing.Size(256, 75);
            this.pbxAnimalUm.TabIndex = 0;
            this.pbxAnimalUm.TabStop = false;
            this.pbxAnimalUm.Click += new System.EventHandler(this.pbxAnimalUm_Click);
            // 
            // pbxAnimaldois
            // 
            this.pbxAnimaldois.Location = new System.Drawing.Point(256, 117);
            this.pbxAnimaldois.Name = "pbxAnimaldois";
            this.pbxAnimaldois.Size = new System.Drawing.Size(257, 70);
            this.pbxAnimaldois.TabIndex = 1;
            this.pbxAnimaldois.TabStop = false;
            this.pbxAnimaldois.Click += new System.EventHandler(this.pbxAnimaldois_Click);
            // 
            // tmr_Animal_um
            // 
            this.tmr_Animal_um.Enabled = true;
            this.tmr_Animal_um.Tick += new System.EventHandler(this.tmr_Animal_um_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxJogo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbxJogo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimalUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnimaldois)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.GroupBox gbxJogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxAnimaldois;
        private System.Windows.Forms.PictureBox pbxAnimalUm;
        private System.Windows.Forms.Timer tmr_Animal_um;
    }
}

