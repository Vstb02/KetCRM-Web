using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Domain.Entities
{
    /// <summary>
    /// Адресс проживания пользователя
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
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

        /// <summary>
        /// Пользователь, которому принадлежит адрес
        /// </summary>
        public Guid PersonId { get; set; }
    }
}
