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

namespace appMVC.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ctlTelefone : ControllerBase
    {
        private ConnectDB _connectDB;
        private IMapper _mapperTelefone;

        public ctlTelefone(ConnectDB context, IMapper mapperTelefone)
        {
            _connectDB = context;
            _mapperTelefone = mapperTelefone;
        }

        [HttpPost]
        public IActionResult AdicionarTelefone([FromBody] ReadTelefoneaDto telefoneDto)
        {
            mdlTelefone telefone = _mapperTelefone.Map<mdlTelefone>(telefoneDto);
            _connectDB.Telefones.Add(telefone);
            _connectDB.SaveChanges();
            return CreatedAtAction(nameof(RecuperarTelefonesPorId), new { Id = telefone.Id }, telefone);

        }

        [HttpGet]
        public IEnumerable<ctlTelefone> RecuperarTelefones()
        {
            return (IEnumerable<ctlTelefone>)_connectDB.Telefones;
        }


        [HttpGet("{id}")]
        public IActionResult RecuperarTelefonesPorId(int id)
        {
            mdlTelefone telefone = _connectDB.Telefones.FirstOrDefault(telefone => telefone.Id == id);
            if(telefone != null)
            {
                ReadTelefoneaDto telefoneDto = _mapperTelefone.Map<ReadTelefoneaDto>(telefone);

                return Ok(telefoneDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTelefone(int id, [FromBody] UpdateTelefoneDto telefoneaDto)
        {
            mdlTelefone telefone = _connectDB.Telefones.FirstOrDefault(telefone => telefone.Id == id);
            if (telefone == null)
            {
                return NotFound();
            }

            _mapperTelefone.Map(telefoneaDto, telefone);
            _connectDB.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarTelefones(int id)
        {
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
