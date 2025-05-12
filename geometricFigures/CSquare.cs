using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CSquare
    {
        // Datos Miembro (Atributos). 

        //Lado del cuadrado.
        private float mSide;
        //Perímetro del cuadrado.
        private float mPerimeter;
        //Área del cuadrado.
        private float mArea;

        // Funciones Miembro (Métodos). 

        // Constructor sin parámetros.
        public CSquare()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que lee el lado del cuadrado y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtSide)
        {
            if (string.IsNullOrEmpty(txtSide.Text))
            {
                MessageBox.Show("El campo del lado no puede estar vacío", "Error");
                txtSide.Focus();
                return false;
            }

            bool isNumber = float.TryParse(txtSide.Text, out mSide);

            if(!isNumber || mSide <= 0)
            {
                MessageBox.Show("Ingrese un número válido mayor a 0.", "Error");
                txtSide.Focus();
                return false;
            }

            return true;
        }

        // Función que calcula el perímetro del cuadrado.
        public void CalculatePerimeter()
        {
            mPerimeter = 4 * mSide;
        }

        //Función que calcula el área del cuadrado.
        public void CalculateArea()
        {
            mArea = mSide * mSide;
        }

        //Función para mostrar el resultado del perímetro y el área.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Función que inicializa los datos y controles del cuadrado.
        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea)
        {
            txtSide.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            // Mantiene el cursor titilando en una caja de texto. 
            txtSide.Focus();
            mSide = mArea = mPerimeter = 0.0f;
        }

        // Función para cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
