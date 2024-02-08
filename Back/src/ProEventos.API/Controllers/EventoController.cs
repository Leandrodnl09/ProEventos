using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
           
        }
        
        public IEnumerable<Evento> _evento = new Evento[]
        {   
            new Evento()
            {                
                EventoId = 1,
                Tema = "Angular 12 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º LOte",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
            },
            new Evento()
            {                
                EventoId = 2,
                Tema = "Angular 12 e .NET 5",
                Local = "São Paulo",
                Lote = "2º LOte",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto2.png"
            }             
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(_evento => _evento.EventoId == id) ;
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put pelo id: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete pelo id: {id}";
        }
    }
}
