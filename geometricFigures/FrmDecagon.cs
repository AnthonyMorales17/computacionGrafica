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
    public partial class FrmDecagon : Form
    {
        private static FrmDecagon instance;

        // Definición de un objeto de tipo CDecagon. 
        private CDecagon ObjDecagon = new CDecagon();

        public static FrmDecagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDecagon();
            }
            return instance;
        }

        public FrmDecagon()
        {
            InitializeComponent();
        }

        public static FrmDecagon Instance => instance ?? (instance = new FrmDecagon());

        private void FrmDecagon_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmDecagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjDecagon.InitializeData(txtRadius, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjDecagon.ReadData(txtRadius))
            {
                // Cálculo del perímetro. 
                // Llamada a la función CalculatePerimeter.
                ObjDecagon.CalculatePerimeter();
                // Cálculo del área. 
                // Llamada a la función CalculatePerimeter.
                ObjDecagon.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjDecagon.PrintData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDecagon.InitializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjDecagon.CloseForm(this);
        }
    }
}
