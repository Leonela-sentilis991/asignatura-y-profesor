using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informacion_de_asignatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            {
                string profesor, asignatura, modalidad = " ";

                asignatura = lbl_asignatura.Text;
                profesor = lbl_Profesor.Text;

                if (rb_Presencial.Checked)
                {
                    modalidad = "Presencial";
                }
                else if (rb_Virtual.Checked)
                {
                    modalidad = "Virtual";
                }

                txt_informacion.Text = profesor + (" imparte la asignatura ") + asignatura + " en la modalidad " + modalidad;


            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Profesor.Clear();
            txt_Asignatura.Clear();
            txt_informacion.Clear();
        }
    }
}
    

