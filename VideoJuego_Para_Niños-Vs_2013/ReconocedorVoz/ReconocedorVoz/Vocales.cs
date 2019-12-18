using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// libreria del Speech (Hablar)
using System.Speech.Recognition;
// libreria para SOnidos de la Maquina
using System.Speech.Synthesis;

namespace ReconocedorVoz
{
    public partial class Vocales : Form
    {
// permite poder modificar la velocidad con que se reproduce el audio
        SpeechSynthesizer syntesis = new SpeechSynthesizer();

// objeto que permitira escucar lo que el usuario diga
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

        public Vocales()
        {
            InitializeComponent();
            //centra la ventana
            this.CenterToParent();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Index INICIO = new Index();
            INICIO.Show();
            //  permite Ocultar la ventana Vocales
            this.Visible = false;
        }

        private void PB_StarVocal_Click(object sender, EventArgs e)
        {
         //ocultar boton y mostrar IMG
            IMG_SOUD_Vocal.Visible = true;
         // se hace visible el TextBox_Vista
            txtB_Vista.Visible = true;
//se utiliza el Try Catch para evitar Errores y proteteger
            try
            {
// sirve para abrir el Audio
                escucha.SetInputToDefaultAudioDevice();
// lee la Gramatica
                escucha.LoadGrammar(new DictationGrammar());
// Agredar las palabras y                el new evento sirve para mandar los parametros al método LECTOR
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
// sirve para decirle que no solo es una palabra
                escucha.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (InvalidOperationException)
            {
                // reproduce sonido                 
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("Ya esta Ejecutandose El puerto de AUDIO!!!");
            }
        }

   // Método LECTOR (sender(Enviar)
        public void lector(object sender, SpeechRecognizedEventArgs R)
        {
//sirve para poder recorrer todo el arreglo de caracteres o palabras de arreglo
            foreach (RecognizedWordUnit palabra in R.Result.Words)
            {

             if (palabra.Text == "a")
             {
                 txtB_Vista.Text = palabra.Text;
// reproduce sonido                 
                 //sirve para el volumen de la voz
                 syntesis.Volume = 100;
                 // sirve para la velocidad de reproducction
                 syntesis.Rate = 0;
                 // sirve para indicar lo que va a hablar
                 syntesis.Speak("Correcto!!!");
             }// Fin del 1ER. if
             else
                 if (palabra.Text == "e")
                 {
                     this.Close();

// reproduce sonido
                     //sirve para el volumen de la voz
                     syntesis.Volume = 100;
                     // sirve para la velocidad de reproducction
                     syntesis.Rate = 0;
                     // sirve para indicar lo que va a hablar
                     syntesis.Speak("Correcto!!!");
                 }// Fin del 2do. if
             else
                if (palabra.Text == "I" ||palabra.Text == "i" )
                {
                     txtB_Vista.Text = palabra.Text;
// reproduce sonido
                     //sirve para el volumen de la voz
                     syntesis.Volume = 100;
                     // sirve para la velocidad de reproducction
                     syntesis.Rate = 0;
                     // sirve para indicar lo que va a hablar
                     syntesis.Speak("Correcto!!!");
                }// Fin del 3ro. if
             else
                if (palabra.Text == "o")
                {
                    txtB_Vista.Text = palabra.Text;
// reproduce sonido
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");
                }// Fin del 4to. if
             else
                if ( palabra.Text == "u" )
                {
                    txtB_Vista.Text = palabra.Text;
// reproduce sonido
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");
                }// Fin del 5to. if
             else if(palabra.Text == "cerrar")
             {
                 this.Close();

             } // fin del else

            } // fin del foreach (Ciclo)

        } // fin del Método Reconocedor

// SONIDO DE INFORMACION
        private void PB_IMFOVocal_Click(object sender, EventArgs e)
        {
// reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Repite las vocales, has clic en laS fotos, para oir su pronuncición");
        }

///////////////////////////// SONIDO DE CADA IMAGEN ////////////////////////////////////////////////
        private void pb_A_Click(object sender, EventArgs e)
        {
            // reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("A");
        }

        private void pb_E_Click(object sender, EventArgs e)
        {
            // reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("E");
        }

        private void pb_I_Click(object sender, EventArgs e)
        {
            // reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("I");
        }

        private void pb_O_Click(object sender, EventArgs e)
        {
            // reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("O");
        }

        private void pb_U_Click(object sender, EventArgs e)
        {
            // reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("U");
        }
///////////////////////////// RESTRICCIÓN //////////////////////////////////////////////////////////
        private void IMG_SOUD_Vocal_Click(object sender, EventArgs e)
        {
            // reproduce sonido
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("YA ESTA ABIERTO EL MICROFONO");
        }
    }
}
