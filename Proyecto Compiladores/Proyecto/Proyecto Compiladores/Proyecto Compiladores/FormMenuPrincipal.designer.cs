namespace Proyecto_Compiladores
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedorForm = new System.Windows.Forms.Panel();
            this.cuadroLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cuadroContenido = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.analizadorLexico = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.closeFileActual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cuadroLogSintactico = new FastColoredTextBoxNS.FastColoredTextBox();
            this.analizadorSintactico = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedorPrincipal.SuspendLayout();
            this.panelContenedorForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroContenido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroLogSintactico)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorPrincipal
            // 
            this.panelContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedorPrincipal.Controls.Add(this.panelContenedorForm);
            this.panelContenedorPrincipal.Controls.Add(this.panel1);
            this.panelContenedorPrincipal.Controls.Add(this.panelMenu);
            this.panelContenedorPrincipal.Controls.Add(this.PanelBarraTitulo);
            this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            this.panelContenedorPrincipal.Size = new System.Drawing.Size(1100, 600);
            this.panelContenedorPrincipal.TabIndex = 0;
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelContenedorForm.Controls.Add(this.cuadroLogSintactico);
            this.panelContenedorForm.Controls.Add(this.cuadroLog);
            this.panelContenedorForm.Controls.Add(this.cuadroContenido);
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(230, 68);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(870, 532);
            this.panelContenedorForm.TabIndex = 6;
            // 
            // cuadroLog
            // 
            this.cuadroLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuadroLog.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.cuadroLog.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.cuadroLog.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.cuadroLog.BackBrush = null;
            this.cuadroLog.BackColor = System.Drawing.SystemColors.Control;
            this.cuadroLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cuadroLog.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.cuadroLog.CharHeight = 18;
            this.cuadroLog.CharWidth = 10;
            this.cuadroLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuadroLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cuadroLog.Font = new System.Drawing.Font("Courier New", 12F);
            this.cuadroLog.ForeColor = System.Drawing.Color.Black;
            this.cuadroLog.IsReplaceMode = false;
            this.cuadroLog.LeftBracket = '(';
            this.cuadroLog.LeftBracket2 = '{';
            this.cuadroLog.Location = new System.Drawing.Point(436, 0);
            this.cuadroLog.Name = "cuadroLog";
            this.cuadroLog.Paddings = new System.Windows.Forms.Padding(0);
            this.cuadroLog.ReadOnly = true;
            this.cuadroLog.RightBracket = ')';
            this.cuadroLog.RightBracket2 = '}';
            this.cuadroLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cuadroLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("cuadroLog.ServiceColors")));
            this.cuadroLog.Size = new System.Drawing.Size(431, 266);
            this.cuadroLog.TabIndex = 3;
            this.cuadroLog.WordWrap = true;
            this.cuadroLog.Zoom = 100;
            // 
            // cuadroContenido
            // 
            this.cuadroContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuadroContenido.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.cuadroContenido.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.cuadroContenido.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.cuadroContenido.BackBrush = null;
            this.cuadroContenido.BackColor = System.Drawing.SystemColors.Control;
            this.cuadroContenido.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.cuadroContenido.CharHeight = 18;
            this.cuadroContenido.CharWidth = 10;
            this.cuadroContenido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuadroContenido.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cuadroContenido.Font = new System.Drawing.Font("Courier New", 12F);
            this.cuadroContenido.ForeColor = System.Drawing.Color.Black;
            this.cuadroContenido.IsReplaceMode = false;
            this.cuadroContenido.LeftBracket = '(';
            this.cuadroContenido.LeftBracket2 = '{';
            this.cuadroContenido.Location = new System.Drawing.Point(-4, 0);
            this.cuadroContenido.Name = "cuadroContenido";
            this.cuadroContenido.Paddings = new System.Windows.Forms.Padding(0);
            this.cuadroContenido.RightBracket = ')';
            this.cuadroContenido.RightBracket2 = '}';
            this.cuadroContenido.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cuadroContenido.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("cuadroContenido.ServiceColors")));
            this.cuadroContenido.Size = new System.Drawing.Size(444, 532);
            this.cuadroContenido.TabIndex = 2;
            this.cuadroContenido.WordWrap = true;
            this.cuadroContenido.Zoom = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(230, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 25);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(605, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 5;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(418, 7);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(150, 13);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(357, 5);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 15);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 43);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 557);
            this.panelMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizadorLexico,
            this.analizadorSintactico,
            this.saveLog,
            this.toolStripMenuItem1,
            this.clear});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 108);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(239, 172);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // analizadorLexico
            // 
            this.analizadorLexico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analizadorLexico.ForeColor = System.Drawing.Color.Snow;
            this.analizadorLexico.Image = ((System.Drawing.Image)(resources.GetObject("analizadorLexico.Image")));
            this.analizadorLexico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analizadorLexico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.analizadorLexico.Name = "analizadorLexico";
            this.analizadorLexico.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.analizadorLexico.Size = new System.Drawing.Size(232, 36);
            this.analizadorLexico.Text = "   Analizador Lexico";
            this.analizadorLexico.Click += new System.EventHandler(this.analizadorLexico_Click);
            // 
            // saveLog
            // 
            this.saveLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLog.ForeColor = System.Drawing.Color.Snow;
            this.saveLog.Image = global::Proyecto_Compiladores.Properties.Resources.save_guardar_icon2;
            this.saveLog.Name = "saveLog";
            this.saveLog.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.saveLog.Size = new System.Drawing.Size(232, 25);
            this.saveLog.Text = "    Guardar Log     ";
            this.saveLog.Click += new System.EventHandler(this.saveLog_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem1.Image = global::Proyecto_Compiladores.Properties.Resources.import_icon20px;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 25);
            this.toolStripMenuItem1.Text = "     Importar Datos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Import_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Snow;
            this.clear.Image = global::Proyecto_Compiladores.Properties.Resources.clear_icon20px;
            this.clear.Name = "clear";
            this.clear.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.clear.Size = new System.Drawing.Size(232, 25);
            this.clear.Text = "     Limpiar               ";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Proyecto_Compiladores.Properties.Resources.menu2;
            this.btnMenu.Location = new System.Drawing.Point(181, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelBarraTitulo.Controls.Add(this.closeFileActual);
            this.PanelBarraTitulo.Controls.Add(this.label1);
            this.PanelBarraTitulo.Controls.Add(this.Titulo);
            this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
            this.PanelBarraTitulo.Controls.Add(this.btnNormal);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1100, 43);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // closeFileActual
            // 
            this.closeFileActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeFileActual.FlatAppearance.BorderSize = 0;
            this.closeFileActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFileActual.Image = global::Proyecto_Compiladores.Properties.Resources.Close;
            this.closeFileActual.Location = new System.Drawing.Point(43, 8);
            this.closeFileActual.Name = "closeFileActual";
            this.closeFileActual.Size = new System.Drawing.Size(28, 29);
            this.closeFileActual.TabIndex = 8;
            this.closeFileActual.UseVisualStyleBackColor = true;
            this.closeFileActual.Click += new System.EventHandler(this.closeFileActual_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proyecto Compiladores";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(77, 15);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(62, 16);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Sin Titulo";
            this.Titulo.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::Proyecto_Compiladores.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(950, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Proyecto_Compiladores.Properties.Resources.maximize3;
            this.btnMaximizar.Location = new System.Drawing.Point(999, 1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(43, 43);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Proyecto_Compiladores.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(1043, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = global::Proyecto_Compiladores.Properties.Resources.Normal;
            this.btnNormal.Location = new System.Drawing.Point(999, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(43, 43);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // cuadroLogSintactico
            // 
            this.cuadroLogSintactico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuadroLogSintactico.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.cuadroLogSintactico.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.cuadroLogSintactico.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.cuadroLogSintactico.BackBrush = null;
            this.cuadroLogSintactico.BackColor = System.Drawing.SystemColors.Control;
            this.cuadroLogSintactico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cuadroLogSintactico.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.cuadroLogSintactico.CharHeight = 18;
            this.cuadroLogSintactico.CharWidth = 10;
            this.cuadroLogSintactico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuadroLogSintactico.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cuadroLogSintactico.Font = new System.Drawing.Font("Courier New", 12F);
            this.cuadroLogSintactico.ForeColor = System.Drawing.Color.Black;
            this.cuadroLogSintactico.IsReplaceMode = false;
            this.cuadroLogSintactico.LeftBracket = '(';
            this.cuadroLogSintactico.LeftBracket2 = '{';
            this.cuadroLogSintactico.Location = new System.Drawing.Point(436, 266);
            this.cuadroLogSintactico.Name = "cuadroLogSintactico";
            this.cuadroLogSintactico.Paddings = new System.Windows.Forms.Padding(0);
            this.cuadroLogSintactico.ReadOnly = true;
            this.cuadroLogSintactico.RightBracket = ')';
            this.cuadroLogSintactico.RightBracket2 = '}';
            this.cuadroLogSintactico.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cuadroLogSintactico.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("cuadroLogSintactico.ServiceColors")));
            this.cuadroLogSintactico.Size = new System.Drawing.Size(431, 266);
            this.cuadroLogSintactico.TabIndex = 4;
            this.cuadroLogSintactico.WordWrap = true;
            this.cuadroLogSintactico.Zoom = 100;
            // 
            // analizadorSintactico
            // 
            this.analizadorSintactico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analizadorSintactico.ForeColor = System.Drawing.Color.Snow;
            this.analizadorSintactico.Image = ((System.Drawing.Image)(resources.GetObject("analizadorSintactico.Image")));
            this.analizadorSintactico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analizadorSintactico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.analizadorSintactico.Name = "analizadorSintactico";
            this.analizadorSintactico.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.analizadorSintactico.ShowShortcutKeys = false;
            this.analizadorSintactico.Size = new System.Drawing.Size(232, 36);
            this.analizadorSintactico.Text = "   Analizador Sintactico";
            this.analizadorSintactico.Click += new System.EventHandler(this.analizadorSintactico_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedorPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "FormMenuPrincipal";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.panelContenedorPrincipal.ResumeLayout(false);
            this.panelContenedorForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuadroLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroContenido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroLogSintactico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorPrincipal;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContenedorForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public FastColoredTextBoxNS.FastColoredTextBox cuadroContenido;
        public FastColoredTextBoxNS.FastColoredTextBox cuadroLog;
        private System.Windows.Forms.ToolStripMenuItem saveLog;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.Label Titulo;
        public System.Windows.Forms.Button closeFileActual;
        public System.Windows.Forms.ToolStripMenuItem analizadorLexico;
        public FastColoredTextBoxNS.FastColoredTextBox cuadroLogSintactico;
        public System.Windows.Forms.ToolStripMenuItem analizadorSintactico;
    }
}

