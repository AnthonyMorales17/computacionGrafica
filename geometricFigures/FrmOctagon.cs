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
    public partial class FrmOctagon : Form
    {
        private static FrmOctagon instance;

        // Definición de un objeto de tipo CSquare. 
        private COctagon ObjOctagon = new COctagon();

        public static FrmOctagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmOctagon();
            }
            return instance;
        }

        public FrmOctagon()
        {
            InitializeComponent();
        }

        public static FrmOctagon Instance => instance ?? (instance = new FrmOctagon());

        private void FrmOctagon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmOctagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjOctagon.InitializeData(txtRadius, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjOctagon.ReadData(txtRadius))
            {
                // Cálculo del perímetro. 
                // Llamada a la función CalculatePerimeter.
                ObjOctagon.CalculatePerimeter();
                // Cálculo del área. 
                // Llamada a la función CalculatePerimeter.
                ObjOctagon.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjOctagon.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjOctagon.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjOctagon.CloseForm(this);
        }
    }
}
