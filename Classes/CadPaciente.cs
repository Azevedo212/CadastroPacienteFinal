


public class CadPaciente
{
    public string Nome { get; set; }

    public string CPF { get; set; }

    public string RG { get; set; }

    public string Data { get; set; }

    public string Sexo { get; set; }

    public string Telefone { get; set; }

  

    public CadPaciente()
    {

    }

    public CadPaciente(string Nome, string CPF, string RG, string Data, string Sexo, string Telefone)
    {
        this.Nome = Nome;
        this.CPF = CPF;
        this.RG = RG;
        this.Data = Data;
        this.Sexo = Sexo;
        this.Telefone = Telefone;
      

    }


}