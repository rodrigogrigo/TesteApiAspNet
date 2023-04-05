namespace PrimeiraApiConsulta.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cpf { get; set; }

        public Pessoa ObterPessoaById(int idPessoa)
        {
            // Obtendo a lista das pessoas
            List<Pessoa> listaPessoas = ObterPessoas();

            // Procurando por uma pessoa através do Id
            return listaPessoas.Find(pessoaDaLista =>
                pessoaDaLista.Id == idPessoa);
        }

        public List<Pessoa> ObterPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>()
            {
                new Pessoa() {
                    Id = 1,
                    Nome = "Pessoa A",
                    Endereco = "Endereco Pessoa A",
                    Cpf = "123456",
                    Cep = "29780000"
                },
                new Pessoa() {
                    Id = 2,
                    Nome = "Pessoa B",
                    Endereco = "Endereco Pessoa B",
                    Cpf = "654987",
                    Cep = "29000000"
                },
                new Pessoa() {
                    Id = 3,
                    Nome = "Pessoa C",
                    Endereco = "Endereco Pessoa C",
                    Cpf = "654987",
                    Cep = "29000000"
                },
            };

            return listaPessoas;
        }
    }
}
