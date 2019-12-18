using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// LIBRERIA PARA RECONOCIMIENTO DE VOZ
using System.Speech.Recognition;
// libreria para SOnidos de la Maquina
using System.Speech.Synthesis;

namespace ReconocedorVoz
{
    public partial class prueba_voz : Form
    {
// permite poder modificar la velocidad con que se reproduce el audio
        SpeechSynthesizer syntesis = new SpeechSynthesizer();

// objeto que permitira escucar lo que el usuario diga
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

        public prueba_voz()
        {
            InitializeComponent();
            //centra la ventana
            this.CenterToParent();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Index INICIO = new Index();
            INICIO.Show();
        //  permite Ocultar la ventana Abecedario
            this.Visible = false;
        }

        private void PB_StarABCE_Click(object sender, EventArgs e)
        {
         //ocultar boton y mostrar IMG
            IMG_SOUD_ABC.Visible = true;
         // se hace visible el TextBox_Vista
            txtB_VistaABC.Visible = true;
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
                txtB_VistaABC.Text = palabra.Text;
                if (palabra.Text == "a")
                {
                    txtB_VistaABC.Text = palabra.Text;

                }// Fin del 1er. if
                else
                if (palabra.Text == "b")
                {
                    txtB_VistaABC.Text = palabra.Text;
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 2do. if
                else
                if (palabra.Text == "c")
                {
                    txtB_VistaABC.Text = palabra.Text;
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 3ro. if
                else
                if (palabra.Text == "d")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 4to. if
                else
                if (palabra.Text == "e")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 5TO. if
                else
                if (palabra.Text == "f")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 6to. if
                else
                if (palabra.Text == "g")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 7mo. if
                else
                if (palabra.Text == "h")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 8vo. if
                else
                if (palabra.Text == "i")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 9no. if
                else
                if (palabra.Text == "j")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 10mo. if
                else
                if (palabra.Text == "k")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 11vo. if
                else
                if (palabra.Text == "l")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 12vo. if
                else
                if (palabra.Text == "m")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 13vo. if
                else
                if (palabra.Text == "n")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 14vo. if
                else
                if (palabra.Text == "ñ")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 15vo. if
                else
                if (palabra.Text == "o")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 15vo. if
                else
                if (palabra.Text == "p")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 16vo. if
                else
                if (palabra.Text == "q")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 17vo. if
                else
                if (palabra.Text == "r")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 18vo. if
                else
                if (palabra.Text == "s")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 19vo. if
                else
                if (palabra.Text == "T")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 20vo. if
                else
                if (palabra.Text == "u")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 21vo. if
                else
                if (palabra.Text == "v")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 22vo. if
                else
                if (palabra.Text == "w")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 23vo. if
                else
                if (palabra.Text == "x")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 24vo. if
                else
                if (palabra.Text == "y")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 25vo. if
                else
                if (palabra.Text == "z")
                {
                    txtB_VistaABC.Text = palabra.Text;
                //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRECTO!!!");
                }// Fin del 26vo. if
                else
                if (palabra.Text == "cerrar")

                {
                    this.Close();
                } // fin del else

            } // fin del foreach
        }
////////////////////////////////////// SONIDO PARA CADA IMAGE //////////////////////////////////////
        private void pb_A_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("A");
        }

        private void pb_B_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("B");
        }

        private void pb_C_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("C");
        }

        private void pb_D_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("D");
        }

        private void pb_E_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("E");
        }

        private void pb_F_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("F");
        }

        private void pb_G_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("G");
        }

        private void pb_H_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("H");
        }

        private void pb_I_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("I");
        }

        private void pb_J_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("J");
        }

        private void pb_K_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("K");
        }

        private void pb_L_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("L");
        }

        private void pb_M_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("M");
        }

        private void pb_N_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("N");
        }

        private void pb_Ñ_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Ñ");
        }

        private void pb_O_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("O");
        }

        private void pb_P_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("P");
        }

        private void pb_Q_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Q");
        }

        private void pb_R_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("R");
        }

        private void pb_S_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("S");
        }

        private void pb_T_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("T");
        }

        private void pb_U_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("U");
        }

        private void pb_V_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("V");
        }

        private void pb_W_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("W");
        }

        private void pb_X_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("X");
        }

        private void pb_Y_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Y");
        }

        private void pb_Z_Click(object sender, EventArgs e)
        {
    //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Z");
        }
    }
}