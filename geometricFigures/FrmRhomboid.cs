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
    public partial class FrmRhomboid : Form
    {
        private static FrmRhomboid instance;

        // Definición de un objeto de tipo CRhomboid. 
        private CRhomboid ObjRhomboid = new CRhomboid();

        public static FrmRhomboid GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRhomboid();
            }
            return instance;
        }

        public FrmRhomboid()
        {
            InitializeComponent();
        }

        public static FrmRhomboid Instance => instance ?? (instance = new FrmRhomboid());

        private void FrmRhomboid_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmRhomboid_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjRhomboid.InitializeData(txtBase, txtHeight, txtSide, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjRhomboid.ReadData(txtBase, txtHeight, txtSide))
            {
                // Cálculo del perímetro de un romboide. 
                // Llamada a la función CalculatePerimeter.
                ObjRhomboid.CalculatePerimeter();
                // Cálculo del área de un romboide. 
                // Llamada a la función CalculatePerimeter.
                ObjRhomboid.CalculateArea();
                // Impresión de datos. 
                // Llamada a la función PrintData.
                ObjRhomboid.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhomboid.InitializeData(txtBase, txtHeight, txtSide, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario. 
            // Llamada a la función CloseForm.
            ObjRhomboid.CloseForm(this);
        }
    }
}
