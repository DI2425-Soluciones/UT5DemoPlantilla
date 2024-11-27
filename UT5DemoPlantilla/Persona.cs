using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5DemoPlantilla
{
    public class Persona : INotifyPropertyChanged
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }

        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (_edad != value)
                {
                    _edad = value;
                    NotifyPropertyChanged("Edad");
                }
            }
        }

        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Declaración del evento.
        public event PropertyChangedEventHandler? PropertyChanged;

        // Declarar método para invocar el evento.
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
