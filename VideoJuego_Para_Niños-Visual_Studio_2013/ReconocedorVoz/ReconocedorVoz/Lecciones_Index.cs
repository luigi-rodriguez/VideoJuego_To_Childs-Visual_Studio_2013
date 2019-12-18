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

namespace ReconocedorVoz
{
    public partial class Lecciones_Index : Form
    {
// permite poder modificar la velocidad con que se reproduce el audio
        SpeechSynthesizer syntesis = new SpeechSynthesizer();

// objeto que permitira escucar lo que el usuario diga
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

    // CONTRUCTOR       
        public Lecciones_Index()
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
///////////////////////////// PARA PODER APARECER LOS PANELES //////////////////////////////////////
        private void labelC_Click(object sender, EventArgs e)
        {
            Panel_C.Show();
        }

        private void labelL_Click(object sender, EventArgs e)
        {
            Panel_L.Show();;
        }

        private void labelN_Click(object sender, EventArgs e)
        {
            Panel_N.Show();
        }

        private void labelP_Click(object sender, EventArgs e)
        {
            PaneLP.Show();
        }

        private void labelR_Click(object sender, EventArgs e)
        {
            Panel_R.Show();
        }


///////////////////////////////// Ocultar boton y mostrar IMG //////////////////////////////////////
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         // Ocultar boton y mostrar IMG
            PB_Luna.Visible = true;
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
        //REPODUCIR IMFORMACION Automaticamente
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("ya esta habierto el puerto de escucha!!!");
            } // fin del Catch
        }// fin del Método Reconocedor

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
         //ocultar boton y mostrar IMG
            PB_Caballo.Visible = true;
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
        //REPODUCIR IMFORMACION Automaticamente
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("ya esta habierto el puerto de escucha!!!");
            } // fin del Catch
        } // fin del Método Reconocedor

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         //ocultar boton y mostrar IMG
            PB_Niño.Visible = true;
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
        //REPODUCIR IMFORMACION Automaticamente
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("ya esta habierto el puerto de escucha!!!");
            } // fin del Catch
        }// fin del Método Reconocedor

        private void pictureBox4_Click(object sender, EventArgs e)
        {
         //ocultar boton y mostrar IMG
            PB_Pato.Visible = true;
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
        //REPODUCIR IMFORMACION Automaticamente
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("ya esta habierto el puerto de escucha!!!");
            } // fin del Catch
        }// fin del Método Reconocedor


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //ocultar boton y mostrar IMG
            IMG_Pato.Visible = true;
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
                //REPODUCIR IMFORMACION Automaticamente
                //sirve para el volumen de la voz
                syntesis.Volume = 100;
                // sirve para la velocidad de reproducction
                syntesis.Rate = 0;
                // sirve para indicar lo que va a hablar
                syntesis.Speak("ya esta habierto el puerto de escucha!!!");
            } // fin del Catch
        }// fin del Método Reconocedor

