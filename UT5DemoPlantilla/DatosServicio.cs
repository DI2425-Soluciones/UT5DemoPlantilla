using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT5DemoPlantilla
{
    class DatosServicio
    {
        public static ObservableCollection<string> GetProvincias()
        {
            ObservableCollection<string> lProvincias = new ObservableCollection<string>();
            lProvincias.Add("Alicante");
            lProvincias.Add("Castellón");
            lProvincias.Add("Valencia");
            return lProvincias;
        }

        public static ObservableCollection<Persona> GetPersonas()
        {
            ObservableCollection<Persona> lPersonas = new ObservableCollection<Persona>();
            lPersonas.Add(new Persona("Juan", 20));
            lPersonas.Add(new Persona("Ana", 30));
            lPersonas.Add(new Persona("Luis", 40));
            lPersonas.Add(new Persona("María", 10));
            lPersonas.Add(new Persona("José", 72));
            return lPersonas;
        }
    }
}
