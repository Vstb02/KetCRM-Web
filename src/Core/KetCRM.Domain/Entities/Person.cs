using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Информация как о пользователях (старосты, учителя), так и о людях которые пользователями не являются (студенты, их представители).
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string? Surname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronymic { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string? EmailAddress { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// Номер СНИЛСа
        /// </summary>
        public string? Snils { get; set; }
        /// <summary>
        /// Номер страховки
        /// </summary>
        public string? InsuranceNumber { get; set; }
        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string? PassportSeries { get; set; }
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string? PassportNumber { get; set; }
        /// <summary>
        /// Дата выдачи паспорта
        /// </summary>
        public DateTime? PassportDate { get; set; }
        /// <summary>
        /// Кем выдан
        /// </summary>
        public string? PassportPlace { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[]? Photo { get; set; }
        /// <summary>
        /// Тип пользователя
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Представитель студента
        /// </summary>
        public Representative? Representative { get; set; }
        /// <summary>
        /// Адрес проживания
        /// </summary>
        public Address? Address { get; set; }
        /// <summary>
        /// Информация о студенте
        /// </summary>
        public Student? Student { get; set; }
        /// <summary>
        /// Информация о преподавателе
        /// </summary>
        public Teacher? Teacher { get; set; }
        public Parent? Parent { get; set; }
    }
}
