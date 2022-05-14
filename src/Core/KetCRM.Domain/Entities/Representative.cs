using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Представитель студента
    /// </summary>
    public class Representative
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Список студентов, которые относятся к представителю
        /// </summary>
        public List<Student> Students { get; set; } = new();
        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid PersonId { get; set; }
    }
}
