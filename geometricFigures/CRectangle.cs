using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace geometricFigures
{
    class CRectangle
    {
        // Datos Miembro (Atributos). 

        //Base del rectángulo.
        private float mBase;
        //Altura del rectángulo.
        private float mHeight;
        //Perímetro del rectángulo.
        private float mPerimeter;
        //Área del rectángulo.
        private float mArea;

        // Funciones Miembro (Métodos).

        // Constructor sin parámetros.
        public CRectangle()
        {
            mBase = 0.0f; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que lee los lados del rectángulo y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtBase, TextBox txtHeight)
        {
            //Verifica si el textBox esta vacío, es null o consta de espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtBase.Text))
            {
                MessageBox.Show("El campo de la base no puede estar vacío.", "Error");
                txtBase.Focus();
                return false;
            }

            //Verifica si el textBox esta vacío, es null o consta de espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("El campo de la altura no puede estar vacío.", "Error");
                txtHeight.Focus();
                return false;
            }

            bool validBase = float.TryParse(txtBase.Text, out mBase);
            bool validHeight = float.TryParse(txtHeight.Text, out mHeight);

            if (!validBase || mBase <= 0)
            {
                MessageBox.Show("Ingrese una base válida mayor a 0.", "Error");
                txtBase.Focus();
                return false;
            }

            if (!validHeight || mHeight <= 0)
            {
                MessageBox.Show("Ingrese una altura válida mayor a 0.", "Error");
                txtHeight.Focus();
                return false;
            }

            return true;
        }

        // Función que calcula el área del rectángulo.
        public void CalculateArea()
        {
            mArea = mBase * mHeight;
        }

        // Función que calcula el perímetro del rectángulo.
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mBase + mHeight);
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimeter.Text = mPerimeter.ToString("0.00");
        }

        // Función que inicializa los datos y controles del rectángulo. 
        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtArea, TextBox txtPerimeter)
        {
            txtBase.Text = ""; txtHeight.Text = ""; txtArea.Text = ""; txtPerimeter.Text = "";
            txtBase.Focus();
        }

        // Función para cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
