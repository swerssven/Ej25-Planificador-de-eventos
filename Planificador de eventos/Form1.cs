using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planificador_de_eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cumpleanos = new Cumpleanyos();
            cenaEmpresa = new CenasEmpresa();
        }

        Cumpleanyos cumpleanos = new Cumpleanyos();
        CenasEmpresa cenaEmpresa = new CenasEmpresa();

        private void tab_Cumpleanyos_Selecting(object sender, TabControlCancelEventArgs e)
        {
            cumpleanos = new Cumpleanyos();
            cenaEmpresa = new CenasEmpresa();
            actualizaTxt();
            txt_costeCena.Text = "0";
        }

        private void nUD_personasCenas_ValueChanged(object sender, EventArgs e)
        {
            int numPersonas = (int)nUD_personasCenas.Value;
            cenaEmpresa.setNumPersonas(numPersonas);
            actualizaTxt();
        }

        private void ckb_CenaLujo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_CenaLujo.Checked)
            {
                cenaEmpresa.calcularCosteDecoracion(true);
            }
            else
            {
                cenaEmpresa.calcularCosteDecoracion(false);
            }
            actualizaTxt();
        }

        private void ckb_cenaSaludable_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_cenaSaludable.Checked)
            {
                cenaEmpresa.estableceOpcionSaludable(true);
            }
            else
            {
                cenaEmpresa.estableceOpcionSaludable(false);
            }
            actualizaTxt();
        }

        public void actualizaTxt()
        {
            txt_costeCena.Text = cenaEmpresa.calcularCoste().ToString();
            txt_costeCumple.Text = cumpleanos.calcularCoste().ToString();
        }

        private void nUD_personasCumpleaños_ValueChanged(object sender, EventArgs e)
        {
            int numPersonas = (int)nUD_personasCumpleaños.Value;
            cumpleanos.setNumPersonas(numPersonas);
            cumpleanos.setTamanyoTarta();
            actualizaTxt();
        }

        private void ckb_cumpleLujo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_cumpleLujo.Checked)
            {
                cumpleanos.calcularCosteDecoracion(true);
            }
            else
            {
                cumpleanos.calcularCosteDecoracion(false);
            }
            actualizaTxt();
        }

        private void txt_textoTarta_TextChanged(object sender, EventArgs e)
        {
            cumpleanos.setTextTarta(txt_textoTarta.Text);
            actualizaTxt();
        }
    }
}
