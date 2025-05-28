
using System;
using System.IO;
using System.Windows.Forms;

namespace BlueOdyssey
{
    public partial class Form1 : Form
    {
        string[] destinos = { "Bahamas", "Jamaica", "Cuba", "Puerto Rico", "Aruba" };
        double[,] precios = {
            { 300, 350, 400, 450, 500 },
            { 400, 450, 500, 550, 600 },
            { 600, 650, 700, 750, 800 }
        };
        int edadUsuario = 0;

        public Form1()
        {
            InitializeComponent();
            comboBoxDestino.Items.AddRange(destinos);
            comboBoxCabina.Items.AddRange(new string[] { "Económica", "Estándar", "Lujo" });
            dateTimePickerSalida.MinDate = DateTime.Today;
            SolicitarEdad();
        }

        private void SolicitarEdad()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su edad:", "Edad del pasajero", "25");
            int edad;
            if (int.TryParse(input, out edad))
            {
                edadUsuario = edad;
                string categoria = "";
                if (edad < 12) categoria = "Niño - Tarifa especial";
                else if (edad < 60) categoria = "Adulto";
                else categoria = "Adulto mayor - Descuento aplicado";
                MessageBox.Show("Categoría detectada: " + categoria, "Información de Edad");
            }
            else
            {
                MessageBox.Show("Edad inválida. Se asignará como adulto por defecto.");
                edadUsuario = 30;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxDestino.SelectedItem != null)
                listBoxRuta.Items.Add(comboBoxDestino.SelectedItem.ToString());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listBoxRuta.Items.Count == 0 || comboBoxCabina.SelectedIndex == -1 || dateTimePickerSalida.Value < DateTime.Today)
            {
                MessageBox.Show("Complete todos los campos correctamente.");
                return;
            }

            int tipoCabina = comboBoxCabina.SelectedIndex;
            double total = 0;
            foreach (string destino in listBoxRuta.Items)
                for (int i = 0; i < destinos.Length; i++)
                    if (destino == destinos[i])
                        total += precios[tipoCabina, i];

            if (edadUsuario < 12) total *= 0.5;
            else if (edadUsuario >= 60) total *= 0.8;

            labelCosto.Text = "Costo total: $" + total;
            string nombreArchivo = $"reserva_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string rutaArchivo = Path.Combine("Reservas", nombreArchivo);
            Directory.CreateDirectory("Reservas");
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine("Reserva: " + DateTime.Now);
                sw.WriteLine("Edad del pasajero: " + edadUsuario);
                sw.WriteLine("Fecha de salida: " + dateTimePickerSalida.Value.ToShortDateString());
                sw.WriteLine("Tipo de cabina: " + comboBoxCabina.SelectedItem);
                sw.WriteLine("Ruta:");
                foreach (string destino in listBoxRuta.Items)
                    sw.WriteLine(" - " + destino);
                sw.WriteLine("Costo total: $" + total);
                sw.WriteLine(new string('-', 40));
            }

            MessageBox.Show("Reserva guardada correctamente.");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void ReiniciarFormulario()
        {
            listBoxRuta.Items.Clear();
            comboBoxCabina.SelectedIndex = -1;
            comboBoxDestino.SelectedIndex = -1;
            dateTimePickerSalida.Value = DateTime.Today;
            labelCosto.Text = "";
        }
    }
}
