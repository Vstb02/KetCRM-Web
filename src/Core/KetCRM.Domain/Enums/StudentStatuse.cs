using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Enums
{
    /// <summary>
    /// Статус обучения
    /// </summary>
    public enum StudentStatuse
    {
        None,
        /// <summary>
        /// Обучается
        /// </summary>
        Studying,
        /// <summary>
        /// Отчислен
        /// </summary>
        Expelled,
        /// <summary>
        /// Выпустился
        /// </summary>
        Graduating
    }
}
