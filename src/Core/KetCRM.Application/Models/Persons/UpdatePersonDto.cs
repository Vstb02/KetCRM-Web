using KetCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models.Persons
{
    public class UpdatePersonDto
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Display(Name = "Имя")]
        [MaxLength(50)]
        public string? Name { get; set; } = string.Empty;

        /// <summary>
        /// Фамилия
        /// </summary>
        [Display(Name = "Фамилия")]
        [MaxLength(50)]
        public string? Surname { get; set; } = string.Empty;

        /// <summary>
        /// Отчество
        /// </summary>
        [Display(Name = "Отчество")]
        [MaxLength(50)]
        public string? Patronymic { get; set; } = string.Empty;

        /// <summary>
        /// Пол
        /// </summary>
        [Display(Name = "Пол")]
        [Required]
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [Display(Name = "Дата рождения")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        [Display(Name = "Адрес почты")]
        [MaxLength(100)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес электронной почты")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        [Display(Name = "Номер телефона")]
        [MaxLength(11)]
        [MinLength(10)]
        [RegularExpression(@"[0-9]", ErrorMessage = "Некорректный номер телефона")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Номер СНИЛСа
        /// </summary>
        [Display(Name = "Снилс")]
        [RegularExpression(@"[0-9-]")]
        [MaxLength(11)]
        [MinLength(11)]
        public string? Snils { get; set; }

        /// <summary>
        /// Номер страховки
        /// </summary>
        [Display(Name = "Номер страховки")]
        [RegularExpression(@"[0-9-]")]
        [MaxLength(30)]
        public string? InsuranceNumber { get; set; }

        /// <summary>
        /// Серия паспорта
        /// </summary>
        [Display(Name = "Серия паспорта")]
        [RegularExpression(@"[0-9-]")]
        [MaxLength(4)]
        [MinLength(4)]
        public string? PassportSeries { get; set; }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        [Display(Name = "Номер паспорта")]
        [RegularExpression(@"[0-9-]")]
        [MaxLength(6)]
        [MinLength(6)]
        public string? PassportNumber { get; set; }

        /// <summary>
        /// Дата выдачи паспорта
        /// </summary>
        [Display(Name = "Дата выдачи паспорта")]
        [MaxLength(400)]
        public DateTime? PassportDate { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        [Display(Name = "Кем выдан")]
        [MaxLength(1000)]
        public string? PassportPlace { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        [Display(Name = "Комментарий")]
        public string? Comment { get; set; }

        /// <summary>
        /// Фото
        /// </summary>
        [Display(Name = "Фото")]
        public byte[]? Photo { get; set; }

        /// <summary>
        /// Роль
        /// </summary>
        [Display(Name = "Роль")]
        public Role Role { get; set; }
        /// <summary>
        /// Страна
        /// </summary>
        public string? Country { get; set; }
        /// <summary>
        /// Область
        /// </summary>
        public string? Region { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public string? Street { get; set; }
        /// <summary>
        /// Дом
        /// </summary>
        public string? House { get; set; }
        /// <summary>
        /// Номер квартиры
        /// </summary>
        public string? Flat { get; set; }
        /// <summary>
        /// Фактический адрес
        /// </summary>
        public bool? ActualAddress { get; set; }
    }
}
