using KetCRM.Application.Common.Interfaces.Persons;
using KetCRM.Application.Models.Persons;
using Microsoft.AspNetCore.Mvc;

namespace KetCRM.WebApi.Controllers.Persons
{
    public class PersonController : ApiControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        /// <param name="createPerson"></param>
        /// <returns>Возвращает id созданного объекта Person</returns>
        [HttpPost("CreatePerson")]
        public async Task<IActionResult> CreatePerson([FromBody]CreatePersonDto createPerson)
        {
            try
            {
                var result = await _personService.CreatePerson(createPerson);

                return Ok(result);
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpDelete("DeletePerson/{Id}")]
        public async Task<IActionResult> DeletePerson(Guid Id)
        {
            try
            {
                var result = await _personService.DeletePerson(Id);

                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
