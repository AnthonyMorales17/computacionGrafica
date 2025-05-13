using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CTrapezoidIsosceles
    {
        // Datos Miembro (Atributos). 

        //Base mayor del Trapecio.
        private float mMajorB;
        //Base menor del Trapecio.
        private float mMinorB;
        //Lado del trapecio.
        private float mSide;
        //Altura del trapecio.
        private float mHeight;
        //Perímetro del trapecio.
        private float mPerimeter;
        //Área del trapecio.
        private float mArea;

        // Funciones Miembro (Métodos).

        // Constructor sin parámetros.
        public CTrapezoidIsosceles()
        {
            mMajorB = 0.0f; mMinorB = 0.0f; mSide = 0.0f; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Lee los datos ingresados por el usuario desde los TextBox y los asigna a las variables internas.
        // Valida que todos los campos estén completos y sean valores numéricos válidos mayores a cero.
        public bool ReadData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtSide, TextBox txtHeight)
        {
            if (string.IsNullOrWhiteSpace(txtMajorBase.Text) ||
                string.IsNullOrWhiteSpace(txtMinorBase.Text) ||
                string.IsNullOrWhiteSpace(txtSide.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error");
                return false;
            }

            bool ok1 = float.TryParse(txtMajorBase.Text, out mMajorB);
            bool ok2 = float.TryParse(txtMinorBase.Text, out mMinorB);
            bool ok3 = float.TryParse(txtSide.Text, out mSide);
            bool ok4 = float.TryParse(txtHeight.Text, out mHeight);

            if (!ok1 || mMajorB <= 0) { ShowError(txtMajorBase, "base mayor"); return false; }
            if (!ok2 || mMinorB <= 0) { ShowError(txtMinorBase, "base menor"); return false; }
            if (!ok3 || mSide <= 0) { ShowError(txtSide, "lado igual"); return false; }
            if (!ok4 || mHeight <= 0) { ShowError(txtHeight, "altura"); return false; }

            //Para que el trapecio isósceles sea posible, cada lado igual (mSide) debe ser mayor
            //que la mitad de la diferencia entre las bases.
            float baseDiff = Math.Abs(mMajorB - mMinorB);
            float halfBaseDiff = baseDiff / 2.0f;

            if (mSide <= halfBaseDiff)
            {
                MessageBox.Show("El lado no es suficientemente largo para formar un trapecio isósceles con las bases dadas.", "Error");
                return false;
            }

            //Verifica que la altura no sea tan grande que rompa el triángulo isósceles lateral.
            float maxHeight = (float)Math.Sqrt((mSide * mSide) - (halfBaseDiff * halfBaseDiff));
            if (mHeight > maxHeight)
            {
                MessageBox.Show("La altura es demasiado grande para formar un trapecio isósceles con los lados dados.", "Error");
                return false;
            }

            return true;
        }

        // Muestra un mensaje de error en caso de que un campo tenga un valor inválido.
        private void ShowError(TextBox txt, string campo)
        {
            MessageBox.Show($"Ingrese un valor válido para {campo}.", "Error");
            txt.Focus();
        }

        // Función que calcula el área del trapecio isosceles.
        public void CalculateArea()
        {
            mArea = ((mMajorB + mMinorB) * mHeight) / 2;
        }

        // Función que calcula el perímetro del trapecio isosceles.
        public void CalculatePerimeter()
        {
            mPerimeter = mMajorB + mMinorB + ( 2 * mSide);
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimeter.Text = mPerimeter.ToString("0.00");
        }

        // Función que inicializa los datos y controles del trapecio. 
        public void InitializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtSide, TextBox txtHeight, TextBox txtArea, TextBox txtPerimeter)
        {
            txtMajorBase.Text = ""; txtMinorBase.Text = "";
            txtSide.Text = ""; txtHeight.Text = "";
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
