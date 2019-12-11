using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositorios
{
    public class ClienteRepositorio : RepositorioBase 
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepositorio()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente c)
        {
            var l = new string[] { Preparar(c)};
            File.AppendAllLines(PATH, l);

            return true;
        }

        public Cliente  ObterCliente(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome",item);
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario",item));
                    c.Email = ExtrairValorDoCampo("email",item);
                    c.Senha = ExtrairValorDoCampo("senha",item);
                    c.Telefone = ExtrairValorDoCampo("telefone",item);
                    c.CPF = ExtrairValorDoCampo("cpf",item);
                    return c;
                }
            }
            return null;
        }
        private string Preparar(Cliente c)
        {
            return $"tipo_usuario={c.TipoUsuario};nome={c.Nome};email={c.Email};senha={c.Senha};telefone={c.Telefone};cpf={c.CPF}";
        }
    }
}