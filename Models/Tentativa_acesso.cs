using System;
using System.ComponentModel.DataAnnotations;

namespace TelecallUnisuamCRUD.Models
{
    public class Tentativa_acesso
    {
        [Display(Name = "Id")]
        public int tent_id { get; set; }
        [Display(Name = "Data")]
        public DateTime tent_data { get; set; }
        [Display(Name = "Hora")]
        public DateTime tent_hora { get; set; }
        [Display(Name = "IP")]
        public string tent_ip { get; set; }
        [Display(Name = "Latitude")]
        public string tent_lat { get; set; }
        [Display(Name = "Longitude")]
        public string tent_lon { get; set; }
        [Display(Name = "Id Autenticação")]
        public int tipo_aut_id { get; set; }
        [Display(Name = "Id Autenticou")]
        public int autenticou_id { get; set; }
        [Display(Name = "Id Usuário")]
        public int tent_usu_id { get; set; }
    }
}