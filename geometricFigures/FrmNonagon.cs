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
    public partial class FrmNonagon : Form
    {
        private static FrmNonagon instance;

        // Definición de un objeto de tipo CSquare. 
        private CNonagon ObjNonagon = new CNonagon();

        public static FrmNonagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmNonagon();
            }
            return instance;
        }

        public FrmNonagon()
        {
            InitializeComponent();
        }

        public static FrmNonagon Instance => instance ?? (instance = new FrmNonagon());

        private void FrmNonagon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmNonagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjNonagon.InitializeData(txtRadius, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjNonagon.ReadData(txtRadius))
            {
                // Cálculo del perímetro de un pentagono. 
                // Llamada a la función CalculatePerimeter.
                ObjNonagon.CalculatePerimeter();
                // Cálculo del área de un pentagono. 
                // Llamada a la función CalculatePerimeter.
                ObjNonagon.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjNonagon.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjNonagon.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjNonagon.CloseForm(this);
        }
    }
}
