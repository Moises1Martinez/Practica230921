using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica230921
{
    class Edificio
    {
        //definir los miembros de la clase
        //propiedades|atributos|datos
        //metodo de propiedad
        //get-- obtiene el valor almacenado en la propiedad
        //set-- asigna un valor a la variable propiedad

        public string nombre { get; set; }
        public string direccion { get; set; }
        public string cantDepartamentos { get; set; }
        public string depRentados { get; set; }

        //metodo constructor
        public Edificio(string pnombre, string pDireccion, string pCantidad, string pRentados)
        {
            nombre = pnombre;
            direccion = pDireccion;
            cantDepartamentos = pCantidad;
            depRentados = pRentados;
           
        }
        
        public string getInformacion()
        {
            return "Nombre del edificio:   "  +  nombre  + " Direccion del edificio:  " + direccion   +  " Cantidad de departamentos:  "  + cantDepartamentos +
                " Departamentos rentados:   "  + depRentados;
            
        }
    }
}
