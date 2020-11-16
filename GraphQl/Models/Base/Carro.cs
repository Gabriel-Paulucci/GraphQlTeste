using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Models.Base
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
    }
}
