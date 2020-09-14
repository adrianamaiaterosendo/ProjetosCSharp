namespace Banco
{
    public class Cliente
    {
        private string v;

        public Cliente(string cliente)
        {
            this.Nome = cliente;
        }

        public string Nome { get; set; }
    }
}