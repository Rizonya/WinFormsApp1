using System;
using System.Collections.Generic;

namespace WinFormsApp1;

public partial class Услуги
{
    public string? ВидУслуги { get; set; }

    public decimal? ЦенаЗаКвМ { get; set; }

    public int? Id { get; set; }

    public virtual ICollection<Заказы> Заказыs { get; set; } = new List<Заказы>();

    public override string ToString()
    {
        return ВидУслуги;
    }
}
