namespace MI_EDITOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem2 = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            borrarTodoToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem1 = new ToolStripMenuItem();
            fuenteToolStripMenuItem2 = new ToolStripMenuItem();
            colorFuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, formatoToolStripMenuItem, fuenteToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, toolStripSeparator3, salirToolStripMenuItem, guardarComoToolStripMenuItem1, salirToolStripMenuItem2 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(196, 26);
            acercaDeToolStripMenuItem.Text = "Nuevo";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(193, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(196, 26);
            salirToolStripMenuItem.Text = "Abrir...";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem1
            // 
            guardarComoToolStripMenuItem1.Name = "guardarComoToolStripMenuItem1";
            guardarComoToolStripMenuItem1.Size = new Size(196, 26);
            guardarComoToolStripMenuItem1.Text = "Guardar como...";
            guardarComoToolStripMenuItem1.Click += guardarComoToolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem2
            // 
            salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            salirToolStripMenuItem2.Size = new Size(196, 26);
            salirToolStripMenuItem2.Text = "&Salir";
            salirToolStripMenuItem2.Click += salirToolStripMenuItem2_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, fuenteToolStripMenuItem, toolStripSeparator1, guardarComoToolStripMenuItem, salirToolStripMenuItem1, toolStripSeparator2, seleccionarTodoToolStripMenuItem, borrarTodoToolStripMenuItem, pegarToolStripMenuItem });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(62, 24);
            formatoToolStripMenuItem.Text = "&Editar";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(224, 26);
            colorToolStripMenuItem.Text = "Atras";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(224, 26);
            fuenteToolStripMenuItem.Text = "Adelante";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(224, 26);
            guardarComoToolStripMenuItem.Text = "Copiar";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(224, 26);
            salirToolStripMenuItem1.Text = "Cortar";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.Size = new Size(224, 26);
            seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // borrarTodoToolStripMenuItem
            // 
            borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            borrarTodoToolStripMenuItem.Size = new Size(224, 26);
            borrarTodoToolStripMenuItem.Text = "Borrar todo";
            borrarTodoToolStripMenuItem.Click += borrarTodoToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(224, 26);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem1
            // 
            fuenteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem2, colorFuenteToolStripMenuItem, colorDeFondoToolStripMenuItem });
            fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            fuenteToolStripMenuItem1.Size = new Size(67, 24);
            fuenteToolStripMenuItem1.Text = "Fuente";
            // 
            // fuenteToolStripMenuItem2
            // 
            fuenteToolStripMenuItem2.Name = "fuenteToolStripMenuItem2";
            fuenteToolStripMenuItem2.Size = new Size(195, 26);
            fuenteToolStripMenuItem2.Text = "Fuente";
            fuenteToolStripMenuItem2.Click += fuenteToolStripMenuItem2_Click;
            // 
            // colorFuenteToolStripMenuItem
            // 
            colorFuenteToolStripMenuItem.Name = "colorFuenteToolStripMenuItem";
            colorFuenteToolStripMenuItem.Size = new Size(195, 26);
            colorFuenteToolStripMenuItem.Text = "Color Fuente";
            colorFuenteToolStripMenuItem.Click += colorFuenteToolStripMenuItem_Click;
            // 
            // colorDeFondoToolStripMenuItem
            // 
            colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            colorDeFondoToolStripMenuItem.Size = new Size(195, 26);
            colorDeFondoToolStripMenuItem.Text = "Color de Fondo";
            colorDeFondoToolStripMenuItem.Click += colorDeFondoToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 51);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(871, 532);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem guardarComoToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem2;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem borrarTodoToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem1;
        private ToolStripMenuItem fuenteToolStripMenuItem2;
        private ToolStripMenuItem colorFuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
    }
}
