﻿using System;
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
        private ObservableCollection<string> _listaProvincias;
        public ObservableCollection<string> ListaProvincias
        {
            get { return _listaProvincias; }
            set
            {
                _listaProvincias = value;
                NotifyPropertyChanged("ListaProvincias");
            }
        }

        // Propiedades para el SEGUNDO EJEMPLO.
        private ObservableCollection<Persona> _listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return _listaPersonas; }
            set
            {
                _listaPersonas = value;
                NotifyPropertyChanged("ListaPersonas");
            }
        }

        // Indicamos donde recoger los datos de la persona seleccionada.
        private Persona _personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return _personaSeleccionada; }
            set
            {
                _personaSeleccionada = value;
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }


        public MainWindowVM()
        {
            // Inicializamos las listas desde la clase DatosServicio
            // con el método correspondiente.

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
