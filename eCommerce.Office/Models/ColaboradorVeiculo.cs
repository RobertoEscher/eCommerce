using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Office.Models
{
    public class ColaboradorVeiculo
    {
        public int ColaboradorId { get; set; }
        public int VeiculoId { get; set; }

        public  DateTimeOffset DataInicioDeVinculo { get; set; }


        public Colaborador Colaborador { get; set; } = null!;
        public Veiculo Veiculo { get; set; } = null!;

    }
}
