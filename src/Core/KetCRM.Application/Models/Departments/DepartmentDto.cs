using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Departments
{
    /// <summary>
    /// Информация об отделении
    /// </summary>
    public class DepartmentDto
    {
        /// <summary>
        /// Название отделения
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Код специальности
        /// </summary>
        public string Code { get; set; } = string.Empty;
    }
}
