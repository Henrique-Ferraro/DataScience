using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Models
{
    public interface PessoaDao<ctlPessoa>

        void AdicionarPessoa([FromBody] ReadPessoaDto pessoaDto)
        {
            mdlPessoa pessoa = _mapperPessoa.Map<mdlPessoa>(pessoaDto);
            _connectDB.Pessoas.Add(pessoa);
            _connectDB.SaveChanges();
            return CreatedAtAction(nameof(RecuperarPessoasPorId), new { Id = pessoa.Id }, pessoa);
        }

        [HttpGet]
        public IEnumerable<ctlPessoa> RecuperarPessoas()
        {
            //Observacao
            return (IEnumerable<ctlPessoa>)_connectDB.Pessoas;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPessoasPorId(int id)
        {
            mdlPessoa pessoa = _connectDB.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (pessoa != null)
            {
                ReadPessoaDto pessoaDto = _mapperPessoa.Map<ReadPessoaDto>(pessoa);

                return Ok(pessoaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPessoa(int id, [FromBody] UpdatePessoaDto pessoaDto)
        {
            mdlPessoa pessoa = _connectDB.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            _mapperPessoa.Map(pessoaDto, pessoa);
            _connectDB.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPessoas(int id)
        {
            mdlPessoa pessoa = _connectDB.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            _connectDB.Remove(pessoa);
            _connectDB.SaveChanges();
            return NoContent();
        }


    }
}
