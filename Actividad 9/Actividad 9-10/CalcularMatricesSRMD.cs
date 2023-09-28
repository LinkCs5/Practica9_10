using System;
namespace CalcularMatrices;

public class OperracionesMatrices
{
	public static double[,] SumarMatrices(double[,] matriz, double[,] matriz_2)
	{
		double[,] resultado = new double[2, 2];

		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
                resultado[i, j] = matriz[i, j] + matriz_2[i, j]

            }
        }
		return resultado;
	}

    public static double[,] RestarMatrices(double[,] matriz, double[,] matriz_2)
    {
        double[,] resultado = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz[i, j] - matriz_2[i, j];
            }
        }

        return resultado;
    }
    public static double[,] MultiplicarMatrices(double[,] matriz, double[,] matriz_2)
    {
        double[,] resultado = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz[i, j] * matriz_2[i, j];
            }
        }

        return resultado;
    }
    public static double[,] DividirMatrices(double[,] matriz, double[,] matriz_2)
    {
        double[,] resultado = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matriz[i, j] / matriz_2[i, j];
            }
        }

        return resultado;
    }
}
}
