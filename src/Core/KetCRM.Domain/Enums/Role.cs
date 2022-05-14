using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Enums
{
    /// <summary>
    /// Тип пользователя
    /// </summary>
    public enum Role
    {
        None,
        /// <summary>
        /// Студент
        /// </summary>
        Student,
        /// <summary>
        /// Учитель
        /// </summary>
        Teacher,
        /// <summary>
        /// Родитель
        /// </summary>
        Parent
    }
}
