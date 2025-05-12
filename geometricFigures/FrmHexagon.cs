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
    public partial class FrmHexagon : Form
    {
        private static FrmHexagon instance;

        // Definición de un objeto de tipo CHexagon. 
        private CHexagon ObjHexagon = new CHexagon();

        public static FrmHexagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmHexagon();
            }
            return instance;
        }

        public FrmHexagon()
        {
            InitializeComponent();
        }

        public static FrmHexagon Instance => instance ?? (instance = new FrmHexagon());

        private void FrmHexagon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmHexagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjHexagon.InitializeData(txtRadius, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjHexagon.ReadData(txtRadius))
            {
                // Cálculo del perímetro de un hexágono. 
                // Llamada a la función CalculatePerimeter.
                ObjHexagon.CalculatePerimeter();
                // Cálculo del área de un hexágono. 
                // Llamada a la función CalculatePerimeter.
                ObjHexagon.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjHexagon.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjHexagon.CloseForm(this);
        }
    }
}
