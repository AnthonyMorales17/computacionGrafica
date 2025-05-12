using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CTriangle
    {
        // Datos Miembro (Atributos). 

        //Lado A del tríangulo.
        private float mSideA;
        //Lado B del tríangulo.
        private float mSideB;
        //Lado C del tríangulo.
        private float mSideC;
        //Perímetro del tríangulo.
        private float mPerimeter;
        //Área del tríangulo.
        private float mArea;

        // Funciones Miembro (Métodos). 

        // Constructor sin parámetros.
        public CTriangle()
        {
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que lee los lados del tríangulo y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC)
        {
            //Verifica si el textBox esta vacío, es null o consta de espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtSideA.Text) || string.IsNullOrWhiteSpace(txtSideB.Text) || string.IsNullOrWhiteSpace(txtSideC.Text))
            {
                MessageBox.Show("El lado del tríangulo no puede estar vacío.", "Error");
                txtSideA.Focus();
                return false;
            }

            bool validA = float.TryParse(txtSideA.Text, out mSideA);
            bool validB = float.TryParse(txtSideB.Text, out mSideB);
            bool validC = float.TryParse(txtSideC.Text, out mSideC);

            if (!validA || !validB || !validC || mSideA <= 0 || mSideB <= 0 || mSideC <= 0)
            {
                MessageBox.Show("Todos los lados deben ser números válidos mayores a 0.", "Error");
                txtSideA.Focus(); 
                return false;
            }

            // Validación de la desigualdad triangular
            if (mSideA + mSideB <= mSideC || mSideA + mSideC <= mSideB || mSideB + mSideC <= mSideA)
            {
                MessageBox.Show("Los lados no forman un triángulo válido.", "Error");
                return false;
            }

            return true;
        }

        // Función que calcula el perímetro del tríangulo.
        public void CalculatePerimeter()
        {
            mPerimeter = mSideA + mSideB + mSideC;
        }

        // Función que calcula el área del tríangulo.
        public void CalculateArea()
        {
            //Calculo el semiperímetro del tríangulo.
            float s = mPerimeter / 2.0f;
            //Utilizo la fórumla de Herón para determinar el Área del tríangulo. 
            mArea = (float)Math.Sqrt(s * (s - mSideA) * (s - mSideB) * (s - mSideC));
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Función que inicializa los datos y controles del tríangulo. 
        public void InitializeData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC, TextBox txtPerimeter, TextBox txtArea)
        {
            txtSideA.Text = ""; txtSideB.Text = ""; txtSideC.Text = ""; txtArea.Text = ""; txtPerimeter.Text = "";
            // Mantiene el cursor titilando en una caja de texto. 
            txtSideA.Focus();
            mSideA = mSideB = mSideC = mArea = mPerimeter = 0.0f;
        }

        // Función para cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
