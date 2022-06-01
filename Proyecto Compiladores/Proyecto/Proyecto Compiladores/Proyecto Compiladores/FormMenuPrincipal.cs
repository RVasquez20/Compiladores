using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Compiladores
{
    public partial class FormMenuPrincipal : Form
    {
        string archivo;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            closeFileActual.Visible = false;
            generarEjecutableFlex();
            generarEjecutableBison();
            
        }


        #region Estilo

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance,
                this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        #endregion


        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void Import_Click(object sender, EventArgs e)
        {
            ImportContent importContent = new ImportContent();
            AddOwnedForm(importContent);
            importContent.Show();
        }

        private void generarEjecutableFlex()
        {
            Process generateExecutable = new Process();
            generateExecutable.StartInfo.FileName = Application.StartupPath.ToString() + (@"\Lexico\compilar.bat");
            generateExecutable.StartInfo.UseShellExecute = false;
            generateExecutable.StartInfo.CreateNoWindow = true;
            generateExecutable.Start();
            generateExecutable.WaitForExit();
        }
        private void generarEjecutableBison()
        {
            Process generateExecutableBison = new Process();
            generateExecutableBison.StartInfo.FileName = Application.StartupPath.ToString()+(@"\Sintactico\compilarSintactico.bat");
            generateExecutableBison.StartInfo.UseShellExecute = false;
            generateExecutableBison.StartInfo.CreateNoWindow = true;
            generateExecutableBison.Start();
            generateExecutableBison.WaitForExit();
        }

        public void analizadorLexico_Click(object sender, EventArgs e)
        {
            saveContentLex();
        }

        private void saveLog_Click_1(object sender, EventArgs e)
        {
            saveLogFlex();
            saveLogBison();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearBoxes();
            Titulo.Text = "";
            closeFileActual.Visible = false;
        }

        private void clearBoxes()
        {
            cuadroContenido.Text = "";
            cuadroLog.Text = "";
            cuadroLogSintactico.Text = "";
        }

        private void closeFileActual_Click(object sender, EventArgs e)
        {
            clearBoxes();
            Titulo.Text = "";
            closeFileActual.Visible = false;
        }

        public void ejecutarLexico(string pathArchivoAnalizar)
        {
            try
            {
                Process lexicoBat = new Process();
                lexicoBat.StartInfo.FileName = Application.StartupPath.ToString() + (@"\Lexico\Lexico.exe");
                lexicoBat.StartInfo.UseShellExecute = false;
                lexicoBat.StartInfo.RedirectStandardOutput = true;
                lexicoBat.StartInfo.Arguments = pathArchivoAnalizar;
                lexicoBat.StartInfo.CreateNoWindow = true;
                lexicoBat.Start();
                cuadroLog.Text = lexicoBat.StandardOutput.ReadToEnd();
                lexicoBat.WaitForExit();
                successNotificacion("Analisis Terminado","Analisis Lexico Terminado ");
                saveLogFlex();                
            }
            catch (Exception ex)
            {
                errorNotificacion("Error al Analizar", ex.Message);
            }
        }
        public void ejecutarSintactico(string pathArchivoAnalizar)
        {
            try
            {
                Process sintacticoBat = new Process();
                sintacticoBat.StartInfo.FileName = Application.StartupPath.ToString() + (@"\Sintactico\compiladoBison.exe");
                sintacticoBat.StartInfo.UseShellExecute = false;
                sintacticoBat.StartInfo.RedirectStandardOutput = true;
                sintacticoBat.StartInfo.Arguments = pathArchivoAnalizar;
                sintacticoBat.StartInfo.CreateNoWindow = true;
                sintacticoBat.Start();
                cuadroLogSintactico.Text = sintacticoBat.StandardOutput.ReadToEnd();
                sintacticoBat.WaitForExit();
                successNotificacion("Analisis Terminado", "Analisis Sintactico Terminado");
                saveLogBison();
            }
            catch (Exception ex)
            {
                errorNotificacion("Error al Analizar", ex.Message);
            }
        }

        public void errorNotificacion(string title,string text)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("error_icon.ico"));
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(2000);
        }

        public void successNotificacion(string title,string text)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("success_icon.ico"));
            notifyIcon1.Visible=true;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(2000);

        }

        private void analizadorSintactico_Click(object sender, EventArgs e)
        {
            saveContentBison();
        }

        public void saveLogFlex()
        {
            try
            {
                var tokens = cuadroLog.Text;
                using (StreamWriter sw = new StreamWriter(@".\Resultados\tokensLexico.txt"))
                {
                    sw.Write(tokens);
                }
                successNotificacion("Log Guardado", "Log Guardado Correctamente");
            }
            catch (Exception e)
            {
                errorNotificacion("Error al Guardar el log", e.Message);
            }
        }
        public void saveLogBison()
        {
            try
            {
                var content = cuadroLogSintactico.Text;
                using (StreamWriter sw = new StreamWriter(@".\Resultados\resultSintactico.txt"))
                {
                    sw.Write(content);
                }
                successNotificacion("Log Guardado", "Log Guardado Correctamente");
            }
            catch (Exception e)
            {
                errorNotificacion("Error al Guardar el log", e.Message);
            }
        }

        public void saveContentLex()
        {
            if (!cuadroContenido.Text.Equals(""))
            {
                var contenido = cuadroContenido.Text;
                using (StreamWriter sw = new StreamWriter(@".\contenido.txt"))
                {
                    sw.Write(contenido);
                }

                ejecutarLexico(@".\contenido.txt");
            }
            else
            {
                errorNotificacion("Error Al Analizar", "No hay contenido que analizar");
            }
        }
        public void saveContentBison()
        {
            if (!cuadroContenido.Text.Equals(""))
            {
                var contenido = cuadroContenido.Text;
                using (StreamWriter sw = new StreamWriter(@".\contenido.txt"))
                {
                    sw.Write(contenido);
                }

                ejecutarSintactico(@".\contenido.txt");
            }
            else
            {
                errorNotificacion("Error Al Analizar", "No hay contenido que analizar");
            }
        }
    }        
}
