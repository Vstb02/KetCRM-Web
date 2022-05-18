using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Specializations
{
    /// <summary>
    /// Обновление данных специализцаии
    /// </summary>
    public class UpdateSpecializationDto
    {
        /// <summary>
        /// Краткое название специальности
        /// </summary>
        public string? Name { get; set; } = string.Empty;
        /// <summary>
        /// Полное название специальности
        /// </summary>
        public string? FullName { get; set; } = string.Empty;
    }
}
