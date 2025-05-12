using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CEllipse
    {
        // Datos Miembro (Atributos). 

        //Semieje mayor de la elipse.
        private float majorAxis;
        //Semieje menor de la elipse.
        private float minorAxis;
        //Área de la elipse.
        private float mArea;
        //Perímetro de la elipse.
        private float mPerimeter;

        // Funciones Miembro (Métodos). 

        // Constructor sin parámetros.
        public CEllipse()
        {
            majorAxis = 0; minorAxis = 0; mArea = 0; mPerimeter = 0;
        }

        // Función que lee el semieje mayor y menor de la elipse y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtMajorSemiAxis, TextBox txtMinorSemiAxis)
        {
            if (string.IsNullOrEmpty(txtMajorSemiAxis.Text))
            {
                MessageBox.Show("El campo del semieje mayor no puede estar vacío.", "Error");
                txtMajorSemiAxis.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtMinorSemiAxis.Text))
            {
                MessageBox.Show("El campo del semieje menor no puede estar vacío.", "Error");
                txtMinorSemiAxis.Focus();
                return false;
            }

            bool isMajorValid = float.TryParse(txtMajorSemiAxis.Text, out majorAxis);
            bool isMinorValid = float.TryParse(txtMinorSemiAxis.Text, out minorAxis);

            if (!isMajorValid || majorAxis <= 0)
            {
                MessageBox.Show("Ingrese un número válido mayor que 0 para el semieje mayor.", "Error");
                txtMajorSemiAxis.Focus();
                return false;
            }

            if (!isMinorValid || minorAxis <= 0)
            {
                MessageBox.Show("Ingrese un número válido mayor que 0 para el semieje menor.", "Error");
                txtMinorSemiAxis.Focus();
                return false;
            }

            return true;
        }

        //Función para calcular el área de la elipse.
        public void CalculateArea()
        {
            mArea = (float)(Math.PI * majorAxis * minorAxis);
        }

        //Función para calcular el perímetro (aproximado por fórmula de Ramanujan).
        public void CalculatePerimeter()
        {
            float h = (float)Math.Pow((majorAxis - minorAxis), 2) / (float)Math.Pow((majorAxis + minorAxis), 2);
            mPerimeter = (float)(Math.PI * (majorAxis + minorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Función que inicializa los datos y controles del círculo. 
        public void InitializeData(TextBox txtMajorSemiAxis, TextBox txtMinorSemiAxis, TextBox txtPerimeter, TextBox txtArea)
        {
            txtMajorSemiAxis.Text = ""; txtMinorSemiAxis.Text = ""; txtArea.Text = ""; txtPerimeter.Text = "";
            // Mantiene el cursor titilando en una caja de texto. 
            txtMajorSemiAxis.Focus();
            majorAxis = minorAxis = mArea = mPerimeter = 0.0f;
        }

        // Función para cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
