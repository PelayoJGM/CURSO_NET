using System;

public class Nomina
{
	private int diasLaborados; 
	public indexer DiasLaborados { get; set; }
	
	//METODO PARA CALCULAR LA NOMINA
	public decimal CalcularNomina (int diasLab, decimal valorDia)
    {
		decimal totalSalario = diasLab * valorDia;
		return totalSalario;
    }

}
