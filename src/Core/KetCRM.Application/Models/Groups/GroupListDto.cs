using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Groups
{
    /// <summary>
    /// Список групп
    /// </summary>
    public class GroupListDto
    {
        /// <summary>
        /// Список групп
        /// </summary>
        public IList<GroupDto> List { get; set; } = new List<GroupDto>();
    }
}
