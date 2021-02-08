﻿using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace DevIO.Business.Models
{
    public class Mes
    {
        public int MesId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Ganho> Ganhos { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }

    }
}
