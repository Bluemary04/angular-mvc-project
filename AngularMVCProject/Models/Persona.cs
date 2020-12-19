using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVCProject.Models
{
    public class Persona
    {
        //Campos de la clase Persona.
        private int id;
        private string nombre, apellido, dni, pais, localidad, mail, telefono, pass, usuario;

        //Constructor sin inicializar, es el por defecto.
        public Persona()
        {
        }

        //Constructor con inicializaciones.
        public Persona(int id, string nombre, string apellido, string dni, string pais, string localidad, 
                         string mail, string telefono, string pass, string usuario)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.pais = pais;
            this.localidad = localidad;
            this.mail = mail;
            this.telefono = telefono;
            this.pass = pass;
            this.usuario = usuario;
            
        }

        /*Propiedades que proporcionan comodidad de los miembros de datos publicos
         * sin los riesgos que provienen del acceso sin comprobar, sin controlar y sin
         * proteger a los datos de un objeto.
         */
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        //Lo anterior es otra forma de escribirlo. Lo que sigue ahorra lienas. 
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        

    }
}