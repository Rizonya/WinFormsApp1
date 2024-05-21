using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Услуги
{
    public string? ВидУслуги { get; set; }

    public int? ЦенаЗаКвМ { get; set; }

    public int Id { get; set; }

    public override string ToString()
    {
        return ВидУслуги;
    }
}
