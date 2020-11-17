using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREM3_CodeFirst.Models
{
    public class Vehiculo
    {
        [Key]
        public int vehiculoID { get; set; }
        [Column(TypeName="nvarchar(10)")]
        [Required]
        [Display(Name ="PLACA")]
        public string vehiculoPlaca { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "MARCA")]
        public string vehiculoMarca { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "MODELO")]
        public string vehiculoModelo { get; set; }
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime vehiculoFecha { get; set; }
    }
}
