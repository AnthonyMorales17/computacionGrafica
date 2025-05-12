using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometricFigures
{
    public partial class FrmEllipse : Form
    {
        private static FrmEllipse instance;

        // Definición de un objeto de tipo CEllipse. 
        private CEllipse ObjEllipse = new CEllipse();

        public static FrmEllipse GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmEllipse();
            }
            return instance;
        }

        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjEllipse.InitializeData(txtMajorSemiAxis, txtMinorSemiAxis, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjEllipse.ReadData(txtMajorSemiAxis, txtMinorSemiAxis))
            {
                ObjEllipse.CalculatePerimeter();
                ObjEllipse.CalculateArea();
                ObjEllipse.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjEllipse.InitializeData(txtMajorSemiAxis, txtMinorSemiAxis, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjEllipse.CloseForm(this);
        }
    }
}
