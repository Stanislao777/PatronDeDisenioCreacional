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
		Console.WriteLine("anio: {0}", cocheFactory.obtenerAnioModelo());

		Chasis chasis = cocheFactory.fabricarChasis();
		Console.WriteLine("Peso del chasis: {0}", chasis.getPeso());
		
		Console.WriteLine("Material del chasis: {0}", chasis.getMaterial());

		Console.WriteLine("Clasificacion del chasis: {0}", chasis.getClasificacion());
	}	
}