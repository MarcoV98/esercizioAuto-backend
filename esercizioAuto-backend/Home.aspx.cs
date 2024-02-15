using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace esercizioAuto_backend
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaricaImmaginiAuto();
            }
        }

        protected void ddlAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaricaImmaginiAuto();
        }

        private void CaricaImmaginiAuto()
        {
            string autoSelezionata = ddlAuto.SelectedValue;
            string percorsoImmagine = $"~/assets/{autoSelezionata.ToLower()}.jpg";

            imgAuto.ImageUrl = percorsoImmagine;

            switch (autoSelezionata)
            {
                case "FiatPanda":
                    lblPrezzoBase.Text = "Prezzo di base: EUR 10,000";
                    break;
                case "FordFiesta":
                    lblPrezzoBase.Text = "Prezzo di base: EUR 20,000";
                    break;
                case "AudiQ3":
                    lblPrezzoBase.Text = "Prezzo di base: EUR 40,000";
                    break;
                case "LamborghiniUrus":
                    lblPrezzoBase.Text = "Prezzo di base: EUR 200,000";
                    break;
            }
        }

        protected void btnCalcola_Click(object sender, EventArgs e)
        {
            CalcolaPreventivo();
        }

        private void CalcolaPreventivo()
        {
            string autoSelezionata = ddlAuto.SelectedValue;
            decimal prezzoBase = 0;

            switch (autoSelezionata)
            {
                case "FiatPanda":
                    prezzoBase = 10000;
                    break;
                case "FordFiesta":
                    prezzoBase = 20000;
                    break;
                case "AudiQ3":
                    prezzoBase = 40000;
                    break;
                case "LamborghiniUrus":
                    prezzoBase = 200000;
                    break;
            }

            decimal totaleOptional = 0;
            if (chkFinestrini.Checked)
            {
                totaleOptional += 100;
            }
            if (chkCerchi.Checked)
            {
                totaleOptional += 250;
            }
            if (chkStereo.Checked)
            {
                totaleOptional += 500;
            }

            
            int anniGaranzia;
            if (int.TryParse(txtGaranzia.Text, out anniGaranzia))
            {
                decimal totaleGaranzia = anniGaranzia * 120;

                
                decimal totaleComplessivo = prezzoBase + totaleOptional + totaleGaranzia;

                
                lblPrezzoBase.Text = "Prezzo di base: " + prezzoBase.ToString("C");
                lblTotaleOptional.Text = "Totale Optional: " + totaleOptional.ToString("C");
                lblTotaleGaranzia.Text = "Totale Garanzia: " + totaleGaranzia.ToString("C");
                lblTotaleComplessivo.Text = "Totale Complessivo: " + totaleComplessivo.ToString("C");
            }
            else
            {
                lblTotaleGaranzia.Text = "Errore: Inserisci un numero valido per la garanzia.";
            }
        }
    }
}