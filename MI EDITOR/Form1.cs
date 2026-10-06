namespace MI_EDITOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //Configurar el filtro para archivos de texto
            Open.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir archivo";
            Open.ShowDialog(this);
            try
            {
                //Este codigo para mostrar la info de rich text box
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void timesNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            save.Title = "Guardar archivo";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(save.FileName, richTextBox1.Text);
                    MessageBox.Show("Archivo guardado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }


        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //atras
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //adelante
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void fuenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Creamos el objeto FontDialog para cambiar la fuente del texto
            FontDialog font = new FontDialog();
            //Aplicamos el tipo de fuente al rich text box
            font.Font = richTextBox1.Font;
            //Se hace validacion para que el usuario pueda cambiar la fuente
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }

        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

