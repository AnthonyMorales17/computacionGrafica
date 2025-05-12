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
    public partial class FrmDeltoide : Form
    {
        private static FrmDeltoide instance;

        // Definición de un objeto de tipo CDeltoide. 
        private CDeltoide ObjDeltoide = new CDeltoide();

        public static FrmDeltoide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDeltoide();
            }
            return instance;
        }

        public FrmDeltoide()
        {
            InitializeComponent();
        }

        private void FrmDeltoide_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Al cerrarse, liberar la instancia para permitir volver a abrirla
            instance = null;
        }

        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles. 
            // Llamada a la función InitializeData.
            ObjDeltoide.InitializeData(txtShortSide, txtLongSide, txtMajorDiagonal, txtMinorDiagonal, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjDeltoide.ReadData(txtShortSide, txtLongSide, txtMajorDiagonal, txtMinorDiagonal))
            {
                ObjDeltoide.CalculatePerimeter();
                ObjDeltoide.CalculateArea();
                ObjDeltoide.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDeltoide.InitializeData(txtShortSide, txtLongSide, txtMajorDiagonal, txtMinorDiagonal, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjDeltoide.CloseForm(this);
        }
    }
}
