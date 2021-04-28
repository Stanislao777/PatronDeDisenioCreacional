using System;

class MainClass
{
	public static CocheFactory getCocheFactory(int numero)
	{
		switch(numero)
		{
			case 1995: return new Modelo1995CocheFactory();
			case 2020: return new Modelo2020CocheFactory();
			default: return null;
		}		
	}
	
	public static void Main (string[] args)
	{
		CocheFactory cocheFactory = getCocheFactory(2020);
		Console.WriteLine("////////////////////////");
		Console.WriteLine("////   anio: {0}   ////", cocheFactory.obtenerAnioModelo());
		Console.WriteLine("////////////////////////");

		Chasis chasis = cocheFactory.fabricarChasis();
		
		Console.WriteLine("Peso del chasis: {0}", chasis.getPeso());
		
		Console.WriteLine("Material del chasis: {0}", chasis.getMaterial());

		Console.WriteLine("Clasificacion del chasis: {0}", chasis.getClasificacion());

		Console.WriteLine("==============================");

		Rueda rueda = cocheFactory.fabricarRueda();

		Console.WriteLine("Diametro de la rueda: {0}", rueda.getDiametro());
		
		Console.WriteLine("Indice de cargas: {0}", rueda.getIndiceDeCarga());

		Console.WriteLine("Indice de velocidad: {0}", rueda.getIndiceDeVelocidad());

		Console.WriteLine("==============================");

		Motor motor = cocheFactory.fabricarMotor();

		Console.WriteLine("Tipo de rueda: {0}", motor.getTipo());

		Console.WriteLine("Cantidad de cilindros: {0}", motor.getCantidadCilindros());

		Console.WriteLine("Disposicion de cilindros: {0}", motor.getDisposicionCilindros());
	}	
}