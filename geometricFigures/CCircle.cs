using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CCircle
    {
        // Datos Miembro (Atributos). 

        //Radio del círculo.
        private float mRadius;
        //Perímetro del círculo.
        private float mPerimeter;
        //Área del círculo.
        private float mArea;

        // Funciones Miembro (Métodos). 

        // Constructor sin parámetros.
        public CCircle()
        {
            mRadius = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que lee el radio del círculo y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtRadius)
        {
            //Verifica si el textBox esta vacío, es null o consta de espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtRadius.Text))
            {
                MessageBox.Show("El campo del radio no puede estar vacío.", "Error");
                // Mantiene el cursor titilando en una caja de texto. 
                txtRadius.Focus();
                return false;
            }


            bool isNumber = float.TryParse(txtRadius.Text, out mRadius);

            //Verifica 
            if (!isNumber || mRadius <= 0)
            {
                MessageBox.Show("Ingrese un número válido mayor a 0.", "Error");
                // Mantiene el cursor titilando en una caja de texto. 
                txtRadius.Focus();
                return false;
            }

            return true;
        }

        // Función que calcula el área del círculo
        public void CalculateArea()
        {
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        // Función que calcula el perímetro del círculo
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimeter.Text = mPerimeter.ToString("0.00");
        }

        // Función que inicializa los datos y controles del círculo. 
        public void InitializeData(TextBox txtRadius, TextBox txtArea, TextBox txtPerimeter)
        {
            txtRadius.Text = ""; txtArea.Text = ""; txtPerimeter.Text = "";
            // Mantiene el cursor titilando en una caja de texto. 
            txtRadius.Focus();
            mRadius = mArea = mPerimeter = 0.0f;
        }

        // Función para cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
