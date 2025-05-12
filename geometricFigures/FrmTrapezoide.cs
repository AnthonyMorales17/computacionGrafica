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
    public partial class FrmTrapezoide : Form
    {
        private static FrmTrapezoide instance;

        private CTrapezoide ObjTrapezoide = new CTrapezoide();

        public static FrmTrapezoide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapezoide();
            }
            return instance;
        }

        public FrmTrapezoide()
        {
            InitializeComponent();
        }

        public static FrmTrapezoide Instance => instance ?? (instance = new FrmTrapezoide());

        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtMajorBase, txtMinorBase, txtHeight, txtSideA, txtSideB, txtArea, txtPerimeter);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ObjTrapezoide.ReadData(txtMajorBase, txtMinorBase, txtSideA, txtSideB, txtHeight))
            {
                ObjTrapezoide.CalculatePerimeter();
                ObjTrapezoide.CalculateArea();
                ObjTrapezoide.PrintData(txtArea, txtPerimeter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtSideA, txtSideB, txtMajorBase, txtMinorBase, txtHeight, txtArea, txtPerimeter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.CloseForm(this);
        }
    }
}
