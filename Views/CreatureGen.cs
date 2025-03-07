using GranDnDDM.Models.Creatura;
using GranDnDDM.Tools;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class CreatureGen : Form
    {
        private Creatura creatura;
        private NightLabel lblActual;
        public CreatureGen()
        {
            InitializeComponent();

        }
        public CreatureGen(Creatura c)
        {
            InitializeComponent();
            creatura = c;

            if (creatura == null) return;

            // --- Nombre y alineación ---
            lblName.Text = creatura.Nombre;
            lblOtrosDatos.Text = $"{creatura.Tamanio} {creatura.Tipo}, {creatura.Alineamiento}";

            // --- Clase de Armadura y Puntos de Golpe ---
            lblCA.Text = $"{creatura.ClaseArmadura}";
            lblPubtosGolpe.Text = $"{creatura.PuntosGolpe} ({creatura.DadosGolpe})";

            // --- Velocidades ---
            lblVelocidades.Text = $"Caminar: {creatura.VelocidadCaminar} pies";
            if (creatura.VelocidadVolar > 0) lblVelocidades.Text += $", Volar: {creatura.VelocidadVolar} pies";
            if (creatura.VelocidadNadar > 0) lblVelocidades.Text += $", Nadar: {creatura.VelocidadNadar} pies";
            if (creatura.VelocidadEscalado > 0) lblVelocidades.Text += $", Escalar: {creatura.VelocidadEscalado} pies";
            if (creatura.VelocidadCavar > 0) lblVelocidades.Text += $", Cavar: {creatura.VelocidadCavar} pies";

            // --- Estadísticas de habilidad ---
            lblFuerza.Text = $"{creatura.Fuerza} ({creatura.BonificadorFuerza})";
            lblDestreza.Text = $"{creatura.Destreza} ({creatura.BonificadorDestreza})";
            lblConstitucion.Text = $"{creatura.Constitucion} ({creatura.BonificadorConstitucion})";
            lblInteligencia.Text = $"{creatura.Inteligencia} ({creatura.BonificadorInteligencia})";
            lblSabiduria.Text = $"{creatura.Sabiduria} ({creatura.BonificadorSabiduria})";
            lblCarisma.Text = $"{creatura.Carisma} ({creatura.BonificadorCarisma})";


            // --- Habilidades, resistencias, inmunidades ---
            lblTiradasSalvacion.Text = string.Join(", ", creatura.Salvacion);
            lblSkills.Text = GlobalTools.ConvertDictionaryToString(creatura.Habilidades);
            AddTextLabels("Resistencias al daño", string.Join(", ", creatura.ResistenciasDano));
            AddTextLabels("Inmunidades al daño", string.Join(", ", creatura.InmunidadesDano));
            AddTextLabels("Inmunidades a condiciones", string.Join(", ", creatura.InmunidadesCondicion));
            AddTextLabels("Idiomas", string.Join(", ", creatura.Idiomas.Keys));

            // --- Acciones ---
            AddActionsLabels("Acciones", creatura.Acciones);
            AddActionsLabels("Acciones Adicionales", creatura.AccionesAdicionales);
            AddActionsLabels("Reacciones", creatura.Reacciones);
            AddActionsLabels("Acciones Legendarias", creatura.AccionesLegendarias
    .Select(a => new Accion { Nombre = a.Nombre, Descripcion = a.Descripcion })
    .ToList());
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreatureEditor edir = new CreatureEditor();
            edir.ShowDialog();
        }


        private void AddTextLabels(string title, string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return;

            var titleLabel = new Label
            {
                Text = title,
                Font = new Font("Comic Sans MS", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 192, 128),
                AutoSize = true
            };

            var contentLabel = new Label
            {
                Text = content,
                Font = new Font("Comic Sans MS", 11F),
                ForeColor = Color.White,
                AutoSize = true,
                MaximumSize = new Size(pCard.Width - 20, 0)
            };

            flowLayoutPanel1.Controls.Add(titleLabel);
            flowLayoutPanel1.Controls.Add(contentLabel);
        }

        private void AddActionsLabels(string title, List<Accion> actions)
        {
            if (actions == null || actions.Count == 0) return;

            var titleLabel = new Label
            {
                Text = title,
                Font = new Font("Comic Sans MS", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 192, 128),
                AutoSize = true
            };

            flowLayoutPanel1.Controls.Add(titleLabel);

            foreach (var action in actions)
            {
                var actionLabel = new Label
                {
                    Text = $"{action.Nombre}: {action.Descripcion}",
                    Font = new Font("Comic Sans MS", 11F),
                    ForeColor = Color.White,
                    AutoSize = true,
                    MaximumSize = new Size(pCard.Width - 20, 0)
                };
                flowLayoutPanel1.Controls.Add(actionLabel);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        ////////////
    }
}
