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
            tabAGuarida.Visible = false;
            tabALegends.Visible = false;
            tabAMitica.Visible = false;
            var tabAMiticaHide = tabPagesCreatura.TabPages["tabAMitica"];
            if (tabAMiticaHide != null && !creatura.EsMitica)
            {
                tabPagesCreatura.TabPages.Remove(tabAMiticaHide);
            }
            
            var tabALegendsHide = tabPagesCreatura.TabPages["tabALegends"];
            if (tabALegendsHide != null && !creatura.EsLegendaria)
            {
                tabPagesCreatura.TabPages.Remove(tabALegendsHide);
            }
            
            var tabAGuaridaHide = tabPagesCreatura.TabPages["tabAGuarida"];
            if (tabAGuaridaHide != null && !creatura.TieneGuarida)
            {
                tabPagesCreatura.TabPages.Remove(tabAGuaridaHide);
            }
            
            var tabEfectoRegional = tabPagesCreatura.TabPages["tabERegional"];
            if (tabEfectoRegional != null && !creatura.TieneEfectosRegionales)
            {
                tabPagesCreatura.TabPages.Remove(tabEfectoRegional);
            }

            if(creatura.Imagen != null)
            {
                if (creatura.Imagen.Length > 0)
                {
                    imgCreatura.Image = GlobalTools.ConvertBase64ToImage(creatura.Imagen);
                }
            }


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
            if (creatura.Salvacion.Count == 0)
            {
                flpSaveT.Visible = false;
            }
            else
            {
                flpSaveT.Visible = true;
                lblTiradasSalvacion.Text = creatura.Salvacion.Count > 0 ? string.Join(", ", creatura.Salvacion) : "Ninguna";
            }
            string skills = GlobalTools.ConvertDictionaryToString(creatura.Habilidades);
            if (skills == "")
            {
                flpSkills.Visible = false;
            }
            else
            {
                flpSkills.Visible = true;
                lblSkills.Text = skills != "" ? skills : "Ninguna";
            }

            if (creatura.ResistenciasDano.Count == 0)
            {
                flpInmuDa.Visible = false;
            }
            else
            {
                flpInmuDa.Visible = true;
                lblInmudamge.Text = creatura.ResistenciasDano.Count > 0 ? string.Join(", ", creatura.ResistenciasDano) : "Ninguno";
            }


            if (creatura.Sentidos.Count > 0)
            {
                flpSentidos.Visible = false;
            }
            else
            {
                flpSentidos.Visible = true;
                lblSentidos.Text = creatura.Sentidos.Count > 0 ? string.Join(", ", creatura.Sentidos) : "Ninguno";
            }

            if (creatura.Idiomas.Count == 0)
            {
                flpIdiomas.Visible = false;
            }
            else
            {
                flpIdiomas.Visible = true;
                lblIdiomas.Text = creatura.Idiomas.Count > 0 ? GlobalTools.ConvertDictionaryToString(creatura.Idiomas) : "Ninguno";
            }

            if (creatura.InmunidadesCondicion.Count == 0)
            {
                flpCondiciones.Visible = false;
            }
            else
            {
                flpCondiciones.Visible = true;
                lblCondiciones.Text = creatura.InmunidadesCondicion.Count > 0 ? string.Join(", ", creatura.InmunidadesCondicion) : "Ninguno";
            }

            lblNivelDesafio.Text = creatura.CR + "/" + creatura.XP;
            if (creatura.Acciones.Count > 0)
            {
                pAcciones.Visible = true;
                foreach (var action in creatura.Acciones)
                {
                    var actionLabel = new Label
                    {
                        Text = $"{action.Nombre}: {action.Descripcion}",
                        Font = new Font("Comic Sans MS", 11F),
                        ForeColor = Color.White,
                        AutoSize = true,
                        Margin = new Padding(10),
                        MaximumSize = new Size(pCard.Width - 20, 0)
                    };
                    pAcciones.Controls.Add(actionLabel);
                }
            }
            if (creatura.AccionesAdicionales.Count > 0)
            {
                pAcciones.Visible = true;
                foreach (var action in creatura.AccionesAdicionales)
                {
                    var actionLabel = new Label
                    {
                        Text = $"{action.Nombre}: {action.Descripcion}",
                        Font = new Font("Comic Sans MS", 11F),
                        ForeColor = Color.White,
                        AutoSize = true,
                        Margin = new Padding(10),
                        MaximumSize = new Size(pCard.Width - 20, 0)
                    };
                    pAccionAdicional.Controls.Add(actionLabel);
                }
            }
            if (creatura.AccionesLegendarias.Count > 0)
            {
                pAcciones.Visible = true;
                foreach (var action in creatura.AccionesLegendarias)
                {
                    var actionLabel = new Label
                    {
                        Text = $"{action.Nombre}: {action.Descripcion}",
                        Font = new Font("Comic Sans MS", 11F),
                        ForeColor = Color.White,
                        AutoSize = true,
                        Margin = new Padding(10),
                        MaximumSize = new Size(pCard.Width - 20, 0)
                    };
                    pAccionLegendaria.Controls.Add(actionLabel);
                }
            }
            if (creatura.AccionesGuarida.Count > 0)
            {
                pAcciones.Visible = true;
                foreach (var action in creatura.AccionesGuarida)
                {
                    var actionLabel = new Label
                    {
                        Text = $"{action.Nombre}: {action.Descripcion}",
                        Font = new Font("Comic Sans MS", 11F),
                        ForeColor = Color.White,
                        AutoSize = true,
                        Margin = new Padding(10),
                        MaximumSize = new Size(pCard.Width - 20, 0)
                    };
                    pAccionGuarida.Controls.Add(actionLabel);
                }
            }
            if (creatura.AccionesMiticas.Count > 0)
            {
                pAcciones.Visible = true;
                foreach (var action in creatura.AccionesMiticas)
                {
                    var actionLabel = new Label
                    {
                        Text = $"{action.Nombre}: {action.Descripcion}",
                        Font = new Font("Comic Sans MS", 11F),
                        ForeColor = Color.White,
                        AutoSize = true,
                        Margin = new Padding(10),
                        MaximumSize = new Size(pCard.Width - 20, 0)
                    };
                    pAccionMitica.Controls.Add(actionLabel);
                }
            }
            if (creatura.EfectosRegionales.Count > 0)
            {
                pAcciones.Visible = true;
                foreach (var action in creatura.EfectosRegionales)
                {
                    var actionLabel = new Label
                    {
                        Text = $"{action.Nombre}: {action.Descripcion}",
                        Font = new Font("Comic Sans MS", 11F),
                        ForeColor = Color.White,
                        AutoSize = true,
                        Margin = new Padding(10),
                        MaximumSize = new Size(pCard.Width - 20, 0)
                    };
                    pEfectoRegio.Controls.Add(actionLabel);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        ////////////
    }
}
