using KetCRM.Domain.Entities;
using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Groups
{
    /// <summary>
    /// Данные группы
    /// </summary>
    public class GroupDto
    {
        /// <summary>
        /// Номер курса
        /// </summary>
        public string? CourseNumber { get; set; }
        /// <summary>
        /// Номер группы
        /// </summary>
        public string? GroupNumber { get; set; }
        /// <summary>
        /// После 11 класса
        /// </summary>
        public bool? AfterEleven { get; set; }
        /// <summary>
        /// Форма обучения
        /// </summary>
        public FormsOfEducation FormsOfEducation { get; set; }

        /// <summary>
        /// Id специализации
        /// </summary>
    }
}
