using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModAPI.Context;
using ModAPI.Entities;

namespace ModAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        //busca pelo ID
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);
            if(contato == null)
            {
                return NotFound();
            }
            return Ok(contato);

        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }        

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if(contatoBanco == null)
            {
                return NotFound();
            }
            else
            {
                contatoBanco.Nome = contato.Nome; //contatoBAnco.nome é do bando do dados e contato.nome que vem da requisição
                contatoBanco.Telefone = contato.Telefone;
                contatoBanco.Ativo = contato.Ativo;

                _context.Contatos.Update(contatoBanco);
                _context.SaveChanges();
                return Ok(contatoBanco);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
             var contatoBanco = _context.Contatos.Find(id);
              if(contatoBanco == null)
            {
                return NotFound();
            }
            else
            {
                _context.Contatos.Remove(contatoBanco);
                _context.SaveChanges(); //salvar as alterações
                return NoContent(); //sem conteudo para retornar
            }
        }
    }
}