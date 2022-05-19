using KetCRM.Application.Common.Interfaces.Departmnt;
using KetCRM.Application.Models.Departments;
using Microsoft.AspNetCore.Mvc;

namespace KetCRM.WebApi.Controllers.V1.Department
{
    [ApiVersion("1.0")]
    public class DepartmentController : ApiControllerBase
    {
        private readonly IDepartmentSerivce _departmentService;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IDepartmentSerivce departmentService,
            ILogger<DepartmentController> logger)
        {
            _departmentService = departmentService;
            _logger = logger;
        }

        /// <summary>
        /// Создание нового отделения
        /// </summary>
        /// <param name="createDepartment"></param>
        /// <returns>Возвращает id созданного объекта Department</returns>
        [HttpPost("CreateDepartment")]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentDto createDepartment)
        {
            try
            {
                var result = await _departmentService.CreateDepartment(createDepartment);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке создать отделение");
            }
        }

        /// <summary>
        /// Удаление отделения
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Возвращает id удаленного отеделния</returns>
        [HttpDelete("DeleteDepartment/{Id}")]
        public async Task<IActionResult> DeleteDepartment(Guid Id)
        {
            try
            {
                var result = await _departmentService.DeleteDepartment(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла обшибка при попытке удалить отделение");
            }
        }

        /// <summary>
        /// Обновление данных отделения
        /// </summary>
        /// <param name="updatePerson"></param>
        /// <param name="Id"></param>
        /// <returns>Id отделения</returns>
        [HttpPut("UpdateDepartment/{Id}")]
        public async Task<IActionResult> UpdateDepartment([FromBody] UpdateDepartmentDto updateDepartment, Guid Id)
        {
            try
            {
                var result = await _departmentService.UpdateDepartment(updateDepartment, Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке обновления данных отделения");
            }
        }

        /// <summary>
        /// Получение списка всех отделений
        /// </summary>
        /// <returns>Список отделений</returns>
        [HttpGet("GetAllDepartment")]
        public async Task<IActionResult> GetAllDepartment()
        {
            try
            {
                var result = await _departmentService.GetAllDepartment();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке получения данных отделения");
            }
        }

        /// <summary>
        /// Получение данных отделения по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Данные отделения</returns>
        [HttpGet("GetDepartmentById/{Id}")]
        public async Task<IActionResult> GetDepartmentById(Guid Id)
        {
            try
            {
                var result = await _departmentService.GetDepartmentById(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попоытке получения данных отделения");
            }
        }
    }
}
