namespace VixEng.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Beneficios
    {
        public long id { get; set; }

        [Display(Name = "Funcion�rio")]
        public long id_funcionario { get; set; }

        [Display(Name = "Benef�cio")]
        public int id_tipo_beneficio { get; set; }

        [Display(Name = "Observa��o")]
        public string observacao { get; set; }

        public virtual Funcionarios Funcionarios { get; set; }

        [Display(Name = "Beneficio")]
        public virtual Tipo_Beneficio Tipo_Beneficio { get; set; }
    }
}
