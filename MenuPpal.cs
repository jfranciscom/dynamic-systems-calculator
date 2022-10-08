using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace sismys
{
    public partial class MenuPpal : Form
    {
        
        public MenuPpal()
        {
            InitializeComponent();
        }

        private void Sd1dac_Click(object sender, EventArgs e)
        {
            SD1D ventana1 = new SD1D();
            ventana1.Show();
            ventana1.FormClosed += reabrir;
            this.Visible = false;
        }


        private void Sd2dahomog_Click(object sender, EventArgs e)
        {
            SD2D ventana1 = new SD2D();
            ventana1.Show();
            ventana1.FormClosed += reabrir;
            this.Visible = false;
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void reabrir(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Movimiento de la ventana.
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MenuPpal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            MenuPpal.ReleaseCapture();
            MenuPpal.SendMessage(this.Handle, 161, 2, 0);
        }
    }
}
