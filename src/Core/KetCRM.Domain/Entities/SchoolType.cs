using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Учебное заведение
    /// </summary>
    public class SchoolType
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя учебного заведения
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Список студентов, которые обучались в учебном заведении
        /// </summary>
        public List<Student> Students { get; set; } = new();
    }
}
