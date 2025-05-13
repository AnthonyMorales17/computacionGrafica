using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CRhombus
    {
        // Datos Miembro (Atributos). 

        //Lado del rombo.
        private float mSide;
        //Diagonal Mayor del rombo.
        private float mMajorD;
        //Diagonal Menor del rombo.
        private float mMinorD;
        //Perímetro del rombo.
        private float mPerimeter;
        //Área del rombo.
        private float mArea;

        // Funciones Miembro (Métodos). 

        // Constructor sin parámetros.
        public CRhombus()
        {
            mSide = 0.0f; mMajorD = 0.0f; mMinorD = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que lee los datos del rombo y verifica que sean un valor válido.
        public bool ReadData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal, TextBox txtSide)
        {
            if (string.IsNullOrWhiteSpace(txtMajorDiagonal.Text))
            {
                MessageBox.Show("La diagonal mayor no puede estar vacía.", "Error");
                txtMajorDiagonal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMinorDiagonal.Text))
            {
                MessageBox.Show("La diagonal menor no puede estar vacía.", "Error");
                txtMinorDiagonal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSide.Text))
            {
                MessageBox.Show("El lado no puede estar vacío.", "Error");
                txtSide.Focus();
                return false;
            }

            bool validMajor = float.TryParse(txtMajorDiagonal.Text, out mMajorD);
            bool validMinor = float.TryParse(txtMinorDiagonal.Text, out mMinorD);
            bool validSide = float.TryParse(txtSide.Text, out mSide);

            if (!validMajor || mMajorD <= 0)
            {
                MessageBox.Show("Ingrese una diagonal mayor válida mayor que 0.", "Error");
                txtMajorDiagonal.Focus();
                return false;
            }

            if (!validMinor || mMinorD <= 0)
            {
                MessageBox.Show("Ingrese una diagonal menor válida mayor que 0.", "Error");
                txtMinorDiagonal.Focus();
                return false;
            }

            if (!validSide || mSide <= 0)
            {
                MessageBox.Show("Ingrese un lado válido mayor que 0.", "Error");
                txtSide.Focus();
                return false;
            }

            //Para que exista el rombo con diagonales dadas, el lado debe cumplir con el Teorema de Pitágoras
            float halfMajor = mMajorD / 2.0f;
            float halfMinor = mMinorD / 2.0f;
            float expectedSide = (float)Math.Sqrt(halfMajor * halfMajor + halfMinor * halfMinor);
            //Valido que el valor de mSide este muy cerca del valor calculado (expectedSide)
            if (Math.Abs(mSide - expectedSide) > 0.01f)
            {
                MessageBox.Show("El valor del lado no es coherente con las diagonales. Verifique los datos.", "Error");
                txtSide.Focus();
                return false;
            }

            return true;
        }

        // Función que calcula el área del rombo.
        public void CalculateArea()
        {
            mArea = (mMajorD * mMinorD) / 2;
        }

        // Función que calcula el perímetro del rombo.
        public void CalculatePerimeter()
        {
            mPerimeter = 4 * mSide;
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimeter.Text = mPerimeter.ToString("0.00");
        }

        // Función que inicializa los datos y controles del trapecio. 
        public void InitializeData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal, TextBox txtSide, TextBox txtArea, TextBox txtPerimeter)
        {
            txtMajorDiagonal.Text = ""; txtMinorDiagonal.Text = ""; txtSide.Text = "";
            txtArea.Text = ""; txtPerimeter.Text = "";
            txtMajorDiagonal.Focus();
        }

        // Función para cerrar el formulario
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
