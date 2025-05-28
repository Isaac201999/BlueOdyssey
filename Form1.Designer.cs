namespace BlueOdyssey
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ListBox listBoxRuta;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.ComboBox comboBoxCabina;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Button btnReiniciar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.listBoxRuta = new System.Windows.Forms.ListBox();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCabina = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labelCosto = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // comboBoxDestino
            this.comboBoxDestino.Location = new System.Drawing.Point(30, 30);
            this.comboBoxDestino.Size = new System.Drawing.Size(200, 21);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(240, 30);
            this.btnAgregar.Text = "Agregar destino";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // listBoxRuta
            this.listBoxRuta.Location = new System.Drawing.Point(30, 70);
            this.listBoxRuta.Size = new System.Drawing.Size(200, 95);

            // dateTimePickerSalida
            this.dateTimePickerSalida.Location = new System.Drawing.Point(30, 180);

            // comboBoxCabina
            this.comboBoxCabina.Location = new System.Drawing.Point(30, 220);
            this.comboBoxCabina.Size = new System.Drawing.Size(200, 21);

            // btnConfirmar
            this.btnConfirmar.Location = new System.Drawing.Point(30, 260);
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);

            // btnReiniciar
            this.btnReiniciar.Location = new System.Drawing.Point(150, 260);
            this.btnReiniciar.Size = new System.Drawing.Size(120, 23);
            this.btnReiniciar.Text = "Nueva Reserva";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);

            // labelCosto
            this.labelCosto.Location = new System.Drawing.Point(30, 300);
            this.labelCosto.Size = new System.Drawing.Size(300, 23);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBoxRuta);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.comboBoxCabina);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.labelCosto);
            this.Name = "Form1";
            this.Text = "Reservas de Crucero";
            this.ResumeLayout(false);
        }
    }
}
