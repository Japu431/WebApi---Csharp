using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>();
        private static int Id = 1;


        // Criar Usuario no Sistema[Array]
        [HttpPost]
        public void AdicionarUsuario([FromBody] User user)
        {
            user.Id = Id++;
            users.Add(user);
            Console.WriteLine($"Adicionado com sucesso!");
        }
         
        // Pegar do Sistema[Array]

        [HttpGet]
        public IActionResult PegarUsuariosDoBancoDeDados()
        {
            return Ok(users);
        }

        [HttpGet("{id}")]

        // Pegar do Sistema via ID no parametro[Array]
        public IActionResult PegarUsuarioViaID(int id)
        {
            User user = users.FirstOrDefault(user => user.Id == id);

            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        

        // [HttpPut("{id}")]
        // public IActionResult AtualizarDadosDoUsuario(int id, [FromBody] User user)
        // {
        //     User user = users.FirstOrDefault(user => user.Id == id);

        //     if(user.Id != null)
        //     {
        //         return BadRequest();
        //     }
        //     users.Add(user);

        // }

    }
}