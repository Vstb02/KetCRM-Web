using KetCRM.Application.Common.Interfaces.Specializations;
using KetCRM.Application.Models.Specializations;
using Microsoft.AspNetCore.Mvc;

namespace KetCRM.WebApi.Controllers.V1.Specialization
{
    [ApiVersion("1.0")]
    public class SpecializationController : ApiControllerBase
    {
        private readonly ISpecializationService _specializationService;
        private readonly ILogger<SpecializationController> _logger;

        public SpecializationController(ISpecializationService specializationService,
            ILogger<SpecializationController> logger)
        {
            _specializationService = specializationService;
            _logger = logger;
        }

        /// <summary>
        /// Создание новой специализации
        /// </summary>
        /// <param name="createSpecialization"></param>
        /// <returns>Возвращает id созданного объекта Specialization</returns>
        [HttpPost("CreateSpecialization")]
        public async Task<IActionResult> CreateSpecialization([FromBody] CreateSpecializationDto createSpecialization)
        {
            try
            {
                var result = await _specializationService.CreateSpecialization(createSpecialization);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке создать специализацию");
            }
        }

        /// <summary>
        /// Удаление специализации
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Возвращает id удаленной специализации</returns>
        [HttpDelete("DeleteSpecialization/{Id}")]
        public async Task<IActionResult> DeleteSpecialization(Guid Id)
        {
            try
            {
                var result = await _specializationService.DeleteSpecialization(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла обшибка при попытке удалить специализацию");
            }
        }

        /// <summary>
        /// Обновление данных специализации
        /// </summary>
        /// <param name="updateSpecializationDto"></param>
        /// <param name="Id"></param>
        /// <returns>Id специализации</returns>
        [HttpPut("UpdateSpecialization/{Id}")]
        public async Task<IActionResult> UpdatePerson([FromBody] UpdateSpecializationDto updateSpecialization, Guid Id)
        {
            try
            {
                var result = await _specializationService.UpdateSpecialization(updateSpecialization, Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке обновления данных специализации");
            }
        }

        /// <summary>
        /// Получение списка всех специализаций
        /// </summary>
        /// <returns>Список специализаций</returns>
        [HttpGet("GetAllSpecialization")]
        public async Task<IActionResult> GetAllSpecialization()
        {
            try
            {
                var result = await _specializationService.GetAllSpecialization();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке получения данных специализации");
            }
        }

        /// <summary>
        /// Получение данных специализации по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Данные специализации</returns>
        [HttpGet("GetSpecializationById/{Id}")]
        public async Task<IActionResult> GetSpecializationById(Guid Id)
        {
            try
            {
                var result = await _specializationService.GetSpecializationById(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попоытке получения данных специализации");
            }
        }
    }
}
