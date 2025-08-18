/*using DeepL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTraductorApi
{
    public partial class Form1 : Form
    {
        #region API Key
        private const string DeeplApiKey = "2afcf527-da2a-4209-9fd3-cdb7d68242f7:fx";
        #endregion
        #region Translator variable
        DeepL.Translator translator;
        Dictionary<string, string> languages;
        #endregion

        public Form1()
        {
            InitializeComponent();
            Initialize_Translator();
        }

        private void Initialize_Translator()
        {
            translator = new DeepL.Translator(DeeplApiKey);
            languages = new Dictionary<string, string>
            {
                { "Ingles", LanguageCode.EnglishAmerican },
                { "Español", LanguageCode.Spanish },
                { "Frances", LanguageCode.French },
                { "Italiano", LanguageCode.Italian},
                { "Noruego", LanguageCode.Norwegian },
                { "Aleman", LanguageCode.German },
                { "Holandes", LanguageCode.Dutch },
                { "Polaco", LanguageCode.Polish },
                { "Ruso", LanguageCode.Russian },
                { "Japones", LanguageCode.Japanese },
                { "Portugues", LanguageCode.Portuguese },
                { "Sueco", LanguageCode.Swedish },
                { "Turco", LanguageCode.Turkish },
                { "Korean", LanguageCode.Korean },
            };
            cb_Source_Language.Items.Clear();
            cb_Target_Language.Items.Clear();
            foreach (var language in languages)
            {
                cb_Source_Language.Items.Add(language.Key);
                cb_Target_Language.Items.Add(language.Key);
            }
            cb_Source_Language.SelectedIndex = 0;
            cb_Target_Language.SelectedIndex = 1; 
        }

        private async void btn_Translate_Click(object sender, EventArgs e)
        {
           string inputText = rtb_input.Text;
            string sourceLanguage = string.Empty;
            string TargetLanguage = string.Empty;
            if (languages.ContainsKey(cb_Source_Language.SelectedItem.ToString()))
            {
                sourceLanguage = languages[cb_Source_Language.SelectedItem.ToString()];
            }
            if (languages.ContainsKey(cb_Target_Language.SelectedItem.ToString()))
            {
                TargetLanguage = languages[cb_Target_Language.SelectedItem.ToString()];
            }
            if (string.IsNullOrEmpty(inputText) ||string.IsNullOrWhiteSpace(sourceLanguage) || string.IsNullOrWhiteSpace(TargetLanguage))
            {
                MessageBox.Show("Por favor , ingrese un texto de entrada y seleccione los idiomas de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var translatedtext =await translator.TranslateTextAsync(inputText, sourceLanguage, TargetLanguage);
            rtb_output.Text = translatedtext.Text.ToString();
        }
    }
}
*/
using DeepL; 
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AsyncTraductorApi
{
    public partial class Form1 : Form
    {
        #region API Key
        // Constante que guarda la clave API para autenticar llamadas a DeepL
        private const string DeeplApiKey = "2afcf527-da2a-4209-9fd3-cdb7d68242f7:fx";
        #endregion

        #region Translator variable
        // Instancia del traductor de la API DeepL
        private Translator translator;

        // Diccionario que relaciona nombres legibles de idiomas con sus códigos ISO usados por la API
        private Dictionary<string, string> languages;
        #endregion

        // Constructor del formulario
        public Form1()
        {
            InitializeComponent(); // Inicializa componentes visuales del formulario
            Initialize_Translator(); // Inicializa el traductor y carga idiomas
        }

        // Método para configurar el traductor y llenar los ComboBox con los idiomas disponibles
        private void Initialize_Translator()
        {
            // Crear instancia del traductor usando la API Key
            translator = new Translator(DeeplApiKey);

            // Diccionario con nombre de idioma y su código para la API
            languages = new Dictionary<string, string>
            {
                { "Inglés", "en" },
                { "Español", "es" },
                { "Francés", "fr" },
                { "Italiano", "it" },
                { "Noruego", "no" },
                { "Alemán", "de" },
                { "Holandés", "nl" },
                { "Polaco", "pl" },
                { "Ruso", "ru" },
                { "Japonés", "ja" },
                { "Portugués", "pt" },
                { "Sueco", "sv" },
                { "Turco", "tr" },
                { "Coreano", "ko" },
            };

            // Limpiar ítems previos en ComboBoxes
            cb_Source_Language.Items.Clear();
            cb_Target_Language.Items.Clear();

            // Añadir los nombres de idiomas a los ComboBoxes
            foreach (var language in languages)
            {
                cb_Source_Language.Items.Add(language.Key);
                cb_Target_Language.Items.Add(language.Key);
            }

            // Seleccionar valores por defecto en ambos ComboBoxes (Inglés y Español)
            cb_Source_Language.SelectedIndex = 0;
            cb_Target_Language.SelectedIndex = 1;
        }

        // Evento que se dispara al hacer clic en el botón Traducir
        private async void btn_Translate_Click(object sender, EventArgs e)
        {
            // Obtener texto de entrada
            string inputText = rtb_input.Text;

            // Variables para almacenar códigos de idioma origen y destino
            string sourceLanguage = string.Empty;
            string targetLanguage = string.Empty;

            // Validar y obtener código del idioma seleccionado como origen
            if (languages.ContainsKey(cb_Source_Language.SelectedItem.ToString()))
            {
                sourceLanguage = languages[cb_Source_Language.SelectedItem.ToString()];
            }

            // Validar y obtener código del idioma seleccionado como destino
            if (languages.ContainsKey(cb_Target_Language.SelectedItem.ToString()))
            {
                targetLanguage = languages[cb_Target_Language.SelectedItem.ToString()];
            }

            // Validar que texto y selección de idiomas no estén vacíos
            if (string.IsNullOrEmpty(inputText) || string.IsNullOrWhiteSpace(sourceLanguage) || string.IsNullOrWhiteSpace(targetLanguage))
            {
                MessageBox.Show("Por favor, ingrese un texto de entrada y seleccione los idiomas de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Terminar ejecución si falta algún dato
            }

            try
            {
                // Llamada asíncrona para traducir texto usando la API DeepL
                var translatedText = await translator.TranslateTextAsync(inputText, sourceLanguage, targetLanguage);

                // Mostrar texto traducido en el RichTextBox de salida
                rtb_output.Text = translatedText.Text;
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar mensaje con detalle para el usuario
                MessageBox.Show($"Error al traducir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para cuando cambia la selección en el ComboBox del idioma origen (vacío, puede implementarse si se desea)
        private void cb_Source_Language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtb_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            rtb_input.Clear(); // Limpia el RichTextBox de entrada
            rtb_output.Clear(); // Limpia el RichTextBox de salida
        }
    }
}

