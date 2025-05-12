using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    class CRhomboid
    {
        // Datos Miembro(Atributos). 

        //Base del romboide.
        private float mBase;
        //Altura del romboide.
        private float mHeight;
        //Lado del romboide.
        private float mSide;
        //Perímetro del romboide.
        private float mPerimeter;
        //Área del romboide.
        private float mArea;

        // Funciones Miembro (Métodos). 

        // Constructor sin parámetros.
        public CRhomboid()
        {
            mBase = 0.0f; mHeight = 0.0f; mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que lee los lados del tríangulo y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtSide)
        {
            if (string.IsNullOrWhiteSpace(txtBase.Text))
            {
                MessageBox.Show("La base no puede estar vacía.", "Error");
                txtBase.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("La altura no puede estar vacía.", "Error");
                txtHeight.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSide.Text))
            {
                MessageBox.Show("El lado no puede estar vacío.", "Error");
                txtSide.Focus();
                return false;
            }

            bool validBase = float.TryParse(txtBase.Text, out mBase);
            bool validHeight = float.TryParse(txtHeight.Text, out mHeight);
            bool validSide = float.TryParse(txtSide.Text, out mSide);

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

            if (!validSide || mSide <= 0)
            {
                MessageBox.Show("Ingrese un lado válido mayor a 0.", "Error");
                txtSide.Focus();
                return false;
            }

            return true;
        }

        // Función que calcula el perímetro del romboide.
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mBase + mSide);
        }
        // Función que calcula el área del romboide.
        public void CalculateArea()
        {
            mArea = mBase * mHeight;
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtArea, TextBox txtPerimeter)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimeter.Text = mPerimeter.ToString("0.00");
        }

        // Función que inicializa los datos y controles del romboide. 
        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtSide, TextBox txtArea, TextBox txtPerimeter)
        {
            txtBase.Text = ""; txtHeight.Text = ""; txtSide.Text = "";
            txtArea.Text = ""; txtPerimeter.Text = "";
            txtBase.Focus();
        }

        // Función para cerrar el formulario.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
