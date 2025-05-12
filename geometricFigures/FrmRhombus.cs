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
    public partial class FrmRhombus : Form
    {
        private static FrmRhombus instance;

        // Definición de un objeto de tipo CRhombus. 
        private CRhombus ObjRhombus = new CRhombus();

        public static FrmRhombus GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRhombus();
            }
            return instance;
        }
        public FrmRhombus()
        {
            InitializeComponent();
        }

        public static FrmRhombus Instance => instance ?? (instance = new FrmRhombus());

        private void FrmRhombus_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmRhombus_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjRhombus.InitializeData(txtSide, txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRhombus.ReadData(txtMajorDiagonal, txtMinorDiagonal, txtSide))
            {
                // Cálculo del perímetro de un Rombo. 
                // Llamada a la función CalculateArea.
                ObjRhombus.CalculateArea();
                // Cálculo del perímetro de un Rombo. 
                // Llamada a la función CalculatePerimeter.
                ObjRhombus.CalculatePerimeter();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjRhombus.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhombus.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtSide, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjRhombus.CloseForm(this);
        }
    }
}
