using KetCRM.Domain.Entities;
using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Groups
{
    /// <summary>
    /// Обновление данных группы
    /// </summary>
    public class UpdateGroupDto
    {
        /// <summary>
        /// Номер курса
        /// </summary>
        [MaxLength(1)]
        [RegularExpression(@"[1-9]")]
        public string? CourseNumber { get; set; }
        /// <summary>
        /// Номер группы
        /// </summary>
        [MaxLength(1)]
        [RegularExpression(@"[1-9]")]
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
        public Guid? SpecializationId { get; set; }
        /// <summary>
        /// Id отделения
        /// </summary>
        public Guid? DepartamentId { get; set; }
    }
}
