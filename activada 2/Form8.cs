using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activada_2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            // Configuración inicial del formulario
            this.Text = "Selecciona tu plan";
            this.Size = new System.Drawing.Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Etiqueta principal
            Label titleLabel = new Label();
            titleLabel.Text = "Elige el plan de tu preferencia";
            titleLabel.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            titleLabel.Dock = DockStyle.Top;
            this.Controls.Add(titleLabel);

            // Tabla para organizar los elementos
            TableLayoutPanel table = new TableLayoutPanel();
            table.RowCount = 10;
            table.ColumnCount = 4;
            table.Dock = DockStyle.Fill;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            this.Controls.Add(table);

            // Encabezados de columnas
            table.Controls.Add(new Label() { Text = "", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 0, 0);
            table.Controls.Add(new Label() { Text = "PLAN Black", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 1, 0);
            table.Controls.Add(new Label() { Text = "PLAN Fit", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 2, 0);
            table.Controls.Add(new Label() { Text = "PLAN Smart", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, 0);

            // Opciones
            string[] opciones = {
                "Área de cardio",
                "Área de peso libre e integrado",
                "Acceso a salón de clases dirigidas ilimitado",
                "Lockers y duchas",
                "Medición de composición corporal - Smart Vital",
                "Smart Fit App",
                "Acceso limitado a la zona Smart Spa",
                "Invita hasta 5 amigos por mes gratis"
            };

            bool[,] beneficios = {
                { true, true, true },
                { true, true, true },
                { true, true, true },
                { true, true, true },
                { true, false, false },
                { true, true, false },
                { true, false, false },
                { true, false, false }
            };

            for (int i = 0; i < opciones.Length; i++)
            {
                table.Controls.Add(new Label() { Text = opciones[i], TextAlign = System.Drawing.ContentAlignment.MiddleLeft }, 0, i + 1);
                for (int j = 0; j < 3; j++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Checked = beneficios[i, j];
                    checkBox.Enabled = false;
                    table.Controls.Add(checkBox, j + 1, i + 1);
                }
            }

            // Botones de acción
            Button btnBlack = new Button();
            btnBlack.Text = "COMENZAR";
            btnBlack.Dock = DockStyle.Fill;
            table.Controls.Add(btnBlack, 1, opciones.Length + 1);

            Button btnFit = new Button();
            btnFit.Text = "COMENZAR";
            btnFit.Dock = DockStyle.Fill;
            table.Controls.Add(btnFit, 2, opciones.Length + 1);

            Button btnSmart = new Button();
            btnSmart.Text = "COMENZAR";
            btnSmart.Dock = DockStyle.Fill;
            table.Controls.Add(btnSmart, 3, opciones.Length + 1);

            // Precios
            table.Controls.Add(new Label() { Text = "$17.45* + IVA\nmensual por 3 meses, después\n$37.99 + IVA", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 1, opciones.Length + 2);
            table.Controls.Add(new Label() { Text = "$34.99 + IVA\n12 meses de fidelidad", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 2, opciones.Length + 2);
            table.Controls.Add(new Label() { Text = "$37.99 + IVA\nSin fidelidad", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, opciones.Length + 2);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
          [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form8());
        }
    }
}
