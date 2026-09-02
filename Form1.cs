using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARSIAL_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


class Program
{
    static void Main()
    {
        // Matriz: Desde, Hasta, Precio, Adicional
        double[,] tabla =
        {
            { 0.01,       500,       1.5,  0 },
            { 500.01,     1000,      1.5,  3 },
            { 1000.01,    2000,      3,    3 },
            { 2000.01,    3000,      6,    3 },
            { 3000.01,    6000,      9,    2 },
            { 8000.01,    18000,     15,   2 },
            { 18000.01,   30000,     39,   2 },
            { 30000.01,   60000,     63,   1 },
            { 60000.01,   100000,    93,   0.8 },
            { 100000.01,  200000,    125,  0.7 },
            { 200000.01,  300000,    195,  0.6 },
            { 300000.01,  400000,    255,  0.45 },
            { 400000.01,  500000,    300,  0.4 },
            { 500000.01,  1000000,   340,  0.30 },
            { 1000000.01, 99999999,  490,  0.18 }
        };

        // Pedir el monto
        Console.Write("Ingrese el monto de la actividad económica: ");
        double monto = double.Parse(Console.ReadLine());

        double impuesto = 0;
        bool encontrado = false;

        // Buscar el rango correspondiente
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            if (monto >= tabla[i, 0] && monto <= tabla[i, 1])
            {
                double desde = tabla[i, 0];
                double precio = tabla[i, 2];
                double adicional = tabla[i, 3];

                // Calcular impuesto
                impuesto = ((monto - desde) / 1000) * precio + adicional;

                encontrado = true;
                break;
            }
        }

        // Mostrar resultado
        if (encontrado)
        {
            Console.WriteLine("El impuesto a pagar es: $"
                + impuesto.ToString("F2"));
        }
        else
        {
            Console.WriteLine("El monto no se encuentra en la tabla.");
        }
    }
}
