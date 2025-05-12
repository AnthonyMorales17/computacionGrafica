using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CTrapezoid
    {
        // Datos Miembro (Atributos). 

        //Lado A del trapecio.
        private float mSideA;
        //Lado B del trapecio.
        private float mSideB;
        //Base mayor del Trapecio.
        private float mMajorB;
        //Base menor del Trapecio.
        private float mMinorB;
        //Altura del trapecio.
        private float mHeight;
        //Perímetro del trapecio.
        private float mPerimeter;
        //Área del trapecio.
        private float mArea;

        // Funciones Miembro (Métodos).

        // Constructor sin parámetros.
        public CTrapezoid()
        {
            mMajorB = 0.0f; mMinorB = 0.0f; mSideA = 0.0f; mSideB = 0.0f; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Lee los datos ingresados por el usuario desde los TextBox y los asigna a las variables internas.
        // Valida que todos los campos estén completos y sean valores numéricos válidos mayores a cero.
        public bool ReadData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtSideA, TextBox txtSideB, TextBox txtHeight)
        {
            if (string.IsNullOrWhiteSpace(txtMajorBase.Text) || string.IsNullOrWhiteSpace(txtMinorBase.Text) ||
                 string.IsNullOrWhiteSpace(txtSideA.Text) || string.IsNullOrWhiteSpace(txtSideB.Text) || string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error");
                return false;
            }

            bool validMajorB = float.TryParse(txtMajorBase.Text, out mMajorB);
            bool validMinorB = float.TryParse(txtMinorBase.Text, out mMinorB);
            bool validSideA = float.TryParse(txtSideA.Text, out mSideA);
            bool validSideB = float.TryParse(txtSideB.Text, out mSideB);
            bool validHeight = float.TryParse(txtHeight.Text, out mHeight);

            if (!validMajorB || mMajorB <= 0) { ShowError(txtMajorBase, "base mayor"); return false; }
            if (!validMinorB || mMinorB <= 0) { ShowError(txtMinorBase, "base menor"); return false; }
            if (!validSideB || mSideB <= 0) { ShowError(txtSideB, "lado B"); return false; }
            if (!validSideA || mSideA <= 0) { ShowError(txtSideA, "lado A"); return false; }
            if (!validHeight || mHeight <= 0) { ShowError(txtHeight, "altura"); return false; }

            return true;
        }

        // Muestra un mensaje de error en caso de que un campo tenga un valor inválido.
        private void ShowError(TextBox txt, string campo)
        {
            MessageBox.Show($"Ingrese un valor válido para {campo}.", "Error");
            txt.Focus();
        }

        // Función que calcula el área del trapecio.
        public void CalculateArea()
        {
            mArea = ((mMajorB + mMinorB) * mHeight) / 2;
        }

        // Función que calcula el perímetro del trapecio.
        public void CalculatePerimeter()
        {
            mPerimeter = mMajorB + mMinorB + mSideA + mSideB;
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Función que inicializa los datos y controles del trapecio. 
        public void InitializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtSideA, TextBox txtSideB, TextBox txtArea, TextBox txtPerimeter)
        {
            txtMajorBase.Text = ""; txtMinorBase.Text = ""; 
            txtSideA.Text = ""; txtSideB.Text = ""; txtHeight.Text = "";
            txtArea.Text = ""; txtPerimeter.Text = "";
            txtMajorBase.Focus();
        }

        // Función para cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
