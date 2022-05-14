using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Информацию об отделениях
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название отделения
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Код специальности
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Список групп, который относятся к отделению
        /// </summary>
        public List<Group> Groups { get; set; } = new();
    }
}
