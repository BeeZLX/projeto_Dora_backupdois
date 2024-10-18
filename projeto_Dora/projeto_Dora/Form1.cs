using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projeto_Dora
{
    public partial class Form1 : Form
    {

        #region
        int contador, tipo = 0;
        Random random = new Random();
        int larguraAnimalUm;
        int larguraAnimalDois;
        #endregion
        public Form1()
        {
            InitializeComponent();
            btnAutores.Enabled = true;
            btnComecar.Enabled = false;
            btnReiniciar.Enabled = false;
            pbxAnimaldois.Visible = false;
            pbxAnimalUm.Visible = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            gbxJogo.ForeColor = Color.Red;
            gbxJogo.Text  = "jogo de: "+txtUsuario.Text;
            btnComecar.Enabled = verificaUsuario();
            btnReiniciar.Enabled = verificaUsuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vinicius de Moraes Regis, " +
                "Juana Isabela, " +
                "Vinicius Scarpit ", "Autores do Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            
            
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            pbxAnimalUm.Visible = true;
            pbxAnimaldois.Visible = true;

            int numeroAleatorioum = random.Next(1, 3);
            int numeroAleatoriodois = random.Next(1, 3);

            pbxAnimalUm.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\animal" + Convert.ToString(numeroAleatorioum) + ".JPG");
            pbxAnimalUm.SizeMode = PictureBoxSizeMode.StretchImage;
            larguraAnimalUm=pbxAnimalUm.Image.Width;

            pbxAnimaldois.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\animal" + Convert.ToString(numeroAleatoriodois) + ".JPG");
            pbxAnimaldois.SizeMode = PictureBoxSizeMode.StretchImage;
            larguraAnimalDois=pbxAnimaldois.Image.Width;
        }

        Boolean verificaUsuario()
        {
            if (txtUsuario.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void compararAnimais()
        {
            if (larguraAnimalUm > larguraAnimalDois)
            {
                MessageBox.Show("Animal 1 é maior");
            }
            else if(larguraAnimalUm<larguraAnimalDois){
                MessageBox.Show("Animal 2 é maior");
            }
            else
            {
                MessageBox.Show("mesmo tamanho");
            }
        }

        private void pbxAnimalUm_Click(object sender, EventArgs e)
        {
            compararAnimais();
        }

        private void pbxAnimaldois_Click(object sender, EventArgs e)
        {
            compararAnimais();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("reiniciar","Certeza que deseja reiniciar o jogo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes){
                txtUsuario.Clear();
                pbxAnimaldois.Visible=false;
                pbxAnimalUm.Visible = false;
            }
        }

        #region lixo
        private void tmr_Animal_um_Tick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
