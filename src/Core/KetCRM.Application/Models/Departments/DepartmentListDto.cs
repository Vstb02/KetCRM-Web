using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Departments
{
    /// <summary>
    /// Информация об отделениях
    /// </summary>
    public class DepartmentListDto
    {
        /// <summary>
        /// Список отделений
        /// </summary>
        public IList<DepartmentDto> List { get; set; } = new List<DepartmentDto>();
    }
}
