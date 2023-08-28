using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PacienteCadastroFinal.telas
{
    public partial class CadastroPaciente : Form
    {
        List<CadPaciente> pacientes = new List<CadPaciente>();
        public CadastroPaciente()
        {

            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {

            CadPaciente paciente = new CadPaciente();

            try
            {
                paciente.Nome = tx_nome.Text;
                paciente.CPF = tx_cpf.Text;
                paciente.RG = tx_rg.Text;
                paciente.Telefone = tx_telefone.Text;
                paciente.Data = tx_data.Text;
                paciente.Sexo = tx_sexo.Text;


                pacientes.Add(paciente);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = pacientes;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato Inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os dados corretamente!!!");
            }
            
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                pacientes.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = pacientes;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não há mais celular restantes para excluir!");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_rg.Clear();
            tx_telefone.Clear();
            tx_data.Clear();
            tx_sexo.ResetText();
        }
        private void SalvarDados()
        {

        }
        private void CadastroPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter texto = new StreamWriter(@"C:\Users\Azevedo\Documents\teste.txt"))
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        var linha = dataGridView1.Rows[i].Cells["Nome"].Value + "; " +
                                    dataGridView1.Rows[i].Cells["CPF"].Value + "; " +
                                    dataGridView1.Rows[i].Cells["RG"].Value + "; " +
                                    dataGridView1.Rows[i].Cells["Telefone"].Value + "; " +
                                    dataGridView1.Rows[i].Cells["Data"].Value + "; " +
                                    dataGridView1.Rows[i].Cells["Sexo"].Value + "; ";

                        texto.WriteLine(linha);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
