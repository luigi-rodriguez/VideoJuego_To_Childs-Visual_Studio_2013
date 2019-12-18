////////////////////////////////// LIBRERIAS ////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// libreria para SOnidos de la Maquina
using System.Speech.Synthesis;
// LIBRERIA DEL SONIDO
using System.Media;

namespace ReconocedorVoz
{
    public partial class Index : Form
    {
// permite poder modificar la velocidad con que se reproduce el audio
        SpeechSynthesizer syntesis = new SpeechSynthesizer();

// variable del sonido
        SoundPlayer Player;
        public Index()
        {
            InitializeComponent();
            //centra la ventana
            this.CenterToParent();
        }

        private void btn_Vocales_Click(object sender, EventArgs e)
        {
            //SE DA LA RUTA DEL ACHIVO
            Player = new SoundPlayer("clic.wav");
            // INICIA EL AUDIO
            Player.Play();

            Vocales Voca = new Vocales();
            Voca.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void Btn_Consonantes_Click(object sender, EventArgs e)
        {
            //SE DA LA RUTA DEL ACHIVO
            Player = new SoundPlayer("clic.wav");
            // INICIA EL AUDIO
            Player.Play();

            INDEX_CONSONANTE cpponstant = new INDEX_CONSONANTE();
            cpponstant.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void btn_Abc_Click(object sender, EventArgs e)
        {
            //SE DA LA RUTA DEL ACHIVO
            Player = new SoundPlayer("clic.wav");
            // INICIA EL AUDIO
            Player.Play();

            prueba_voz Abc = new prueba_voz();
            Abc.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void btn_Lec_Click(object sender, EventArgs e)
        {
            //SE DA LA RUTA DEL ACHIVO
            Player = new SoundPlayer("clic.wav");
            // INICIA EL AUDIO
            Player.Play();

            Lecciones_Index Abc = new Lecciones_Index();
            Abc.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void PB_IMFORMAR_Click(object sender, EventArgs e)
        {
            //SE DA LA RUTA DEL ACHIVO
            Player = new SoundPlayer("clic.wav");
            // INICIA EL AUDIO
            Player.Play();

            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("BIENVENIDO, BIENVENIDA");
            syntesis.Speak("LISTO, LISTA");
            syntesis.Speak("PARA APRENDER A LEER, PRIMERO EMPECEMOS CON LAS VOCALES");
        }

// eventos del RATON
        private void btn_Vocales_MouseEnter(object sender, EventArgs e)
        {
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("VOCALES!!!");
        }

        private void Btn_Consonantes_MouseEnter(object sender, EventArgs e)
        {
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Consonantes");
        }

        private void btn_Abc_MouseEnter_1(object sender, EventArgs e)
        {
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Abecedario");
        }

        private void btn_Lec_MouseEnter(object sender, EventArgs e)
        {
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("LECCIONES PARA COMPLETAR!!!");
        }

//CERRAR PROGRAMA
        private void Btn_CLOSEP_Click(object sender, EventArgs e)
        {
            //SE DA LA RUTA DEL ACHIVO
            Player = new SoundPlayer(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\ReconocedorVoz\ReconocedorVoz\bin\AUDIOS\clic.wav");
            // INICIA EL AUDIO
            Player.Play();

            this.Close();
        }
    }
}
