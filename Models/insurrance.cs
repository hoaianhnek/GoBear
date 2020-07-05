using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace GoBear.Models
{
    public class insurrance
    {
        public string MaBH { get; set; }
        public string TenBH { get; set; }
        public float Price { get; set; }
        public float rate { get; set; }
        public string buyonline { get; set; }
        public string regula_age { get; set; }
        public string define_family { get; set; }
        public float repatriation { get; set; }
        public string hightlight { get; set; }
        public float accident_myself { get; set;}
        public float foreign_medical { get; set; }
        [AllowNull]
        public float? patients_relative { get; set; }
        public string subsidize { get; set; }
    }
}
