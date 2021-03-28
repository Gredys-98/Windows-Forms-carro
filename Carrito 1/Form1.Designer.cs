
namespace Carrito_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1datos = new System.Windows.Forms.Label();
            this.button1crear = new System.Windows.Forms.Button();
            this.label1datos2 = new System.Windows.Forms.Label();
            this.button1encender = new System.Windows.Forms.Button();
            this.button2acelerar = new System.Windows.Forms.Button();
            this.button3Frenar = new System.Windows.Forms.Button();
            this.label1encender = new System.Windows.Forms.Label();
            this.label2velocidad = new System.Windows.Forms.Label();
            this.label3Frenar = new System.Windows.Forms.Label();
            this.button1apagar = new System.Windows.Forms.Button();
            this.label1apagar = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1repro = new System.Windows.Forms.Label();
            this.ListaCanciones = new System.Windows.Forms.ListBox();
            this.BtnAdjuntar = new System.Windows.Forms.PictureBox();
            this.button1interizquierdo = new System.Windows.Forms.Button();
            this.button2interderecho = new System.Windows.Forms.Button();
            this.label1intermienteizquierdo = new System.Windows.Forms.Label();
            this.label1interderecho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdjuntar)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(305, 135);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(216, 108);
            this.Reproductor.TabIndex = 0;
            // 
            // label1datos
            // 
            this.label1datos.AutoSize = true;
            this.label1datos.Location = new System.Drawing.Point(528, 9);
            this.label1datos.Name = "label1datos";
            this.label1datos.Size = new System.Drawing.Size(76, 13);
            this.label1datos.TabIndex = 2;
            this.label1datos.Text = "Caracteristicas";
            // 
            // button1crear
            // 
            this.button1crear.Location = new System.Drawing.Point(344, 9);
            this.button1crear.Name = "button1crear";
            this.button1crear.Size = new System.Drawing.Size(105, 23);
            this.button1crear.TabIndex = 3;
            this.button1crear.Text = "Crear Carro";
            this.button1crear.UseVisualStyleBackColor = true;
            this.button1crear.Click += new System.EventHandler(this.button1crear_Click);
            // 
            // label1datos2
            // 
            this.label1datos2.AutoSize = true;
            this.label1datos2.Location = new System.Drawing.Point(630, 9);
            this.label1datos2.Name = "label1datos2";
            this.label1datos2.Size = new System.Drawing.Size(10, 13);
            this.label1datos2.TabIndex = 4;
            this.label1datos2.Text = ".";
            // 
            // button1encender
            // 
            this.button1encender.Location = new System.Drawing.Point(323, 38);
            this.button1encender.Name = "button1encender";
            this.button1encender.Size = new System.Drawing.Size(142, 23);
            this.button1encender.TabIndex = 5;
            this.button1encender.Text = "Encender Carro";
            this.button1encender.UseVisualStyleBackColor = true;
            this.button1encender.Click += new System.EventHandler(this.button1encender_Click);
            // 
            // button2acelerar
            // 
            this.button2acelerar.Location = new System.Drawing.Point(305, 67);
            this.button2acelerar.Name = "button2acelerar";
            this.button2acelerar.Size = new System.Drawing.Size(75, 23);
            this.button2acelerar.TabIndex = 6;
            this.button2acelerar.Text = "Acelerar";
            this.button2acelerar.UseVisualStyleBackColor = true;
            this.button2acelerar.Click += new System.EventHandler(this.button2acelerar_Click);
            // 
            // button3Frenar
            // 
            this.button3Frenar.Location = new System.Drawing.Point(407, 67);
            this.button3Frenar.Name = "button3Frenar";
            this.button3Frenar.Size = new System.Drawing.Size(75, 23);
            this.button3Frenar.TabIndex = 7;
            this.button3Frenar.Text = "Frenar";
            this.button3Frenar.UseVisualStyleBackColor = true;
            this.button3Frenar.Click += new System.EventHandler(this.button3Frenar_Click);
            // 
            // label1encender
            // 
            this.label1encender.AutoSize = true;
            this.label1encender.Location = new System.Drawing.Point(528, 38);
            this.label1encender.Name = "label1encender";
            this.label1encender.Size = new System.Drawing.Size(68, 13);
            this.label1encender.TabIndex = 8;
            this.label1encender.Text = "Estado Carro";
            // 
            // label2velocidad
            // 
            this.label2velocidad.AutoSize = true;
            this.label2velocidad.Location = new System.Drawing.Point(520, 67);
            this.label2velocidad.Name = "label2velocidad";
            this.label2velocidad.Size = new System.Drawing.Size(87, 13);
            this.label2velocidad.TabIndex = 9;
            this.label2velocidad.Text = "Velocidad Actual";
            // 
            // label3Frenar
            // 
            this.label3Frenar.AutoSize = true;
            this.label3Frenar.Location = new System.Drawing.Point(630, 67);
            this.label3Frenar.Name = "label3Frenar";
            this.label3Frenar.Size = new System.Drawing.Size(81, 13);
            this.label3Frenar.TabIndex = 10;
            this.label3Frenar.Text = "Bajar Velocidad";
            // 
            // button1apagar
            // 
            this.button1apagar.Location = new System.Drawing.Point(356, 279);
            this.button1apagar.Name = "button1apagar";
            this.button1apagar.Size = new System.Drawing.Size(75, 23);
            this.button1apagar.TabIndex = 11;
            this.button1apagar.Text = "Apagar Carro";
            this.button1apagar.UseVisualStyleBackColor = true;
            this.button1apagar.Click += new System.EventHandler(this.button1apagar_Click);
            // 
            // label1apagar
            // 
            this.label1apagar.AutoSize = true;
            this.label1apagar.Location = new System.Drawing.Point(594, 274);
            this.label1apagar.Name = "label1apagar";
            this.label1apagar.Size = new System.Drawing.Size(68, 13);
            this.label1apagar.TabIndex = 12;
            this.label1apagar.Text = "Estado Carro";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|\".mp3\"";
            // 
            // label1repro
            // 
            this.label1repro.AutoSize = true;
            this.label1repro.Location = new System.Drawing.Point(312, 249);
            this.label1repro.Name = "label1repro";
            this.label1repro.Size = new System.Drawing.Size(10, 13);
            this.label1repro.TabIndex = 17;
            this.label1repro.Text = ".";
            // 
            // ListaCanciones
            // 
            this.ListaCanciones.FormattingEnabled = true;
            this.ListaCanciones.Location = new System.Drawing.Point(167, 135);
            this.ListaCanciones.Name = "ListaCanciones";
            this.ListaCanciones.Size = new System.Drawing.Size(132, 108);
            this.ListaCanciones.TabIndex = 18;
            this.ListaCanciones.SelectedIndexChanged += new System.EventHandler(this.ListaCanciones_SelectedIndexChanged);
            // 
            // BtnAdjuntar
            // 
            this.BtnAdjuntar.Image = global::Carrito_1.Properties.Resources.Captura;
            this.BtnAdjuntar.Location = new System.Drawing.Point(279, 249);
            this.BtnAdjuntar.Name = "BtnAdjuntar";
            this.BtnAdjuntar.Size = new System.Drawing.Size(43, 41);
            this.BtnAdjuntar.TabIndex = 19;
            this.BtnAdjuntar.TabStop = false;
            this.BtnAdjuntar.Click += new System.EventHandler(this.BtnAdjuntar_Click);
            // 
            // button1interizquierdo
            // 
            this.button1interizquierdo.Location = new System.Drawing.Point(256, 96);
            this.button1interizquierdo.Name = "button1interizquierdo";
            this.button1interizquierdo.Size = new System.Drawing.Size(124, 23);
            this.button1interizquierdo.TabIndex = 20;
            this.button1interizquierdo.Text = "Intermtente Izquierdo";
            this.button1interizquierdo.UseVisualStyleBackColor = true;
            this.button1interizquierdo.Click += new System.EventHandler(this.button1interizquierdo_Click);
            // 
            // button2interderecho
            // 
            this.button2interderecho.Location = new System.Drawing.Point(438, 96);
            this.button2interderecho.Name = "button2interderecho";
            this.button2interderecho.Size = new System.Drawing.Size(130, 23);
            this.button2interderecho.TabIndex = 21;
            this.button2interderecho.Text = "Intermtente Derecho";
            this.button2interderecho.UseVisualStyleBackColor = true;
            this.button2interderecho.Click += new System.EventHandler(this.button2interderecho_Click);
            // 
            // label1intermienteizquierdo
            // 
            this.label1intermienteizquierdo.AutoSize = true;
            this.label1intermienteizquierdo.Location = new System.Drawing.Point(55, 101);
            this.label1intermienteizquierdo.Name = "label1intermienteizquierdo";
            this.label1intermienteizquierdo.Size = new System.Drawing.Size(35, 13);
            this.label1intermienteizquierdo.TabIndex = 22;
            this.label1intermienteizquierdo.Text = "label1";
            // 
            // label1interderecho
            // 
            this.label1interderecho.AutoSize = true;
            this.label1interderecho.Location = new System.Drawing.Point(574, 96);
            this.label1interderecho.Name = "label1interderecho";
            this.label1interderecho.Size = new System.Drawing.Size(35, 13);
            this.label1interderecho.TabIndex = 23;
            this.label1interderecho.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1interderecho);
            this.Controls.Add(this.label1intermienteizquierdo);
            this.Controls.Add(this.button2interderecho);
            this.Controls.Add(this.button1interizquierdo);
            this.Controls.Add(this.BtnAdjuntar);
            this.Controls.Add(this.ListaCanciones);
            this.Controls.Add(this.label1repro);
            this.Controls.Add(this.label1apagar);
            this.Controls.Add(this.button1apagar);
            this.Controls.Add(this.label3Frenar);
            this.Controls.Add(this.label2velocidad);
            this.Controls.Add(this.label1encender);
            this.Controls.Add(this.button3Frenar);
            this.Controls.Add(this.button2acelerar);
            this.Controls.Add(this.button1encender);
            this.Controls.Add(this.label1datos2);
            this.Controls.Add(this.button1crear);
            this.Controls.Add(this.label1datos);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdjuntar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Label label1datos;
        private System.Windows.Forms.Button button1crear;
        private System.Windows.Forms.Label label1datos2;
        private System.Windows.Forms.Button button1encender;
        private System.Windows.Forms.Button button2acelerar;
        private System.Windows.Forms.Button button3Frenar;
        private System.Windows.Forms.Label label1encender;
        private System.Windows.Forms.Label label2velocidad;
        private System.Windows.Forms.Label label3Frenar;
        private System.Windows.Forms.Button button1apagar;
        private System.Windows.Forms.Label label1apagar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1repro;
        private System.Windows.Forms.ListBox ListaCanciones;
        private System.Windows.Forms.PictureBox BtnAdjuntar;
        private System.Windows.Forms.Button button1interizquierdo;
        private System.Windows.Forms.Button button2interderecho;
        private System.Windows.Forms.Label label1intermienteizquierdo;
        private System.Windows.Forms.Label label1interderecho;
    }
}

