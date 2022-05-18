using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Specializations
{
    /// <summary>
    /// Создание специализации
    /// </summary>
    public class CreateSpecializationDto
    {
        /// <summary>
        /// Краткое название специальности
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Полное название специальности
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = string.Empty;
    }
}