// Método LECTOR (sender(Enviar)
        public void lector(object sender, SpeechRecognizedEventArgs R)
        {
         //sirve para poder recorrer todo el arreglo de caracteres o palabras de arreglo
            foreach (RecognizedWordUnit palabra in R.Result.Words)
            {
             //persive la lapabras HABLADAS
                Prueva.Text = palabra.Text;
                // RECORRE TODAS LA CONDICIONES Y ESCRIBE EL LOS CUADROS VACIOS

    // CONDICION PARA LA LECCION C
                if (palabra.Text == "cascables")
                {
                    // permite escribir en cada TextBox correspondiente
                    textCA.Text = "ca";
        //REPODUCIR IMFORMACION Automaticamente
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");
                }// Fin del 1er. if
                else
                    if (palabra.Text == "cerveza")
                    {
                        // permite escribir en cada TextBox correspondiente
                        textCe.Text = "Ce";
        //REPODUCIR IMFORMACION Automaticamente
                        //sirve para el volumen de la voz
                        syntesis.Volume = 100;
                        // sirve para la velocidad de reproducction
                        syntesis.Rate = 0;
                        // sirve para indicar lo que va a hablar
                        syntesis.Speak("Correcto!!!");
                    }// Fin del 2do. if
                    else
                       if (palabra.Text == "Ciudad")
                         {
                             // permite escribir en cada TextBox correspondiente
                            textCI.Text = "Ci";
        //REPODUCIR IMFORMACION Automaticamente
                            //sirve para el volumen de la voz
                            syntesis.Volume = 100;
                            // sirve para la velocidad de reproducction
                            syntesis.Rate = 0;
                            // sirve para indicar lo que va a hablar
                            syntesis.Speak("Correcto!!!");
                         }// Fin del 3ro. if
                        else 
                            if (palabra.Text == "comida")
                            {
                                // permite escribir en cada TextBox correspondiente
                               textCO.Text = "Co";
        //REPODUCIR IMFORMACION Automaticamente
                               //sirve para el volumen de la voz
                               syntesis.Volume = 100;
                               // sirve para la velocidad de reproducction
                               syntesis.Rate = 0;
                               // sirve para indicar lo que va a hablar
                               syntesis.Speak("Correcto!!!");
                            }// Fin del 4to. if
                            else
                                if (palabra.Text == "cuna")
                                {
                                    // permite escribir en cada TextBox correspondiente
                                   textCU.Text = "Cu";
        //REPODUCIR IMFORMACION Automaticamente
                                   //sirve para el volumen de la voz
                                   syntesis.Volume = 100;
                                   // sirve para la velocidad de reproducction
                                   syntesis.Rate = 0;
                                   // sirve para indicar lo que va a hablar
                                   syntesis.Speak("Correcto!!!");
                                }// Fin del 5TO. if


               
// CONDICION PARA LA LECCION L
            else
                if (palabra.Text == "lapiz")
                {
                    textLA.Text = "La";
        //REPODUCIR IMFORMACION Automaticamente
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");

                }// Fin del 1er. if
                else
                    if (palabra.Text == "león")
                    {
                        // permite escribir en cada TextBox correspondiente
                        textLE.Text = "Le";
                        //REPODUCIR IMFORMACION Automaticamente
        //sirve para el volumen de la voz
                        syntesis.Volume = 100;
                        // sirve para la velocidad de reproducction
                        syntesis.Rate = 0;
                        // sirve para indicar lo que va a hablar
                        syntesis.Speak("Correcto!!!");
                    }// Fin del 2do. if
                    else
                        if (palabra.Text == "limpiar")
                        {
                            // permite escribir en cada TextBox correspondiente
                            textLI.Text = "Li";
                            //REPODUCIR IMFORMACION Automaticamente
        //sirve para el volumen de la voz
                            syntesis.Volume = 100;
                            // sirve para la velocidad de reproducction
                            syntesis.Rate = 0;
                            // sirve para indicar lo que va a hablar
                            syntesis.Speak("Correcto!!!");
                        }// Fin del 3ro. if
                        else
                            if (palabra.Text == "lobo")
                            {
                                // permite escribir en cada TextBox correspondiente
                                textLO.Text = "lI";
                                //REPODUCIR IMFORMACION Automaticamente
        //sirve para el volumen de la voz
                                syntesis.Volume = 100;
                                // sirve para la velocidad de reproducction
                                syntesis.Rate = 0;
                                // sirve para indicar lo que va a hablar
                                syntesis.Speak("Correcto!!!");
                            }// Fin del 4to. if
                            else
                                if (palabra.Text == "luna")
                                {
                                    // permite escribir en cada TextBox correspondiente
                                    textLU.Text = "Lu";
                                    //REPODUCIR IMFORMACION Automaticamente
        //sirve para el volumen de la voz
                                    syntesis.Volume = 100;
                                    // sirve para la velocidad de reproducction
                                    syntesis.Rate = 0;
                                    // sirve para indicar lo que va a hablar
                                    syntesis.Speak("Correcto!!!");
                                }// Fin del 5TO. if


// CONDICION PARA LA LECCION N
            else
                if (palabra.Text == "nadar")
                {
                    textNA.Text = "Na";
        //REPODUCIR IMFORMACION Automaticamente
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");

                }// Fin del 1er. if
                else
                    if (palabra.Text == "negrito")
                    {
                        // permite escribir en cada TextBox correspondiente
                        textNE.Text = "Ne";
        //REPODUCIR IMFORMACION Automaticamente
                        //sirve para el volumen de la voz
                        syntesis.Volume = 100;
                        // sirve para la velocidad de reproducction
                        syntesis.Rate = 0;
                        // sirve para indicar lo que va a hablar
                        syntesis.Speak("Correcto!!!");
                    }// Fin del 2do. if
                    else
                        if (palabra.Text == "nido")
                        {
                            // permite escribir en cada TextBox correspondiente
                            textNI.Text = "Ni";
        //REPODUCIR IMFORMACION Automaticamente
                            //sirve para el volumen de la voz
                            syntesis.Volume = 100;
                            // sirve para la velocidad de reproducction
                            syntesis.Rate = 0;
                            // sirve para indicar lo que va a hablar
                            syntesis.Speak("Correcto!!!");
                        }// Fin del 3ro. if
                        else
                            if (palabra.Text == "nopal")
                            {
                                // permite escribir en cada TextBox correspondiente
                                textNO.Text = "No";
        //REPODUCIR IMFORMACION Automaticamente
                                //sirve para el volumen de la voz
                                syntesis.Volume = 100;
                                // sirve para la velocidad de reproducction
                                syntesis.Rate = 0;
                                // sirve para indicar lo que va a hablar
                                syntesis.Speak("Correcto!!!");
                            }// Fin del 4to. if
                            else
                                if (palabra.Text == "nube")
                                {
                                    // permite escribir en cada TextBox correspondiente
                                    textNU.Text = "Nu";
        //REPODUCIR IMFORMACION Automaticamente
                                    //sirve para el volumen de la voz
                                    syntesis.Volume = 100;
                                    // sirve para la velocidad de reproducction
                                    syntesis.Rate = 0;
                                    // sirve para indicar lo que va a hablar
                                    syntesis.Speak("Correcto!!!");
                                }// Fin del 5TO. if


// CONDICION PARA LA LECCION P
            else 
                if (palabra.Text == "pato")
                {
                    textPA.Text = "Pa";
        //REPODUCIR IMFORMACION Automaticamente
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");

                }// Fin del 1er. if
                else
                    if (palabra.Text == "peluca")
                    {
                        // permite escribir en cada TextBox correspondiente
                        textPE.Text = "Pe";
        //REPODUCIR IMFORMACION Automaticamente
                        //sirve para el volumen de la voz
                        syntesis.Volume = 100;
                        // sirve para la velocidad de reproducction
                        syntesis.Rate = 0;
                        // sirve para indicar lo que va a hablar
                        syntesis.Speak("Correcto!!!");
                    }// Fin del 2do. if
                    else
                        if (palabra.Text == "pino")
                        {
                            // permite escribir en cada TextBox correspondiente
                            textPI.Text = "Pi";
        //REPODUCIR IMFORMACION Automaticamente
                            //sirve para el volumen de la voz
                            syntesis.Volume = 100;
                            // sirve para la velocidad de reproducction
                            syntesis.Rate = 0;
                            // sirve para indicar lo que va a hablar
                            syntesis.Speak("Correcto!!!");
                        }// Fin del 3ro. if
                        else
                            if (palabra.Text == "popote")
                            {
                                // permite escribir en cada TextBox correspondiente
                                textPO.Text = "Po";
        //REPODUCIR IMFORMACION Automaticamente
                                //sirve para el volumen de la voz
                                syntesis.Volume = 100;
                                // sirve para la velocidad de reproducction
                                syntesis.Rate = 0;
                                // sirve para indicar lo que va a hablar
                                syntesis.Speak("Correcto!!!");
                            }// Fin del 4to. if
                            else
                                if (palabra.Text == "puente")
                                {
                                    // permite escribir en cada TextBox correspondiente
                                    textPU.Text = "Pu";
        //REPODUCIR IMFORMACION Automaticamente
                                    //sirve para el volumen de la voz
                                    syntesis.Volume = 100;
                                    // sirve para la velocidad de reproducction
                                    syntesis.Rate = 0;
                                    // sirve para indicar lo que va a hablar
                                    syntesis.Speak("Correcto!!!");
                                }// Fin del 5TO. if



// CONDICION PARA LA LECCION R
            else
                if (palabra.Text == "raton")
                {
                    textRA.Text = "Ra";
        //REPODUCIR IMFORMACION Automaticamente
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("Correcto!!!");

                }// Fin del 1er. if
                else
                    if (palabra.Text == "region")
                    {
                        // permite escribir en cada TextBox correspondiente
                        textRE.Text = "Re";
        //REPODUCIR IMFORMACION Automaticamente
                        //sirve para el volumen de la voz
                        syntesis.Volume = 100;
                        // sirve para la velocidad de reproducction
                        syntesis.Rate = 0;
                        // sirve para indicar lo que va a hablar
                        syntesis.Speak("Correcto!!!");
                    }// Fin del 2do. if
                    else
                        if (palabra.Text == "jerry")
                        {
                            // permite escribir en cada TextBox correspondiente
                            textRI.Text = "ry";
        //REPODUCIR IMFORMACION Automaticamente
                            //sirve para el volumen de la voz
                            syntesis.Volume = 100;
                            // sirve para la velocidad de reproducction
                            syntesis.Rate = 0;
                            // sirve para indicar lo que va a hablar
                            syntesis.Speak("Correcto!!!");
                        }// Fin del 3ro. if
                        else
                            if (palabra.Text == "ropero")
                            {
                                // permite escribir en cada TextBox correspondiente
                                textRO.Text = "Ro";
        //REPODUCIR IMFORMACION Automaticamente
                                //sirve para el volumen de la voz
                                syntesis.Volume = 100;
                                // sirve para la velocidad de reproducction
                                syntesis.Rate = 0;
                                // sirve para indicar lo que va a hablar
                                syntesis.Speak("Correcto!!!");
                            }// Fin del 4to. if
                            else
                                if (palabra.Text == "rubi")
                                {
                                    // permite escribir en cada TextBox correspondiente
                                    textRU.Text = "Ru";
        //REPODUCIR IMFORMACION Automaticamente
                                    //sirve para el volumen de la voz
                                    syntesis.Volume = 100;
                                    // sirve para la velocidad de reproducction
                                    syntesis.Rate = 0;
                                    // sirve para indicar lo que va a hablar
                                    syntesis.Speak("Correcto!!!");
                                }// Fin del 5TO. if
                                else
    //cerrar Programa
                                    if (palabra.Text == "cerrar")
                                    {
        //REPODUCIR IMFORMACION Automaticamente
                                        //sirve para el volumen de la voz
                                        syntesis.Volume = 100;
                                        // sirve para la velocidad de reproducction
                                        syntesis.Rate = 0;
                                        // sirve para indicar lo que va a hablar
                                        syntesis.Speak("HASTA LA PROXIMA ADIOS!!!");
                                        // permite Que se cierre el puerto de audio
                                        Prueva.Text = palabra.Text;
                                        Close();

                                    }// Fin del 6TO. if
                 else
                    if (palabra.Text == "cerrar")
                     {
                         this.Close();    
                     } // fin del else

            } // fin del foreach
        } // FIN DEL METODO lector
        
