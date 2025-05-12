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
    public partial class FrmHeptagon : Form
    {
        private static FrmHeptagon instance;

        // Definición de un objeto de tipo CSquare. 
        private CHeptagon ObjHeptagon = new CHeptagon();

        public static FrmHeptagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmHeptagon();
            }
            return instance;
        }
        public FrmHeptagon()
        {
            InitializeComponent();
        }

        public static FrmHeptagon Instance => instance ?? (instance = new FrmHeptagon());

        private void FrmHeptagon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmHeptagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjHeptagon.InitializeData(txtRadius, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjHeptagon.ReadData(txtRadius))
            {
                // Cálculo del perímetro de un heptágono. 
                // Llamada a la función CalculatePerimeter.
                ObjHeptagon.CalculatePerimeter();
                // Cálculo del área de un heptágono. 
                // Llamada a la función CalculatePerimeter.
                ObjHeptagon.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjHeptagon.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHeptagon.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjHeptagon.CloseForm(this);
        }
    }
}
