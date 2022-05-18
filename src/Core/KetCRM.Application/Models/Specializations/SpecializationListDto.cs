using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Specializations
{
    /// <summary>
    /// Список специализаций
    /// </summary>
    public class SpecializationListDto
    {
        /// <summary>
        /// Список специализаций
        /// </summary>
        public IList<SpecializationDto> List { get; set; } = new List<SpecializationDto>();
    }
}
