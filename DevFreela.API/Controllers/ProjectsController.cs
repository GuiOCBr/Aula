using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        //api/projects?query=net core %20->espaço
        //Vai consultar de forma geral 
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        //api/projects/3
        //vai consultar de forma especifica

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            // return NotFound()
            return Ok();
        }

        [HttpPost]

        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            // pode se fazer uma validação 
            if (createProject.Title.Length > 20)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //api/projects/2
        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            // pode se fazer uma validação 
            if (updateProject.Description.Length > 20)
            {
                return BadRequest();
            }

            //atualiza o objeto
            return NoContent();
        }

        // api/projects/3 DELETE
        [HttpDelete("{id}")]

        public IActionResult Delete (int id)
        {
            // Buscar, se não existir, retorn NOTFOUND

            //Remover

            return NoContent();
        }

    }
}
