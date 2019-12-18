using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// LIBRERIAS DE VOZ
using System.Speech.Recognition;
// libreria para SOnidos de la Maquina
using System.Speech.Synthesis;
//LIBRERIA PARA SONIDO
using System.Media;

namespace ReconocedorVoz
{
    public partial class VENTANA_Z : Form
    {
        public VENTANA_Z()
        {
            InitializeComponent();
        }

// permite poder modificar la velocidad con que se reproduce el audio
        SpeechSynthesizer syntesis = new SpeechSynthesizer();

// objeto que permitira escucar lo que el usuario diga
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

    // Bariable para SONIDO
        SoundPlayer Player;

// ** *** ** ** *** ** ** *** ** ** *** CONTROL DE Información INICIAL *** ** ** *** ** ** *** ** ** *** **
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // ABRE APARECE LA IIMGEN PARA PUERTO
            pictureBox2.Visible = true;
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("AS DOBLE CLIC EN LA IMAGEN, PARA ABRIR EL PUERTO DE VOZ");
            syntesis.Speak("REPITE...");

            //SE DA LA RUTA DEL ACHIVO DEL SONIDO TIPO WAV
            Player = new SoundPlayer("Z.wav");
            // INICIA EL AUDIO
            Player.Play();
        }

// ~~~~~~~~~~~~~~~~~ METODO PARA VOZ (ABRIR PUERTOS) ~~~~~~~~~~~~~~~~~~
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            //se utiliza el Try Catch para evitar Errores y proteteger
            try
            {
                // sirve para abrir el Audio
                escucha.SetInputToDefaultAudioDevice();
                // lee la Gramatica
                escucha.LoadGrammar(new DictationGrammar());
                // Agredar las palabras y                 el new evento sirve para mandar los parametros al método LECTOR
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
                // sirve para decirle que no solo es una palabra
                escucha.RecognizeAsync(RecognizeMode.Single);
            } // fin de Try
            catch (InvalidOperationException)
            {
                // reproduce sonido                 
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("Ya esta Ejecutandose El puerto de AUDIO!!!");
            } // fin del Catch
        } // fin del Método Reconocedor

        // Método LECTOR (sender(Enviar)
        public void lector(object sender, SpeechRecognizedEventArgs R)
        {
            //sirve para poder recorrer todo el arreglo de caracteres o palabras de arreglo
            foreach (RecognizedWordUnit palabra in R.Result.Words)
            {
                Txt_Vox.Text = palabra.Text;
                if (palabra.Text == "za")
                {
                    Txt_Vox.Text = palabra.Text;
                    //  MENSAJE
                    syntesis.Speak("CORRECTO!!!");
                }
                if (palabra.Text == "ze")
                {
                    Txt_Vox.Text = palabra.Text;
                    //  MENSAJE
                    syntesis.Speak("CORRECTO!!!");
                }
                if (palabra.Text == "zi")
                {
                    Txt_Vox.Text = palabra.Text;
                    //  MENSAJE
                    syntesis.Speak("CORRECTO!!!");
                }
                if (palabra.Text == "zo")
                {
                    Txt_Vox.Text = palabra.Text;
                    //  MENSAJE
                    syntesis.Speak("CORRECTO!!!");
                }
                if (palabra.Text == "zu")
                {
                    Txt_Vox.Text = palabra.Text;
                    //  MENSAJE
                    syntesis.Speak("CORRECTO!!!");
                }
            }// FIN DEL FORACH

        }// FIN DEL METODO LECTOR

        // ~~~~~~~~~~~~~~~~~ BOTON PARA SALIR ~~~~~~~~~~~~~ BOTON PARA SALIR ~~~~~~~~~~~ BOTON PARA SALIR ~~~~~~~~~
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            INDEX_CONSONANTE BACK = new INDEX_CONSONANTE();
            BACK.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

    }// FIN DE LA CLASE
}
