class Modelo2020CocheFactory : CocheFactory
{
	public Chasis fabricarChasis()
	{
		return new Modelo2020Chasis();
	}
	public Rueda fabricarRueda()
	{
		return new Modelo2020Rueda();
	}
	public Motor fabricarMotor()
	{
		return new Modelo2020Motor();
	}
	public int obtenerAnioModelo()
	{
		return 2020;
	}
}