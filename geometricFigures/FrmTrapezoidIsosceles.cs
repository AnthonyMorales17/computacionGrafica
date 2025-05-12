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
    public partial class FrmTrapezoidIsosceles : Form
    {
        private static FrmTrapezoidIsosceles instance;

        // Definición de un objeto de tipo CTrapezoidIsosceles. 
        private CTrapezoidIsosceles ObjTrapezoidIsos = new CTrapezoidIsosceles();

        public static FrmTrapezoidIsosceles GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapezoidIsosceles();
            }
            return instance;
        }

        public FrmTrapezoidIsosceles()
        {
            InitializeComponent();
        }

        public static FrmTrapezoidIsosceles Instance => instance ?? (instance = new FrmTrapezoidIsosceles());

        private void FrmTrapezoidIsosceles_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmTrapezoidIsosceles_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjTrapezoidIsos.InitializeData(txtMajorBase, txtMinorBase, txtSide, txtHeight, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTrapezoidIsos.ReadData(txtMajorBase, txtMinorBase, txtSide, txtHeight))
            {
                // Cálculo del perímetro de un Trapecio Isos. 
                // Llamada a la función CalculatePerimeter.
                ObjTrapezoidIsos.CalculatePerimeter();
                // Cálculo del área de un Trapecio Isos. 
                // Llamada a la función CalculatePerimeter.
                ObjTrapezoidIsos.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjTrapezoidIsos.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoidIsos.InitializeData(txtMajorBase, txtMinorBase, txtSide, txtHeight, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjTrapezoidIsos.CloseForm(this);
        }
    }
}