// MÉTODO DE LA Informacion
        private void PB_IMFOLeccion_Click(object sender, EventArgs e)
        {
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("completa las lecciones marcadas en Azul");
        } // FIN DE INFORMACION

//////////////////// Regresar A Las Lecciones //////////////////////////////////////////////////////
        private void Btn_REGRESAR_C_Click(object sender, EventArgs e)
        {
            Lecciones_Index INICIO = new Lecciones_Index();
            INICIO.Show();
            syntesis.Pause();
        }

        private void Btn_REGRESAR_L_Click(object sender, EventArgs e)
        {
            Lecciones_Index INICIO = new Lecciones_Index();
            INICIO.Show();
            syntesis.Pause();
        }

        private void Btn_REGRESAR_N_Click(object sender, EventArgs e)
        {
            Lecciones_Index INICIO = new Lecciones_Index();
            INICIO.Show();
            syntesis.Pause();
        }

        private void Btn_REGRESAR_P_Click(object sender, EventArgs e)
        {
            Lecciones_Index INICIO = new Lecciones_Index();
            INICIO.Show();
            syntesis.Pause();
        }

        private void Btn_REGRESAR_R_Click(object sender, EventArgs e)
        {
            Lecciones_Index INICIO = new Lecciones_Index();
            INICIO.Show();
            syntesis.Pause();
        }
        // REGRESAR AL MENU LISTA
        private void button1_Click(object sender, EventArgs e)
        {
            Lecciones_Index INICIO = new Lecciones_Index();
            INICIO.Show();
            syntesis.Pause();
        }

