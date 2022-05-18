using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Departments
{
    /// <summary>
    /// Создание отделения
    /// </summary>
    public class CreateDepartmentsDto
    {
        /// <summary>
        /// Название отделения
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Код специальности
        /// </summary>
        [Required]
        public string Code { get; set; } = string.Empty;
    }
}
