namespace RoleTopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}


        public double PrecoTotal {get;set;}

        public uint Status {get;set;}

        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
        }
    }
}