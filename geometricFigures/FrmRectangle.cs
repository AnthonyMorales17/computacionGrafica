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
    public partial class FrmRectangle : Form
    {
        private static FrmRectangle instance;

        // Definición de un objeto de tipo CTriangle. 
        private CRectangle ObjRectangle = new CRectangle();

        public static FrmRectangle GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRectangle();
            }
            return instance;
        }

        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjRectangle.InitializeData(txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRectangle.ReadData(txtBase, txtHeight))
            {
                // Cálculo del perímetro de un rectángulo. 
                // Llamada a la función CalculatePerimeter.
                ObjRectangle.CalculateArea();
                // Cálculo del área de un rectángulo. 
                // Llamada a la función CalculatePerimeter.
                ObjRectangle.CalculatePerimeter();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjRectangle.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtBase, txtHeight, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjRectangle.CloseForm(this);
        }
    }
}
