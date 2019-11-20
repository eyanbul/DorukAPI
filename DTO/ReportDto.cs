using System;
using System.Collections.Generic;

namespace DTO
{
    public class ReportDto
    {
        public int OrderId { get; set; }
        public string Reason { get; set; }
        public double Duration { get; set; }
    }
}
