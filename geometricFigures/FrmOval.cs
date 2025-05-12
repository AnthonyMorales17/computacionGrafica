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
    public partial class FrmOval : Form
    {
        private static FrmOval instance;

        // Definición de un objeto de tipo COval. 
        private COval ObjOval = new COval();

        public static FrmOval GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmOval();
            }
            return instance;
        }

        public FrmOval()
        {
            InitializeComponent();
        }

        private void FrmOval_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjOval.InitializeData(txtMajorSemiAxis, txtMinorSemiAxis, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjOval.ReadData(txtMajorSemiAxis, txtMinorSemiAxis))
            {
                ObjOval.CalculatePerimeter();
                ObjOval.CalculateArea();
                ObjOval.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjOval.InitializeData(txtMajorSemiAxis, txtMinorSemiAxis, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjOval.CloseForm(this);
        }
    }
}
