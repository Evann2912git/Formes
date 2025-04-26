using System;
using System.Windows.Forms;
namespace Formes
{
    public partial class FrmFormes : Form
    {
        private const string cote = "cote";
        private const string rayon = "rayon";
        public FrmFormes()
        {
            InitializeComponent();
            RdbCarre_CheckedChanged(null, null);
        }

        private double recupValeur()
        {
            try
            {
                return double.Parse(TxtValeur.Text);
            }
            catch
            {
                return 0;
            }
        }

        private void MiseAJour(IForme uneForme)
        {
            TxtAire.Text = uneForme.aire().ToString();
            if (uneForme is Carre || uneForme is Cercle)
            {
                TxtPerimetre.Text = uneForme.perimetre().ToString();
                TxtVolume.Text = "";
            }
            else 
            {
                TxtPerimetre.Text = "";
                TxtVolume.Text = uneForme.volume().ToString();
            }
        }

        private void RdbCarre_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = cote;
            MiseAJour(new Carre(recupValeur()));
        }

        private void RdbCube_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = cote;
            MiseAJour(new Cube(recupValeur()));
        }

        private void RdbCercle_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = rayon;
            MiseAJour(new Cercle(recupValeur()));
        }

        private void RdbSphere_CheckedChanged(object sender, EventArgs e)
        {
            LblValeur.Text = rayon;
            MiseAJour(new Sphere(recupValeur()));
        }

        private void TxtValeur_TextChanged(object sender, EventArgs e)
        {
            double valeur = recupValeur();
            if (RdbCarre.Checked)
            {
                MiseAJour(new Carre(valeur));
            }
            else if (RdbCube.Checked)
            {
                MiseAJour(new Cube(valeur));
            }
            else if (RdbCercle.Checked)
            {
                MiseAJour(new Cercle(valeur));
            }
            else
            {
                MiseAJour(new Sphere(valeur));
            }
        }
    }
}