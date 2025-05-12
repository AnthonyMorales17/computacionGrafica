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
    public partial class FrmTrapezoid : Form
    {
        private static FrmTrapezoid instance;

        // Definición de un objeto de tipo CTrapezoid. 
        private CTrapezoid ObjTrapezoid = new CTrapezoid();

        public static FrmTrapezoid GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapezoid();
            }
            return instance;
        }

        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        public static FrmTrapezoid Instance => instance ?? (instance = new FrmTrapezoid());

        private void FrmTrapezoid_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjTrapezoid.InitializeData(txtMajorBase, txtMinorBase, txtSideA, txtSideB, txtHeight, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTrapezoid.ReadData(txtMajorBase, txtMinorBase, txtSideA, txtSideB, txtHeight))
            {
                // Cálculo del perímetro de un Trapecio. 
                // Llamada a la función CalculatePerimeter.
                ObjTrapezoid.CalculatePerimeter();
                // Cálculo del área de un Trapecio. 
                // Llamada a la función CalculatePerimeter.
                ObjTrapezoid.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjTrapezoid.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ObjTrapezoid.InitializeData(txtMajorBase, txtMinorBase, txtSideA, txtSideB, txtHeight, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjTrapezoid.CloseForm(this);
        }
    }
}
