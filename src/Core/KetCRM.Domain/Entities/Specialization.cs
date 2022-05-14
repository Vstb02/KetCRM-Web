using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Информация о специальностях
    /// </summary>
    public class Specialization
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Краткое название специальности
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Полное название специальности
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Список групп, принадлежащих специализации
        /// </summary>
        public List<Group> Groups = new();
    }
}
