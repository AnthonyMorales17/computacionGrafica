using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace geometricFigures
{
    public partial class FrmCircle : Form
    {
        private static FrmCircle instance;

        // Definición de un objeto de tipo CCircle. 
        private CCircle ObjCircle = new CCircle();

        public static FrmCircle GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCircle();
            }
            return instance;
        }

        public FrmCircle()
        {
            InitializeComponent();
        }

        private void FrmCircle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjCircle.ReadData(txtRadius))
            {
                // Cálculo del área de un círculo. 
                // Llamada a la función CalculateArea.
                ObjCircle.CalculateArea();
                // Cálculo del perímetro de un círculo. 
                // Llamada a la función CalculatePerimeter.
                ObjCircle.CalculatePerimeter();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjCircle.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData. 
            ObjCircle.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjCircle.CloseForm(this);
        }
    }
}
