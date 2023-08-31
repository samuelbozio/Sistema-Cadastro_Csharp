using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main_frm : Form
    {
        Connection connection = new Connection();
        MySqlCommand cmd = new MySqlCommand();
        string sql;
        public main_frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DesabilitaCampo();
            DesabilitarBotoes();
            btnNovo.Enabled = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTittle_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampo();
            txtNome.Focus();
            HabilitarBotoes();
            btnNovo.Enabled = false;




        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.ToString().Trim() == " ")
            {
                MessageBox.Show("Nome inválido. ");
                txtNome.Text = "";
                txtNome.Focus();    
                return;
            }
            if (txtCPF.Text.ToString().Trim() == "   ,   ,   -" || txtCPF.Text.Length > 14)
            {
                MessageBox.Show("CPF Inválido");
                txtCPF.Focus();
                return; 
            }

            connection.openConnection();
            sql = "INSERT INTO cliente (Nome, Endereco, CPF, Telefone) VALUES (@Nome, @Endereco, @CPF, @Telefone)";
            cmd = new MySqlCommand(sql, connection.connection);
        
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("@Telefone", txtTel.Text);

            cmd.ExecuteNonQuery();
            connection.closeConnection();

            LimpaCampo();
            DesabilitaCampo();
            DesabilitarBotoes();
            btnNovo.Enabled = true;






        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            DesabilitaCampo();
            DesabilitarBotoes();
            btnNovo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            btnNovo.Enabled = true;
            DesabilitaCampo();
            LimpaCampo();
        }

        private void DesabilitarBotoes()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void HabilitarBotoes()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitaCampo()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtCPF.Enabled = false;
            txtTel.Enabled = false;


        }

        private void HabilitaCampo()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtCPF.Enabled = true;
            txtTel.Enabled = true;
        }

        private void LimpaCampo()
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtTel.Text = string.Empty;

        }
    }
}
