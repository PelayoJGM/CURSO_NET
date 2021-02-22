using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Nomina
	{
	private int diasLaborados;
		public int DiasLaborados { get; set; }

		//METODO PARA CALCULAR LA NOMINA
		public decimal CalcularNomina (int diasLab, decimal valorDia)
		{
			decimal totalSalario = diasLab * valorDia;
			return totalSalario;
		}

	}
}

