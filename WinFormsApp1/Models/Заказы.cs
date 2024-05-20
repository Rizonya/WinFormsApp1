using System;
using System.Collections.Generic;

namespace WinFormsApp1;

public partial class Заказы
{
    public int? Id { get; set; }

    public int? ВидУслуги { get; set; }

    public string? Заказчик { get; set; }

    public DateTime? Дата { get; set; }

    public DateTime? Время { get; set; }

    public string? Адрес { get; set; }

    public int? Площадь { get; set; }

    public decimal? Цена { get; set; }

    public virtual Услуги? ВидУслугиNavigation { get; set; }
}
