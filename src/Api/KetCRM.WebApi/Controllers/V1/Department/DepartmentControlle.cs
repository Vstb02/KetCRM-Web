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
            var result = await _departmentService.CreateDepartment(createDepartment);

            return Ok(result);
        }

        /// <summary>
        /// Удаление отделения
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Возвращает id удаленного отеделния</returns>
        [HttpDelete("DeleteDepartment/{Id}")]
        public async Task<IActionResult> DeleteDepartment(Guid Id)
        {
            var result = await _departmentService.DeleteDepartment(Id);

            return Ok(result);
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
            var result = await _departmentService.UpdateDepartment(updateDepartment, Id);

            return Ok(result);
        }

        /// <summary>
        /// Получение списка всех отделений
        /// </summary>
        /// <returns>Список отделений</returns>
        [HttpGet("GetAllDepartment")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var result = await _departmentService.GetAllDepartment();

            return Ok(result);
        }

        /// <summary>
        /// Получение данных отделения по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Данные отделения</returns>
        [HttpGet("GetDepartmentById/{Id}")]
        public async Task<IActionResult> GetDepartmentById(Guid Id)
        {
            var result = await _departmentService.GetDepartmentById(Id);

            return Ok(result);
        }
    }
}
