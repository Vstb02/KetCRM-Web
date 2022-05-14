using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Информация о группах
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
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
        public Guid? SpecializationId { get; set; }
        /// <summary>
        /// Специализация группы
        /// </summary>
        public Specialization? Specialization { get; set; }
        /// <summary>
        /// Id отделения
        /// </summary>
        public Guid? DepartamentId { get; set; }
        /// <summary>
        /// Отделение группы
        /// </summary>
        public Department? Department { get; set; }
        /// <summary>
        /// Информация о классном руководителе
        /// </summary>
        public Teacher? Teacher { get; set; }
        /// <summary>
        /// Список студентов, которые находятся в группе
        /// </summary>
        public List<Student>? Students { get; set; }
    }
}
