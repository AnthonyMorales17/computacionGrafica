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
    public partial class FrmTriangle : Form
    {
        private static FrmTriangle instance;

        // Definición de un objeto de tipo CTriangle. 
        private CTriangle ObjTriangle = new CTriangle();

        public static FrmTriangle GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTriangle();
            }
            return instance;
        }

        public FrmTriangle()
        {
            InitializeComponent();
        }

        private void FrmTriangle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTriangle.ReadData(txtSideA, txtSideB, txtSideC))
            {
                // Cálculo del perímetro de un tríangulo. 
                // Llamada a la función CalculatePerimeter.
                ObjTriangle.CalculatePerimeter();
                // Cálculo del área de un tríangulo. 
                // Llamada a la función CalculateArea.
                ObjTriangle.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjTriangle.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjTriangle.CloseForm(this);
        }
    }
}
