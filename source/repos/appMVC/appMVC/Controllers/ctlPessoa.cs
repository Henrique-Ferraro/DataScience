using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appMVC.Models;
using appMVC.Data;
using appMVC.Data.Dtos;
using AutoMapper;

namespace appMVC.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ctlPessoa : ControllerBase
    {
        private ConnectDB _connectDB;
        private IMapper _mapperPessoa;

        public ctlPessoa(ConnectDB context, IMapper mapperPessoa)
        {
            _connectDB = context;
            _mapperPessoa = mapperPessoa;
        }

        [HttpPost]
        public IActionResult AdicionarPessoa([FromBody] ReadPessoaDto pessoaDto)
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
            if(pessoa == null)
            {
                return NotFound();
            }

            _mapperPessoa.Map(pessoaDto, pessoa);
            _connectDB.SaveChanges();
            return NoContent();
        }

        [HttpDelete ("{id}")]
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
