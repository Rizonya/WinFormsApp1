using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Заказы
{
    public int Id { get; set; }

    public int? ВидУслуги { get; set; }

    public string? Заказчик { get; set; }

    public DateTime? Дата { get; set; }

    public DateTime? Время { get; set; }

    public string? Адрес { get; set; }

    public int? Площадь { get; set; }

    public int? Цена { get; set; }

    public string? ВыполненоИлиНет { get; set; }
}
