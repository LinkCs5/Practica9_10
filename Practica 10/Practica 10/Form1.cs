using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10
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

        private void btnGenrarMatriz_Click(object sender, EventArgs e)
        {
                resultado.ReadOnly = true;
            CrearMatriz crearMatriz = new CrearMatriz();
            if (int.TryParse(matrizText.Text, out int n) && n > 0) 
            {
                int[,] matriz = crearMatriz.GenerarMatriz(n);
                crearMatriz.MostrarMatriz(matriz, resultado);
            }
            else
            {
                MessageBox.Show("Ingrese un tamaño válido para la matriz.");
            }
        }
    }

    public class CrearMatriz
    {
        public int[,] GenerarMatriz(int n)
        {
            int[,] matriz = new int[n, n];
            for(int i = 0; i < n;i ++)
            {
                for (int j = 0; j< n; j++)
                {
                    matriz[i,j] = (i == j)? 1 : 0;
                }
            }
            return matriz;
        }

        public void MostrarMatriz(int[,] matriz, TextBox matrizText)
        {
            int n = matriz.GetLength(0);
            matrizText.Clear();

            for(int i = 0; i < n; i ++)
            {
                for (int j = 0; j < n; j ++)
                {
                    matrizText.Text += matriz[i, j] + " ";

                }
                matrizText.Text += Environment.NewLine;
            }
        }
    }
}
