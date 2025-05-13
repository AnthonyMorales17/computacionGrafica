    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace geometricFigures
    {
        class CTrapezoide
        {
            // Datos Miembro (Atributos). 
            //Lados del Trapezoide
            private float mSideA, mSideB;
            //Base y altura del trapezoide
            private float mBase1, mBase2, mHeight;
            //Perimetro y area del trapezoide.
            private float mArea, mPerimeter;

            // Funciones Miembro (Métodos).

            // Constructor sin parámetros.
            public CTrapezoide()
            {
                mSideA = 0.0f; mSideB = 0.0f; mBase1 = 0.0f; mBase2 = 0.0f ; mHeight = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            }

            // Lee los datos ingresados por el usuario desde los TextBox y los asigna a las variables internas.
            // Valida que todos los campos estén completos y sean valores numéricos válidos mayores a cero.
            public bool ReadData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtSideA, TextBox txtSideB, TextBox txtHeight)
            {
                if (string.IsNullOrWhiteSpace(txtMajorBase.Text) || string.IsNullOrWhiteSpace(txtMinorBase.Text) ||
                    string.IsNullOrWhiteSpace(txtSideA.Text) || string.IsNullOrWhiteSpace(txtSideB.Text) ||
                    string.IsNullOrWhiteSpace(txtHeight.Text))
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error");
                    return false;
                }

                bool ok1 = float.TryParse(txtMajorBase.Text, out mBase1);
                bool ok2 = float.TryParse(txtMinorBase.Text, out mBase2);
                bool ok3 = float.TryParse(txtHeight.Text, out mHeight);
                bool ok4 = float.TryParse(txtSideA.Text, out mSideA);
                bool ok5 = float.TryParse(txtSideB.Text, out mSideB);

                if (!ok1 || mBase1 <= 0) return ShowError(txtMajorBase, "Base mayor");
                if (!ok2 || mBase2 <= 0) return ShowError(txtMinorBase, "Base menor");
                if (!ok3 || mHeight <= 0) return ShowError(txtHeight, "Altura");
                if (!ok4 || mSideA <= 0) return ShowError(txtSideA, "Lado A");
                if (!ok5 || mSideB <= 0) return ShowError(txtSideB, "Lado B");

            // Validación geométrica que consiste en que la suma  de los lados oblicuos (A + B)
            // debe ser mayor que la diferencia absoluta de las bases (|Base1 - Base2|).
            float halfDiff = Math.Abs(mBase1 - mBase2) / 2;
            float minSideLength = (float)Math.Sqrt(mHeight * mHeight + halfDiff * halfDiff);

            if (mSideA < minSideLength || mSideB < minSideLength)
            {
                MessageBox.Show("Los lados son demasiado cortos para formar una figura con las bases y altura indicadas.");
                return false;
            }

            return true;
            }

            // Muestra un mensaje de error y enfoca el TextBox donde se produjo el error.
            private bool ShowError(TextBox txt, string field)
            {
                MessageBox.Show($"Ingrese un valor válido para {field}.", "Error");
                txt.Focus();
                return false;
            }

            // Calcula el perímetro del trapezoide sumando todos sus lados.
            public void CalculatePerimeter()
            {
                mPerimeter = mBase1 + mBase2 + mSideA + mSideB;
            }

            // Calcula el área del trapezoide usando la fórmula del trapecio:
            // Área = ((Base 1 + Base 2) * Altura) / 2
            public void CalculateArea()
            {
                mArea = ((mBase1 + mBase2) * mHeight) / 2;
            }

            // Muestra los resultados del área y perímetro calculados en los TextBox correspondientes.
            public void PrintData(TextBox txtArea, TextBox txtPerimeter)
            {
                txtArea.Text = mArea.ToString("0.00");
                txtPerimeter.Text = mPerimeter.ToString("0.00");
            }

            // Función que inicializa los datos y controles del trapezoide.
            public void InitializeData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight, TextBox txtSideA, TextBox txtSideB,
                                   TextBox txtArea, TextBox txtPerimeter)
            {
                txtBase1.Text = ""; txtBase2.Text = ""; txtHeight.Text = "";
                txtSideA.Text = ""; txtSideB.Text = "";
                txtArea.Text = ""; txtPerimeter.Text = "";
                txtBase1.Focus();
            }


            // Cierra el formulario actual.
            public void CloseForm(Form ObjForm)
            {
                ObjForm.Close();
            }
        }
    }
