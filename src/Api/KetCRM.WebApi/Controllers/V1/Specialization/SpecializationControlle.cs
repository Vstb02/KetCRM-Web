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
            var result = await _specializationService.CreateSpecialization(createSpecialization);

            return Ok(result);
        }

        /// <summary>
        /// Удаление специализации
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Возвращает id удаленной специализации</returns>
        [HttpDelete("DeleteSpecialization/{Id}")]
        public async Task<IActionResult> DeleteSpecialization(Guid Id)
        {
            var result = await _specializationService.DeleteSpecialization(Id);

            return Ok(result);
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
            var result = await _specializationService.UpdateSpecialization(updateSpecialization, Id);

            return Ok(result);
        }

        /// <summary>
        /// Получение списка всех специализаций
        /// </summary>
        /// <returns>Список специализаций</returns>
        [HttpGet("GetAllSpecialization")]
        public async Task<IActionResult> GetAllPerson()
        {
            var result = await _specializationService.GetAllSpecialization();

            return Ok(result);
        }

        /// <summary>
        /// Получение данных специализации по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Данные специализации</returns>
        [HttpGet("GetSpecializationById/{Id}")]
        public async Task<IActionResult> GetSpecializationById(Guid Id)
        {
            var result = await _specializationService.GetSpecializationById(Id);

            return Ok(result);
        }
    }
}
