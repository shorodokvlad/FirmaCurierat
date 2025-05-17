using System.Linq;
using System.Drawing;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace FirmaCurierat_UI_WindowsForms
{
    public static class FormValidator
    {
        private const int NR_MAX_CARACTERE = 50;

        public static bool Prevalidare(
            (MetroTextBox TextBox, MetroLabel LabelEroare)[] campuriDeValidat,
            MetroLabel mlblEroareGreutate,
            string greutateText,
            MetroLabel mlblEroareOptiuniLivrare,
            CheckBox[] checkBoxes,
            MetroLabel mlblEroareDimensiune,
            RadioButton[] radioButtons)
        {
            bool areErori = false;

            foreach (var (textBox, labelEroare) in campuriDeValidat)
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

            if (decimal.TryParse(greutateText, out decimal greutate))
            {
                if (greutate < 0.01m)
                {
                    mlblEroareGreutate.Text = "Valoarea nu poate fi 0!";
                    mlblEroareGreutate.ForeColor = Color.Red;
                    areErori = true;
                }
                else
                {
                    mlblEroareGreutate.Text = string.Empty;
                }
            }
            else
            {
                mlblEroareGreutate.Text = "Campul nu poate fi gol!";
                mlblEroareGreutate.ForeColor = Color.Red;
                areErori = true;
            }

            if (!checkBoxes.Any(cb => cb.Checked))
            {
                mlblEroareOptiuniLivrare.Text = "Trebuie sa selectati cel putin o optiune de livrare!";
                mlblEroareOptiuniLivrare.ForeColor = Color.Red;
                areErori = true;
            }
            else
            {
                mlblEroareOptiuniLivrare.Text = string.Empty;
            }

            if (!radioButtons.Any(rb => rb.Checked))
            {
                mlblEroareDimensiune.Text = "Trebuie sa selectati o dimensiune pentru colet!";
                mlblEroareDimensiune.ForeColor = Color.Red;
                areErori = true;
            }
            else
            {
                mlblEroareDimensiune.Text = string.Empty;
            }

            return areErori;
        }

        public static bool Validare(
            (MetroTextBox TextBox, MetroLabel LabelEroare)[] campuriDeValidat)
        {
            bool areErori = false;

            foreach (var (textBox, labelEroare) in campuriDeValidat)
            {
                if (textBox.Text.Length > NR_MAX_CARACTERE)
                {
                    labelEroare.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                    labelEroare.ForeColor = Color.Red;
                    areErori = true;
                }
            }

            return areErori;
        }
    }
}
