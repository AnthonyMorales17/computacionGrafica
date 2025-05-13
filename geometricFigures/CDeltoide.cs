using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CDeltoide
    {
        // Datos Miembro(Atributos). 

        //Lado Corto del Deltoide
        private float shortSide;
        //Lado Largo del Deltoide
        private float longSide;
        //Diagonal Mayor del Deltoide
        private float majorDiagonal;
        //Diagonal Menor del Deltoide
        private float minorDiagonal;
        //Area y perimetro del deltoide
        private float mArea, mPerimeter;

        // Constructor sin parámetros
        public CDeltoide()
        {
            shortSide = longSide = majorDiagonal = minorDiagonal = mArea = mPerimeter = 0;
        }

        // Valida que todos los campos estén completos y sean valores numéricos válidos
        public bool ReadData(TextBox txtShortSide, TextBox txtLongSide, TextBox txtMajorDiagonal,
                             TextBox txtMinorDiagonal)
        {
            if (string.IsNullOrWhiteSpace(txtShortSide.Text) ||
                string.IsNullOrWhiteSpace(txtLongSide.Text) ||
                string.IsNullOrWhiteSpace(txtMajorDiagonal.Text) ||
                string.IsNullOrWhiteSpace(txtMinorDiagonal.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error");
                return false;
            }

            bool ok1 = float.TryParse(txtShortSide.Text, out shortSide);
            bool ok2 = float.TryParse(txtLongSide.Text, out longSide);
            bool ok3 = float.TryParse(txtMajorDiagonal.Text, out majorDiagonal);
            bool ok4 = float.TryParse(txtMinorDiagonal.Text, out minorDiagonal);

            if (!ok1 || shortSide <= 0) return ShowError(txtShortSide, "Lado Corto");
            if (!ok2 || longSide <= 0) return ShowError(txtLongSide, "Lado Largo");
            if (!ok3 || majorDiagonal <= 0) return ShowError(txtMajorDiagonal, "Diagonal Mayor");
            if (!ok4 || minorDiagonal <= 0) return ShowError(txtMinorDiagonal, "Diagonal Menor");

            //Verificación de que si forma un deltoide 
            if (Math.Abs(shortSide - longSide) < 0.001f)
            {
                MessageBox.Show("Los lados cortos y largos no pueden ser iguales en un deltoide.", "Error");
                txtShortSide.Focus();
                return false;
            }

            if (minorDiagonal >= majorDiagonal)
            {
                MessageBox.Show("La diagonal menor debe ser más corta que la diagonal mayor.", "Error");
                txtMinorDiagonal.Focus();
                return false;
            }


            return true;
        }

        // Muestra un mensaje de error en caso de que un campo tenga un valor inválido.
        private bool ShowError(TextBox txt, string campo)
        {
            MessageBox.Show($"Ingrese un valor válido para {campo}.", "Error");
            txt.Focus();
            return false;
        }

        // Calcula el perímetro del deltoide.
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (shortSide + longSide);
        }

        // Calcula el área del deltoide usando las diagonales.
        public void CalculateArea()
        {
            mArea = (majorDiagonal * minorDiagonal) / 2;
        }

        // Muestra los resultados del área y perímetro calculados
        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimeter.Text = mPerimeter.ToString("0.00");
        }

        // Función que inicializa los datos y controles del deltoide.
        public void InitializeData(TextBox txtShortSide, TextBox txtLongSide, TextBox txtMajorDiagonal, 
                                    TextBox txtMinorDiagonal, TextBox txtArea, TextBox txtPerimeter)
        {
            txtShortSide.Text = "";
            txtLongSide.Text = "";
            txtMajorDiagonal.Text = "";
            txtMinorDiagonal.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtShortSide.Focus(); // Enfocamos el primer campo relevante
        }


        // Cierra el formulario actual.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
