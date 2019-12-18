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

namespace ReconocedorVoz
{
    public partial class INDEX_CONSONANTE : Form
    {
// permite poder modificar la velocidad con que se reproduce el audio
        SpeechSynthesizer syntesis = new SpeechSynthesizer();

// CONSTRUCTOR
        public INDEX_CONSONANTE()
        {
            InitializeComponent();
            // centra la ventana
            this.CenterToParent();
        }

// REGRESAR AL INICIO
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Index INICIO = new Index();
            INICIO.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }// FIN DEL BOTON INICIO

        private void PB_IMFOConstante_Click(object sender, EventArgs e)
        {
            //sirve para el volumen de la voz
            syntesis.Volume = 100;
            // sirve para la velocidad de reproducction
            syntesis.Rate = 0;
            // sirve para indicar lo que va a hablar
            syntesis.Speak("Elige una de las letras de color Azul, para ver sus consonantes");
        }

// ~~~~~~~~ ~~~~~~~~ FUNCSIONES PARA ABRIR LAS VENTAS DE CADA UNA DE LAS CONSONANTES ~~~~~~~~ ~~~~~~~~
        private void COS_B_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_B Abrir = new VENTANA_B();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_C_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_C Abrir = new VENTANA_C();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_D_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_D Abrir = new VENTANA_D();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_F_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_F Abrir = new VENTANA_F();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_G_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_G Abrir = new VENTANA_G();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_H_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_H Abrir = new VENTANA_H();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_J_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_J Abrir = new VENTANA_J();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_K_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_K Abrir = new VENTANA_K();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_L_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_L Abrir = new VENTANA_L();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_M_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_M Abrir = new VENTANA_M();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_N_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_N Abrir = new VENTANA_N();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }
      
        private void COS_Ñ_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_Ñ Abrir = new VENTANA_Ñ();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_P_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_P Abrir = new VENTANA_P();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_Q_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_Q Abrir = new VENTANA_Q();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_R_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_R Abrir = new VENTANA_R();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_S_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_S Abrir = new VENTANA_S();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_T_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_T Abrir = new VENTANA_T();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_V_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_V Abrir = new VENTANA_V();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_W_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_W Abrir = new VENTANA_W();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_X_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_X Abrir = new VENTANA_X();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_Y_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_Y Abrir = new VENTANA_Y();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

        private void COS_Z_Click(object sender, EventArgs e)
        {
            //INSTACIAR EL FORMULARIO CORRESPONDIENTE
            VENTANA_Z Abrir = new VENTANA_Z();
            Abrir.Show();
            //  permite Ocultar la ventana INDEX
            this.Visible = false;
        }

    }
}
