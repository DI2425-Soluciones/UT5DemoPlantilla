using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5DemoPlantilla
{
    class MainWindowVM : INotifyPropertyChanged
    {
        // ObservableCollection lleva implementado INotifyOnCollectionChanged.


        // Propiedades para el PRIMER EJEMPLO.
        private ObservableCollection<string> listaProvincias;
        public ObservableCollection<string> ListaProvincias
        {
            get { return listaProvincias; }
            set
            {
                listaProvincias = value;
                NotifyPropertyChanged("ListaProvincias");
            }
        }

        // Propiedades para el SEGUNDO EJEMPLO.
        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set
            {
                listaPersonas = value;
                NotifyPropertyChanged("ListaPersonas");
            }
        }

        // Indicamos donde recoger los datos de la persona seleccionada.
        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                personaSeleccionada = value;
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }


        public MainWindowVM()
        {
            // Inicializamos las listas desde la clase DatosServicio.

            ListaProvincias = DatosServicio.GetProvincias();

            ListaPersonas = DatosServicio.GetPersonas();

            PersonaSeleccionada = ListaPersonas[2]; // Seleccionamos la tercera persona de la lista
        }

        public void AñadirProvincia()
        {
            ListaProvincias.Add("Murcia");
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
