using System;
using System.Linq;
using System.Drawing;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace FirmaCurierat_UI_WindowsForms
{
    public static class FormValidator
    {
        private const int NR_MAX_CARACTERE = 50;

        public class ControaleValidare
        {
            public (MetroTextBox TextBox, MetroLabel LabelEroare)[] CampuriText { get; set; }
            public MetroLabel LabelEroareGreutate { get; set; }
            public string GreutateText { get; set; }
            public MetroLabel LabelEroareOptiuniLivrare { get; set; }
            public DateTimePicker DataLivrarePicker { get; set; }
            public MetroLabel LabelEroareDataLivrare { get; set; }
            public CheckBox[] CheckBoxes { get; set; }
            public MetroLabel LabelEroareDimensiune { get; set; }
            public RadioButton[] RadioButtons { get; set; }
        }

        public static bool Prevalidare(ControaleValidare controale)
        {
            bool areErori = false;

            foreach (var (textBox, labelEroare) in controale.CampuriText)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    labelEroare.Text = "Campul nu poate fi gol!";
                    labelEroare.ForeColor = Color.Red;
                    areErori = true;
                }
                else
                {
                    labelEroare.Text = string.Empty;
                }
            }

            if (decimal.TryParse(controale.GreutateText, out decimal greutate))
            {
                if (greutate < 0.01m)
                {
                    controale.LabelEroareGreutate.Text = "Valoarea nu poate fi 0!";
                    controale.LabelEroareGreutate.ForeColor = Color.Red;
                    areErori = true;
                }
                else
                {
                    controale.LabelEroareGreutate.Text = string.Empty;
                }
            }
            else
            {
                controale.LabelEroareGreutate.Text = "Campul nu poate fi gol!";
                controale.LabelEroareGreutate.ForeColor = Color.Red;
                areErori = true;
            }

            if (!controale.RadioButtons.Any(rb => rb.Checked))
            {
                controale.LabelEroareDimensiune.Text = "Trebuie sa selectati o dimensiune pentru colet!";
                controale.LabelEroareDimensiune.ForeColor = Color.Red;
                areErori = true;
            }
            else
            {
                controale.LabelEroareDimensiune.Text = string.Empty;
            }

            return areErori;
        }


        public static bool Validare(ControaleValidare controale)
        {
            bool areErori = false;

            foreach (var (textBox, labelEroare) in controale.CampuriText)
            {
                if (textBox.Text.Length > NR_MAX_CARACTERE)
                {
                    labelEroare.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                    labelEroare.ForeColor = Color.Red;
                    areErori = true;
                }
            }

            if (controale.DataLivrarePicker != null && controale.LabelEroareDataLivrare != null)
            {
                if (controale.DataLivrarePicker.Value.Date < DateTime.Now.Date)
                {
                    controale.LabelEroareDataLivrare.Text = "Data nu poate fi in trecut!";
                    controale.LabelEroareDataLivrare.ForeColor = Color.Red;
                    areErori = true;
                }
                else
                {
                    controale.LabelEroareDataLivrare.Text = string.Empty;
                }
            }

            return areErori;
        }
    }
}