//////////////////// sirven para Opciones de Escritura N ///////////////////////////////////////////
        private void textNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) )
            {
                string Ecritura = textNA.Text;

                if (Ecritura == "na")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textNE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textNE.Text;

                if (Ecritura == "ne")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textNI.Text;

                if (Ecritura == "ni")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textNO.Text;

                if (Ecritura == "no")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textNU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textNU.Text;

                if (Ecritura == "nu")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter

        }

//////////////////// sirven para opciones de escritura de L ////////////////////////////////////////
        private void textLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textLA.Text;

                if (Ecritura == "la")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textLE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textLE.Text;

                if (Ecritura == "le")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textLI.Text;

                if (Ecritura == "li")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textLO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textLO.Text;

                if (Ecritura == "lo")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textLU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textLU.Text;

                if (Ecritura == "lu")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter

        }

//////////////////// sirven para dar una opciones de escritura de R ////////////////////////////////
        private void textRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textRA.Text;

                if (Ecritura == "ra")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textRE.Text;

                if (Ecritura == "re")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textRI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textRI.Text;

                if (Ecritura == "ri")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textRO.Text;

                if (Ecritura == "ro")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textRU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textRU.Text;

                if (Ecritura == "ru")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter

        }

//////////////////// sirven para dar una opciones de escritura de P ////////////////////////////////
        private void text_PA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e = LLAMA todos los EVENTOS DEL KEYPRESS
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textPA.Text;

                if (Ecritura == "pa")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void text_PE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textPE.Text;

                if (Ecritura == "pe")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void text_PI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textPI.Text;

                if (Ecritura == "pi")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void text_PO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textPO.Text;

                if (Ecritura == "po")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void text_PU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textPU.Text;

                if (Ecritura == "pu")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter

        }

//////////////////// sirven para dar una opciones de escritura de C ////////////////////////////////
        private void textCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textCA.Text;

                if (Ecritura == "ca")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

// ~~~~~~~~~~~~~~~~ ````````FUNSIONES DE ENTER EN LOS CUADROS DE TEXTO ```````` ~~~~~~~~~~~~~~~~~~~~~
        private void textCe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textCe.Text;

                if (Ecritura == "ce")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textCI.Text;

                if (Ecritura == "ci")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textCO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textCO.Text;

                if (Ecritura == "co")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }

        private void textCU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string Ecritura = textCU.Text;

                if (Ecritura == "cu")
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("CORRETO!!!");
                }
                else
                {
                    //sirve para el volumen de la voz
                    syntesis.Volume = 100;
                    // sirve para la velocidad de reproducction
                    syntesis.Rate = 0;
                    // sirve para indicar lo que va a hablar
                    syntesis.Speak("INCORRETO!!!");
                }
            } // Fin del IF para enter
        }
    }
}