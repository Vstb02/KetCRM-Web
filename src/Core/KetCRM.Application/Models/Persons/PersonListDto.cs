using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Persons
{
    public class PersonListDto
    {
        public IList<PersonDto> PersonList { get; set; } = new List<PersonDto>();
    }
}
