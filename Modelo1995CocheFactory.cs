class Modelo1995CocheFactory : CocheFactory
{
	public Chasis fabricarChasis()
	{
		return new Modelo1995Chasis();
	}
	public Rueda fabricarRueda()
	{
		return new Modelo1995Rueda();
	}
	public Motor fabricarMotor()
	{
		return new Modelo1995Motor();
	}
	public int obtenerAnioModelo()
	{
		return 1995;
	}
}