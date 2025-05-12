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
    partial class FrmPentagon : Form
    {
        private static FrmPentagon instance;

        // Definición de un objeto de tipo CPentagon. 
        private CPentagon ObjPentagon = new CPentagon();

        public static FrmPentagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPentagon();
            }
            return instance;
        }

        public FrmPentagon()
        {
            InitializeComponent();
        }

        public static FrmPentagon Instance => instance ?? (instance = new FrmPentagon());

        private void FrmPentagon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmPentagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjPentagon.InitializeData(txtRadius, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjPentagon.ReadData(txtRadius))
            {
                // Cálculo del perímetro de un pentagono. 
                // Llamada a la función CalculatePerimeter.
                ObjPentagon.CalculatePerimeter();
                // Cálculo del área de un pentagono. 
                // Llamada a la función CalculatePerimeter.
                ObjPentagon.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjPentagon.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjPentagon.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjPentagon.CloseForm(this);
        }
    }
}
