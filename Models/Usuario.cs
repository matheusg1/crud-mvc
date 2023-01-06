using System;

namespace TelecallUnisuamCRUD.Models
{
    public class Usuario
    {
        public int usu_id { get; set; }
        public string usu_nome { get; set; }
        public DateTime nascimento { get; set; }
        public string usu_nomemat { get; set; }
        public string usu_cpf { get; set; }
        public string usu_celular { get; set; }
        public string usu_fixo { get; set; }
        public string usu_endereco { get; set; }
        public string tipo_usu_id { get; set; }
        public string usu_login { get; set; }
        public string usu_senha { get; set; }
    }
}
