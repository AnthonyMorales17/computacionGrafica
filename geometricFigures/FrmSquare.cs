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
    public partial class FrmSquare : Form
    {
        private static FrmSquare instance;

        // Definición de un objeto de tipo CSquare. 
        private CSquare ObjSquare = new CSquare();

        public static FrmSquare GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSquare();
            }
            return instance;
        }

        public FrmSquare()
        {
            InitializeComponent();
        }

        private void FrmSquare_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjSquare.ReadData(txtSide))
            {
                // Cálculo del perímetro de un cuadrado. 
                // Llamada a la función CalculatePerimeter.
                ObjSquare.CalculatePerimeter();
                //Cálculo del área de un cuadrado.
                //LLamada a la función CalculateArea.
                ObjSquare.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjSquare.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjSquare.CloseForm(this);
        }
    }
}
