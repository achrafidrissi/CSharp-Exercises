namespace Serie1_TP3_Photocopie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier si l'entrée est valide
            if (!int.TryParse(nbr.Text, out int nombrePhotocopies) || nombrePhotocopies < 0)
            {
                MessageBox.Show("Veuillez entrer un nombre valide de photocopies.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcul du coût en fonction du nombre de photocopies
            double totalAPayer = CalculerFacture(nombrePhotocopies);

            // Affichage du résultat dans la TextBox `total`
            total.Text = totalAPayer.ToString("0.00") + " Dhs";
        }
        private double CalculerFacture(int n)
        {
            double total = 0;

            if (n <= 10)
            {
                total = n * 0.5;  // 0.5 Dhs par copie pour les 10 premières
            }
            else if (n <= 30)
            {
                total = (10 * 0.5) + ((n - 10) * 0.25); // 0.25 Dhs par copie de 11 à 30
            }
            else
            {
                total = (10 * 0.5) + (20 * 0.25) + ((n - 30) * 0.1); // 0.1 Dhs au-delà de 30
            }

            return total;
        }
    }
}
