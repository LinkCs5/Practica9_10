using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcularBotton_Click(object sender, EventArgs e)
        {
            
            double[,] matriz = new double[2, 2];
            double[,] matriz_2 = new double[2, 2];

            matriz[0, 0] = Convert.ToDouble(valor_1.Text);
            matriz[0,1] = Convert.ToDouble(valor_2.Text);
            matriz[1, 0] = Convert.ToDouble(valor_3.Text);
            matriz[1, 1] = Convert.ToDouble(valor_4.Text);

            matriz_2[0,0] = Convert.ToDouble(valor_5.Text);
            matriz_2[0, 1] = Convert.ToDouble(valor_6.Text);
            matriz_2[1, 0] = Convert.ToDouble(valor_7.Text);
            matriz_2[1,1] = Convert.ToDouble(valor_8.Text);

            double[,] sumarMatrices = OperacionesMatrices.SumarMatrices(matriz, matriz_2);
            double[,] restaMatrices = OperacionesMatrices.RestarMatrices(matriz, matriz_2);
            double[,] multiplicarMatrices = OperacionesMatrices.MultiplicarMatrices(matriz, matriz_2);
            double[,] dividirMatrices = OperacionesMatrices.DividirMatrices(matriz, matriz_2);

            MostrarMatrizEnTextBox(respuesta, sumarMatrices);
            MostrarMatrizEnTextBox(respuestaMulti, multiplicarMatrices);
            MostrarMatrizEnTextBox(respuestaDivi, dividirMatrices);
            MostrarMatrizEnTextBox(respuestaResta, restaMatrices);

        }

        private void MostrarMatrizEnTextBox(TextBox respuesta, double[,]matriz )
        {
            respuesta.ReadOnly = true;
            respuesta.Text = $"{matriz[0,0]} | {matriz[0, 1]} | {matriz[1,0]} | {matriz[1, 1]}";
        }

        private void valor_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void respuestaResta_TextChanged(object sender, EventArgs e)
        {

        }

        private void respuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarBotton_Click(object sender, EventArgs e)
        {
            valor_1.Clear();
            valor_2.Clear();
            valor_3.Clear();
            valor_4.Clear();
            valor_5.Clear();
            valor_6.Clear();
            valor_7.Clear();
            valor_8.Clear();

            respuesta.Clear();
            respuestaDivi.Clear();
            respuestaResta.Clear();
            respuestaMulti.Clear();
        }
    }
    public class OperacionesMatrices
    {
        public static double[,] SumarMatrices(double[,] matriz, double[,] matriz_2)
        {
            double[,] resultado = new double[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i, j] = matriz[i, j] + matriz_2 [i, j];
    
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

