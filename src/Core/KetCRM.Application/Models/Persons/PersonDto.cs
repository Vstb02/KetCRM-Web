using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Persons
{
    public class PersonDto
    {
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
        public Gender Gender { get; set; }

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
    }
}
