using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Подробная информация о студенте
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Живёт ли в общежитии
        /// </summary>
        public bool? Dormitory { get; set; }
        /// <summary>
        /// Имеет ли студент долги
        /// </summary>
        public bool? HasTwo { get; set; }
        /// <summary>
        /// Номер аттестата или диплома из прошлого учебного заведения
        /// </summary>
        public string? SchoolCertificateNumber { get; set; }
        /// <summary>
        /// Вид обучения
        /// </summary>
        public SchoolEducationType SchoolEducationType { get; set; }
        /// <summary>
        /// Год выпуска из предыдущего учебного заведения
        /// </summary>
        public DateTime? YearOfReleaseFromSchool { get; set; }
        /// <summary>
        /// Имеет ли студент медаль
        /// </summary>
        public bool? HasMedal { get; set; }
        /// <summary>
        /// Какое учебное заведение окончил
        /// </summary>
        public string? GraduatedSchool { get; set; }
        /// <summary>
        /// Поступает на бюджет
        /// </summary>
        public bool? OnAbudget { get; set; }
        /// <summary>
        /// Целевое обучение
        /// </summary>
        public bool? TargetedEducation { get; set; }
        /// <summary>
        /// По какому предмету во всероссийской олимпиаде победил студент (оставить пустым если ни в какой) 
        /// </summary>
        public string? OlimpiadeWinner { get; set; }
        /// <summary>
        /// Опыт работы
        /// </summary>
        public string? WorkExperience { get; set; }
        /// <summary>
        /// Номер диплома выпустившегося студента.
        /// </summary>
        public string? StudentCerteficateNumber { get; set; }
        /// <summary>
        /// Номер студенческого билета
        /// </summary>
        public string? StudentCardNumber { get; set; }
        /// <summary>
        /// Номер зачётной книжки студента
        /// </summary>
        public string? StudentRecordBookNumber { get; set; }
        /// <summary>
        /// Номер пропуска
        /// </summary>
        public string? PassCardNumber { get; set; }
        /// <summary>
        /// Нужен ли пропуск
        /// </summary>
        public bool? NeedIssuePassCard { get; set; }
        /// <summary>
        /// Статус студента
        /// </summary>
        public StudentStatuse StudentStatuse { get; set; }
        /// <summary>
        /// Изучаемый язык
        /// </summary>
        public StudiedLanguage StudiedLanguage { get; set; }

        /// <summary>
        /// Id учебного заведение, которое закончил студент
        /// </summary>
        public Guid? SchoolTypeId { get; set; }
        /// <summary>
        /// Учебное заведение, которое закончил студент
        /// </summary>
        public SchoolType? SchoolType { get; set; }
        /// <summary>
        /// Id представителя
        /// </summary>
        public Guid? RepresentativeId { get; set; }
        /// <summary>
        /// Представитель студента
        /// </summary>
        public Representative? Representative { get; set; }
        /// <summary>
        /// Id человека, к которому относится данная информация
        /// </summary>
        public Guid? PersonId { get; set; }
        /// <summary>
        /// Группа, в которой состоит студент
        /// </summary>
        public Guid? GroupId { get; set; }
        /// <summary>
        /// Группа, в которой состоит студент
        /// </summary>
        public Group? Group { get; set; }
        /// <summary>
        /// Список родителей студента
        /// </summary>
        public List<Parent>? Parents { get; set; }
    }
}
