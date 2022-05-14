using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Enums
{
    /// <summary>
    /// Форма обучения
    /// </summary>
    public enum FormsOfEducation
    {
        None,
        /// <summary>
        /// Очная форма обучения
        /// </summary>
        Intramural,
        /// <summary>
        /// Заочная форма обучения
        /// </summary>
        Extramural,
        /// <summary>
        /// Очно-заочная форма
        /// </summary>
        Parttime
    }
}
