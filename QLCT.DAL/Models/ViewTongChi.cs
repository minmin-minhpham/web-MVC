﻿using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class ViewTongChi
    {
        public string HoTen { get; set; }
        public int? SoTien { get; set; }
        public DateTime? NgayChi { get; set; }
        public string TenNd { get; set; }
        public int MaTk { get; set; }
    }
}
