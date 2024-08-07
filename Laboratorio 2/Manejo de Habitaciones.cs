using Laboratorio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Managment
    {
        

        public int ID { get; set; }
        public int nombre { get; set; }
        public double PrecioPorNoche {  get; set; }
        
        public bool disponible { get; set; }
        public string ClienteAsignado {  get; set; }

        public Managment(int iD, int nombre, double precioPorNoche, bool disponible, string clienteAsignado)
        {
            ID = iD;
            this.nombre = nombre;
            PrecioPorNoche = precioPorNoche;
            this.disponible = disponible;
            ClienteAsignado = clienteAsignado;


        }
        public void ShowRoom()
        {

        }
        public bool Avaible()
        {

        return true; 
        }
        public string AgregarCliente()
        {

            return null;
        }

        

    }
  
}

