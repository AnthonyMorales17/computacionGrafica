using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    public abstract class CRegularPolygon
    {
        // Datos Miembro (Atributos). 

        //Número de lados del polígono.
        protected int mSides;         
        //Radio del polígono.
        protected float mRadius;
        //Perímetro del polígono.
        protected float mPerimeter;
        //Área del polígono.
        protected float mArea;

        // Constructor con parámetros.
        protected CRegularPolygon(int sides)
        {
            this.mSides = sides;
            mPerimeter = mArea = mRadius = 0;
        }

        // Función que lee el radio del poligono y verifica que sea un valor válido. 
        public bool ReadData(TextBox txtRadius)
        {
            //Verifica si el textBox esta vacío, es null o consta de espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtRadius.Text))
            {
                MessageBox.Show("El campo del radio no puede estar vacío.", "Error");
                txtRadius.Focus();
                return false;
            }

            bool isNumber = float.TryParse(txtRadius.Text, out mRadius);
            if (!isNumber || mRadius <= 0)
            {
                MessageBox.Show("Ingrese un número válido mayor a 0.", "Error");
                txtRadius.Focus();
                return false;
            }

            return true;
        }

        //Función que calcula el perímetro del poligono
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * mSides * mRadius * (float)Math.Sin(Math.PI / mSides);
        }

        //Función que calcula el área del poligono
        public void CalculateArea()
        {
            mArea = ((2 * mSides * mRadius * (float)Math.Sin(Math.PI / mSides)) * (mRadius * (float)Math.Cos(Math.PI / mSides))) / 2;
            //mArea = (mSides * mSides * mRadius / 2) * (float)Math.Sin((2 * Math.PI) / mSides);
        }

        //Función para mostrar el resultado del área y perímetro.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Función que inicializa los datos y controles del tríangulo. 
        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea)
        {
            txtRadius.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            txtRadius.Focus();
            mRadius = mPerimeter = mArea = 0.0f;
        }

        //Función para cerrar el formulario.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
