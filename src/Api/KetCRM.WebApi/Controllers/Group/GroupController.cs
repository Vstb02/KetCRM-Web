using KetCRM.Application.Common.Interfaces.Groups;
using KetCRM.Application.Models.Groups;
using Microsoft.AspNetCore.Mvc;

namespace KetCRM.WebApi.Controllers.Group
{
    [ApiVersion("1.0")]
    public class GroupController : ApiControllerBase
    {
        private readonly IGroupService _groupService;
        private readonly ILogger<GroupController> _logger;

        public GroupController(IGroupService groupService,
            ILogger<GroupController> logger)
        {
            _groupService = groupService;
            _logger = logger;
        }

        /// <summary>
        /// Создание нового группы
        /// </summary>
        /// <param name="createPerson"></param>
        /// <returns>Возвращает id созданного объекта Group</returns>
        [HttpPost("CreateGroup")]
        public async Task<IActionResult> CreateGroup([FromBody] CreateGroupDto createGroup)
        {
            try
            {
                var result = await _groupService.CreateGroup(createGroup);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке создать группу");
            }
        }

        /// <summary>
        /// Удаление гурппы
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Возвращает id удаленной группы</returns>
        [HttpDelete("DeleteGroup/{Id}")]
        public async Task<IActionResult> DeleteGroup(Guid Id)
        {
            try
            {
                var result = await _groupService.DeleteGroup(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла обшибка при попытке удалить группу");
            }
        }

        /// <summary>
        /// Обновление данных группы
        /// </summary>
        /// <param name="updatePerson"></param>
        /// <param name="Id"></param>
        /// <returns>Id группы</returns>
        [HttpPut("UpdateGroup/{Id}")]
        public async Task<IActionResult> UpdatePerson([FromBody] UpdateGroupDto updateGroup, Guid Id)
        {
            try
            {
                var result = await _groupService.UpdateGroup(updateGroup, Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке обновления данных группы");
            }
        }

        /// <summary>
        /// Получение списка всех групп
        /// </summary>
        /// <returns>Список гурпп</returns>
        [HttpGet("GetAllGroup")]
        public async Task<IActionResult> GetAllPerson()
        {
            try
            {
                var result = await _groupService.GetAllGroup();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попытке получения данных группы");
            }
        }

        /// <summary>
        /// Получение данных гурппы по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Данные группы</returns>
        [HttpGet("GetGroupById/{Id}")]
        public async Task<IActionResult> GetGroupById(Guid Id)
        {
            try
            {
                var result = await _groupService.GetGroupById(Id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, "Произошла ошибка при попоытке получения данных группы");
            }
        }
    }
}
