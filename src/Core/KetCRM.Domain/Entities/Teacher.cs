using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Подробная информация о преподавателе
    /// </summary>
    public class Teacher
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
        /// Id группы, в которой преподавтель является классным руководителем
        /// </summary>
        public Guid? GroupId { get; set; }
        /// <summary>
        /// Группа преподавателя
        /// </summary>
        public Group? Group { get; set; }
    }
}
