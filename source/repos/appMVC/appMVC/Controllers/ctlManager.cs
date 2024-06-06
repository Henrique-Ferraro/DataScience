using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appMVC.Models;
using appMVC.Data;
using appMVC.Data.Dtos;
using AutoMapper;
using appMVC.Data.Dtos.Manager;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace appMVC.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ctlManager : ControllerBase
    {
        private ConnectDB _connectDB;
        private IMapper _mapperManager;

        public ctlManager(ConnectDB context, IMapper mapperManager)
        {
            _connectDB = context;
            _mapperManager = mapperManager;
        }

        [HttpPost]
        public IActionResult AdicionarManager(CreateManagerDto managerDto)
        {
            mdlManager manager = _mapperManager.Map<mdlManager>(managerDto);
            _connectDB.Managers.Add(manager);
            _connectDB.SaveChanges();
            return CreatedAtAction(nameof(RecuperarManagersPorId), new { Id = manager.Id }, manager);
        }
        public IActionResult RecuperarManagersPorId(int Id)
        {
            mdlManager manager = _connectDB.Managers.FirstOrDefault(manager => manager.Id == Id);
            if (manager != null)
            {
                ReadManagerDto managerDto = _mapperManager.Map<ReadManagerDto>(manager);

                return Ok(managerDto);
            }
            return NotFound();
        }
    }
}
