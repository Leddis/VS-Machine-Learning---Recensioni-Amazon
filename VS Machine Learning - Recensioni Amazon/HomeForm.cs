using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Newtonsoft.Json;
using NumSharp;
using NumSharp.Extensions;
using NumSharp.Utilities;

namespace VS_Machine_Learning___Recensioni_Amazon
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            string percorso = "amazon_co-ecommerce_sample.csv";
            var dati = File.ReadAllLines(percorso);
            var recensioni_utenti = new List<string>();
            var media_recensioni = new List<double>();
            foreach (var line in dati.Skip(1))
            {
                var colonna = line.Split(',');
                var recensione = colonna[6];
                var valutazione = double.Parse(colonna[7]);
                if (!string.IsNullOrEmpty(recensione) && !double.IsNaN(valutazione))
                {
                    recensioni_utenti.Add(recensione);
                    media_recensioni.Add(valutazione);
                }
            }

            var X_train = recensioni_utenti.Take((int)(0.8 * recensioni_utenti.Count())).ToArray();
            var X_test = recensioni_utenti.Skip((int)(0.8 * recensioni_utenti.Count())).ToArray();
            var y_train = media_recensioni.Take((int)(0.8 * media_recensioni.Count())).ToArray();
            var y_test = media_recensioni.Skip((int)(0.8 * media_recensioni.Count())).ToArray();

            var vectorizer = new CountVectorizer(stopWords: "english");
            var X_train_vectors = vectorizer.FitTransform(X_train).toarray();
            var X_test_vectors = vectorizer.Transform(X_test).toarray();

            var modello = new MultinomialNB();
            modello.Fit(X_train_vectors, y_train);

            var previsione = modello.Predict(X_test_vectors);
            var accuratezza = AccuracyScore(y_test, previsione);
            MessageBox.Show("Accuratezza: " + (accuratezza * 100).ToString("F2") + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Prevedi la valutazione della recensione inserita dall'utente
            var recensione = txtReview.Text;
            var vectorizer = new TfidfVectorizer(stopWords: "english");
            var modello = new MultinomialNB();
            var formatter = new BinaryFormatter();
            var bytes = Convert.FromBase64String(Properties.Resources.trained_model);
            using (var ms = new MemoryStream(bytes))
            {
                modello = (MultinomialNB)formatter.Deserialize(ms);
            }
            var vector = vectorizer.Transform(new string[] { recensione }).ToNumSharpArray<double>();
            var valutazione_prevista = modello.Predict(vector.reshape(1, vector.size)).FirstOrDefault();

            MessageBox.Show("Valutazione prevista: " + valutazione_prevista.ToString("F1"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La prova sta nello scrivere una recensione e in base ad essa \n" +
                "il modello della ML cerca di predire se la recensione è negativa o meno\n" +
                "e calcola un ipotetico punteggio che si potrebbe assegnare al prodotto recensito");
        }
    }
}