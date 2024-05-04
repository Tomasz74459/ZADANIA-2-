using System;
using System.Windows.Forms;

namespace DzielenieLiczb
{
    public partial class Form1 : Form
    {
        private TextBox textBoxDzielna;
        private TextBox textBoxDzielnik;
        private TextBox textBoxWynik;
        private Label labelDzielna;
        private Label labelDzielnik;
        private Label labelWynik;

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxes();
            InitializeLabels();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // Ustawienia okna
            this.ClientSize = new System.Drawing.Size(250, 180);
            this.Name = "Form1";
            this.Text = "Dzielenie Liczb";
            // Dodanie obsługi zdarzenia kliknięcia przycisku
            Button button = new Button();
            button.Text = "Dziel";
            button.Location = new System.Drawing.Point(20, 140);
            button.Click += new EventHandler(button_Click);
            this.Controls.Add(button);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitializeTextBoxes()
        {
            textBoxDzielna = new TextBox();
            textBoxDzielna.Location = new System.Drawing.Point(20, 15);
            textBoxDzielna.Size = new System.Drawing.Size(200, 40);
            this.Controls.Add(textBoxDzielna);

            textBoxDzielnik = new TextBox();
            textBoxDzielnik.Location = new System.Drawing.Point(20, 55);
            textBoxDzielnik.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(textBoxDzielnik);

            textBoxWynik = new TextBox();
            textBoxWynik.Location = new System.Drawing.Point(20, 95);
            textBoxWynik.Size = new System.Drawing.Size(200, 20);
            textBoxWynik.ReadOnly = true; // Wynik będzie tylko do odczytu
            this.Controls.Add(textBoxWynik);
        }

        private void InitializeLabels()
        {
            labelDzielna = new Label();
            labelDzielna.Text = "Dzielna:";
            labelDzielna.AutoSize = true;
            labelDzielna.Location = new System.Drawing.Point(20, 0);
            this.Controls.Add(labelDzielna);

            labelDzielnik = new Label();
            labelDzielnik.Text = "Dzielnik:";
            labelDzielnik.AutoSize = true;
            labelDzielnik.Location = new System.Drawing.Point(20, 40);
            this.Controls.Add(labelDzielnik);

            labelWynik = new Label();
            labelWynik.Text = "Wynik:";
            labelWynik.AutoSize = true;
            labelWynik.Location = new System.Drawing.Point(20, 80);
            this.Controls.Add(labelWynik);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxDzielna.Text) && !string.IsNullOrWhiteSpace(textBoxDzielnik.Text))
            {
                if (double.TryParse(textBoxDzielna.Text, out double dzielna) && double.TryParse(textBoxDzielnik.Text, out double dzielnik))
                {
                    if (dzielnik != 0)
                    {
                        double wynik = dzielna / dzielnik;
                        textBoxWynik.Text = wynik.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nie można dzielić przez zero!", "Hello World!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowe liczby!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wprowadź wartości do wszystkich pól!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}