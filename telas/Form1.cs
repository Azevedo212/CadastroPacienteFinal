namespace PacienteCadastroFinal;
using PacienteCadastroFinal.telas;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        CadastroPaciente c = new CadastroPaciente();
        c.ShowDialog();
    }



    private void button3_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
