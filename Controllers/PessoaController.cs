using Microsoft.AspNetCore.Mvc;
using PrimeiraApiConsulta.Models;

namespace PrimeiraApiConsulta.Controllers
{
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public List<Pessoa> ObterPessoas()
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.ObterPessoas();
        }

        [HttpGet]
        public Pessoa ObterPessoaById(int id)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.ObterPessoaById(id);
        }

        [HttpGet("{controller}/{action}/{id}/{idTeste}")]
        public Pessoa ObterPessoaById([FromRoute]int id, [FromRoute] int idTeste)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.ObterPessoaById(id);
        }

        [HttpGet("{controller}/{action}/{id}")]
        public Pessoa ObterPessoaById([FromRoute] int id, [FromQuery] string idTeste)
        {
            Pessoa pessoa = new Pessoa();
            return pessoa.ObterPessoaById(id);
        }


    }
}
