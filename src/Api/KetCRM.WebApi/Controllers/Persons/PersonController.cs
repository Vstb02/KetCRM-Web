using KetCRM.Application.Common.Interfaces.Persons;
using KetCRM.Application.Models.Persons;
using Microsoft.AspNetCore.Mvc;
using Serilog;

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
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Возвращает id удаленного пользователя</returns>
        [HttpDelete("DeletePerson/{Id}")]
        public async Task<IActionResult> DeletePerson(Guid Id)
        {
            try
            {
                var result = await _personService.DeletePerson(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Обновление данных пользователя
        /// </summary>
        /// <param name="updatePerson"></param>
        /// <param name="Id"></param>
        /// <returns>Id пользователя</returns>
        [HttpPut("UpdatePerson/{Id}")]
        public async Task<IActionResult> UpdatePerson([FromBody]UpdatePersonDto updatePerson, Guid Id)
        {
            try
            {
                var result = await _personService.UpdatePerson(updatePerson, Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Получение списка всех пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        [HttpGet("GetAllPerson")]
        public async Task<IActionResult> GetAllPerson()
        {
            try
            {
                var result = await _personService.GetAllPerson();

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Получение данных пользователя по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Данные пользователя</returns>
        [HttpGet("GetPersonById/{Id}")]
        public async Task<IActionResult> GetPersonById(Guid Id)
        {
            try
            {
                var result = await _personService.GetPersonById(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
