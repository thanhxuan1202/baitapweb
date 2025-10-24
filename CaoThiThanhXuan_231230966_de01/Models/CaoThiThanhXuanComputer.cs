using System;
using System.Collections.Generic;

namespace CaoThiThanhXuan_231230966_de01.Models;

public partial class CaoThiThanhXuanComputer
{
    public int CaoThiThanhXuanComId { get; set; }

    public string CaoThiThanhXuanComName { get; set; } = null!;

    public decimal? CaoThiThanhXuanComPrice { get; set; }

    public string? CaoThiThanhXuanComImage { get; set; }

    public bool CaoThiThanhXuanComStatus { get; set; }
}
