using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito_1.Class1
{
    class Carro
    {
        public string marca { get; set; }
        public string Color { get; set; }
        public int velo_max { get; set; }
        private int velocidadactual { get; set; }
        private bool Encendido = false;
        private bool Apagado = false;
        public int frenar { get; set; }
        public bool intermitenteizquierdo { get; set; }
        public bool intermitentederecho { get; set; }
        public Carro(string marcadecarro, int velocidadmax)
        {
            this.marca = marcadecarro;
            this.velo_max = velocidadmax;
        }
        public string DAtoscarrito()
        {
            return marca;
        }
        public string dAtoscarrito()
        {
            return Color;
        }
        public bool EstaEncendido()
        {
            return Encendido;
        }
      
        public string encendermotor()
        {
            if (Encendido)
            {
                return "El carro esta encendido";
            }
            else
            {
                Encendido = true;
                velocidadactual = 0;

                return "listo el carro esta encendido";
            }
        }
        public string acelerar()
        {
            velocidadactual = velocidadactual + 5;
            if (velocidadactual > velo_max)
            {
                return "lo lamento llegaste a la velocidad maxima";
            }
            else if (velocidadactual >= 105)
            {
                return $"vas a {velocidadactual } KPH";
            }
            else if (velocidadactual >= 100)
            {
                return "ponle cuarta velocidad";
            }
            else if (velocidadactual >= 75)
            {
                return $"vas a {velocidadactual } KPH";
            }
            else if (velocidadactual >= 70)
            {
                return "ponle tercera velocidad";
            }
            else if (velocidadactual >= 35)
            {
                return $"vas a {velocidadactual } KPH";
            }
            else if (velocidadactual >= 30)
            {
                return "ponle segunda velocidad";
            }
            else
            {
                return $"vas a {velocidadactual } KPH";
            }

        }
        public string frenare()
        {
            if (velocidadactual == 0)
            {
                return "el carrito se ha detenido";

            }
            else
            {
                velocidadactual -= 5;
                return $"vas a una velocidad {velocidadactual} KPH";


            }
        }
        public string IntermtenteIzquierdo()
        {
            if (velocidadactual >= 50)
            {
                return $"Girando a la izquierda {velocidadactual} Disminuye la velocidad";
            }
            else
            {
                return "Vas a girar a la Izqueirda";
            }
        }

        public bool intermtenteIzquierdo() {
          
            return intermitenteizquierdo;

        }
        public string IntermtenteDerecho()
        {
            if (velocidadactual >= 50)
            {
                return $"Girando a la Derecha {velocidadactual} Disminuye la velocidad";
            }
            else
            {
                return "Vas a girar a la Derecha";
            }
        }

        public bool intermtenteDerecho()
        {

            return intermitentederecho;

        }
        public bool Apagarmotor()
        {
            return Apagado;
        }
        public string apagarmotor()
        {
            if (Apagado)
            {
                return "El carro esta apagado vuelve a encender";
            }
            else
            {
                Apagado = true;
                velocidadactual = 0 ;
    
                return "El motor ya esta apagado";
            }
        }

    }
     
    
       
    
}
