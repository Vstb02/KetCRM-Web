using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    public class Parent
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// Список детей
        /// </summary>
        public List<Student> Students { get; set; } = new();
    }
}
