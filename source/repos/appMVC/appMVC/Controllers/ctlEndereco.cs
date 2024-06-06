using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appMVC.Models;
using appMVC.Data;
using appMVC.Data.Dtos;
using AutoMapper;
using appMVC.models;

namespace appMVC.Templates
{
   [ApiController]
   [Route("controller")]
   public class Template : ControllerBase
   {
        private ConnectDB _connectDB;
        private IMapper _mapperPessoa;
        private IMapper _mapperEndereco;
        private IMapper _mapperTelefone;

        public Bd(ConnectDB context, IMapper mapperEndereco IMapper mapperPessoa IMapper mapperTelefone)
        {
            _connectDB = context;
            _mapperPessoa = mapperPessoa;
            _mapperEndereco = mapperEndereco;
            _mapperPessoa = mapperPessoa;
  
        }

        [HttpPost]
        public IActionResult btnSalvar_click([FromBody] ReadEnderecoDto enderecoDto ReadPessoaDto pessoaDto ReadTelefoneDto telefoneDto)
        {

            mdlPessoa pessoa = _mapperPessoa.Map<mdlPessoa>(pessoaDto);
            _connectDB.Pessoas.Add(pessoa);
            _connectDB.SaveChanges();
            return CreatedAtAction(nameof(RecuperarPessoasPorId), new { Id = pessoa.Id }, pessoa);

            mdlEndereco endereco = _mapperEndereco.Map<mdlEndereco>(enderecoDto);
            _connectDB.Enderecos.Add(endereco);
            _connectDB.SaveChanges();
            return CreatedAtAction(nameof(RecuperarEnderecosPorId), new { Id = endereco.Id }, endereco);

             mdlTelefone telefone = _mapperTelefone.Map<mdlTelefone>(telefoneDto);
            _connectDB.Telefones.Add(telefone);
            _connectDB.SaveChanges();
            return CreatedAtAction(nameof(RecuperarTelefonesPorId), new { Id = telefone.Id }, telefone);
        }

        [HttpGet]
        public IEnumerable<ctlEndereco> RecuperarEnderecos()
        {
            return (IEnumerable<ctlEndereco>)_connectDB.Enderecos;
        }

        [HttpGet]
        public IEnumerable<ctlPessoa> RecuperarPessoas()
        {
            //Observacao
            return (IEnumerable<ctlPessoa>)_connectDB.Pessoas;
        }

        [HttpGet]
        public IEnumerable<ctlTelefone> RecuperarTelefones()
        {
            return (IEnumerable<ctlTelefone>)_connectDB.Telefones;
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

        [HttpGet("{id}")]
        public IActionResult RecuperarEnderecosPorId(int id)
        {
            mdlPessoa pessoa = _connectDB.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (pessoa != null)
            {
                ReadPessoaDto pessoaDto = _mapperPessoa.Map<ReadPessoaDto>(pessoa);

                return Ok(pessoaDto);
            }
            return NotFound();

            mdlEndereco endereco = _connectDB.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null)
            {
                ReadEnderecoDto enderecoDto = _mapperEndereco.Map<ReadEnderecoDto>(endereco);

                return Ok(enderecoDto);
            }

            mdlTelefone telefone = _connectDB.Telefones.FirstOrDefault(telefone => telefone.Id == id);
            if(telefone != null)
            {
                ReadTelefoneDto telefoneDto = _mapperTelefone.Map<ReadTelefoneDto>(telefone);

                return Ok(telefoneDto);
            }
            return NotFound();
        }

         [HttpGet("{id}")]
        public IActionResult RecuperarTelefonesPorId(int id)
        {
            mdlTelefone telefone = _connectDB.Telefones.FirstOrDefault(telefone => telefone.Id == id);
            if(telefone != null)
            {
                ReadTelefoneDto telefoneDto = _mapperTelefone.Map<ReadTelefoneDto>(telefone);

                return Ok(telefoneDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult btnAtualizar_click(int id, [FromBody] UpdateEnderecoDto enderecoDto, UpdatePessoaDto pessoaDto, UpdateTelefoneDto telefoneDto)
        {
            if (enderecoDto is null)
            {
                throw new ArgumentNullException(nameof(enderecoDto));
            }

            if (pessoaDto is null)
            {
                throw new ArgumentNullException(nameof(pessoaDto));
            }

            if (telefoneDto is null)
            {
                throw new ArgumentNullException(nameof(telefoneDto));
            }

            mdlEndereco endereco = _connectDB.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }

            _mapperEndereco.Map(enderecoDto, endereco);
            _connectDB.SaveChanges();
            return NoContent();

            mdlPessoa pessoa = _connectDB.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if(pessoa == null)
            {
                return NotFound();
            }

            _mapperPessoa.Map(pessoaDto, pessoa);
            _connectDB.SaveChanges();
            return NoContent();

            mdlTelefone telefone = _connectDB.Telefones.FirstOrDefault(telefone => telefone.Id == id);
            if (telefone == null)
            {
                return NotFound();
            }

            _mapperTelefone.Map(telefoneDto, telefone);
            _connectDB.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult btnDeletar_click(int id)
        {
            mdlEndereco endereco = _connectDB.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _connectDB.Remove(endereco);
            _connectDB.SaveChanges();
            return NoContent();

            mdlPessoa pessoa = _connectDB.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            _connectDB.Remove(pessoa);
            _connectDB.SaveChanges();
            return NoContent();

            mdlTelefone telefone = _connectDB.Telefones.FirstOrDefault(telefone => telefone.Id == id);
            if (telefone == null)
            {
                return NotFound();
            }
            _connectDB.Remove(telefone);
            _connectDB.SaveChanges();
            return NoContent();
        }
    }
}


