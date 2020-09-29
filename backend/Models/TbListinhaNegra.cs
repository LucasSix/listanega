﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_listinha_negra")]
    public partial class TbListinhaNegra
    {
        [Key]
        [Column("id_lista_negra", TypeName = "int(11)")]
        public int IdListaNegra { get; set; }
        [Column("nm_individuo", TypeName = "varchar(100)")]
        public string NmIndividuo { get; set; }
        [Column("ds_motivo", TypeName = "varchar(200)")]
        public string DsMotivo { get; set; }
        [Column("dt_inclusao", TypeName = "datetime")]
        public DateTime? DtInclusao { get; set; }
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("ds_foto", TypeName = "varchar(100)")]
        public string DsFoto { get; set; }
    }
}
