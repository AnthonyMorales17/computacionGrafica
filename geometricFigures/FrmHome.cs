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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void OpenFigureForm<T>() where T : Form
        {
            // Utilizamos reflexión para llamar al método estático GetInstance()
            var method = typeof(T).GetMethod("GetInstance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            // Si no se encuentra el método, salir del método sin hacer nada.
            if (method == null) return;

            // Invocar el método estático GetInstance() que devuelve una instancia del formulario
            var form = method.Invoke(null, null) as Form;

            // Si se obtuvo un formulario válido
            if (form != null)
            {
                // Asignar el formulario actual como padre MDI si aún no tiene uno
                if(form.MdiParent == null)
                {
                    form.MdiParent = this; // 'this' hace referencia al formulario principal MDI
                }

                //Mostrar el formulario si no está visible.
                if(!form.Visible)
                {
                    form.Show();
                }
                else
                {
                    // Si ya está abierto, llevarlo al frente.
                    form.BringToFront();
                }
            }
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            OpenFigureForm<FrmCircle>();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmEllipse>();
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmOval>();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmTriangle>();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmSquare>();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmPentagon>();
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmHexagon>();
        }

        private void heptagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmHeptagon>();
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmOctagon>();
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmNonagon>();
        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmDecagon>();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmRectangle>();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmRhombus>();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmRhomboid>();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmTrapezoid>();
        }

        private void trapecioIdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmTrapezoidIsosceles>();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmTrapezoide>();
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmDeltoide>();
        }
    }
}
