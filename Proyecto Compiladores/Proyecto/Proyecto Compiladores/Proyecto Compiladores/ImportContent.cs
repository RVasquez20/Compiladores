using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ImportContent : Form
    {
      
        //Constructor
        public ImportContent()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }
        #region Estilos
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 135;
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

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

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

        private void panelDragandDrop_DragLeave(object sender, EventArgs e)
        {
            metodoDragLeave();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportContent_Load(object sender, EventArgs e)
        {
            panelDragandDrop.AllowDrop = true;
            panelDragandDrop.DragEnter += new DragEventHandler(metodoDragEnter);
            panelDragandDrop.DragDrop += new DragEventHandler(metodoDragDrop);
        }

        private void metodoDragLeave()
        {
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Download;
        }
        public void metodoDragEnter(Object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            }



        }
        #endregion
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getDocument = new OpenFileDialog();
            getDocument.InitialDirectory = "C:\\";
            getDocument.Filter = "Archivos de texto (*.txt)|*txt;";
            getDocument.Title = "Selecciona el archivo Para Analizar";
            if (!(getDocument.ShowDialog() == DialogResult.OK))
            {
                errorNotificacion("Error", "No se Selecciono ningun Archivo");
            }
            else
            {
                string ruta = getDocument.FileName;
                string[] nombreArchivo = ruta.Split('\\');
                string nombreArchivoSinRuta = nombreArchivo[nombreArchivo.Length - 1];

                String linea = "";
                using (StreamReader sw = new StreamReader(ruta))
                {
                    linea = sw.ReadToEnd();
                }
                successNotificacion("Importacion Terminada", "Se importo el archivo correctamente");
                analizar(linea, ruta, nombreArchivoSinRuta);
                this.Close();
                
            }
        }

        public void metodoDragDrop(Object sender, DragEventArgs e)
        {
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            string[] rutas = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] nombreArchivo = rutas[0].Split('\\');
            String nombreArchivoSinRuta = nombreArchivo[nombreArchivo.Length - 1];
            string extPermitida = ".txt";
            if (rutas.Length != 1)
            {
                errorNotificacion("Error", "Solo se permite importar 1 archivo a la vez");
            }
            else if (!(nombreArchivoSinRuta.ToLower().Contains(extPermitida)))
            {
                errorNotificacion("Error", "Solo se permite importar archivos de texto(.txt)");
            }
            else
            {
                try
                {

                    String linea = "";
                    using (StreamReader sw = new StreamReader(rutas[0]))
                    {
                        linea = sw.ReadToEnd();
                    }

                    successNotificacion("Importacion Terminada", "Se importo el archivo correctamente");
                    analizar(linea,rutas[0], nombreArchivoSinRuta);


                    this.Close();
                }
                catch (Exception ex)
                {
                    errorNotificacion("Error", "No se pudo importar el archivo\n"+ex.Message);
                }
            }
           

        }


        public void errorNotificacion(string title, string text)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("error_icon.ico"));
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(2000);
        }

        public void successNotificacion(string title, string text)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("success_icon.ico"));
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(2000);

        }

        public void analizar(string texto,string ruta,string fileName)
        {
            FormMenuPrincipal principal = Owner as FormMenuPrincipal;
            principal.cuadroContenido.Text = texto;
            //principal.ejecutarLexico(ruta);
            principal.saveContentLex();
            principal.saveContentBison();
            principal.Titulo.Text = fileName;
            principal.Titulo.Visible = true;
            principal.closeFileActual.Visible = true;
        }








    }
}
