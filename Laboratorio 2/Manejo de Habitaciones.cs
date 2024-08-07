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
        public List<Habitación> HabitaciónSimple;
        public List<Habitación> HabitaciónDoble;
        public List<Habitación> HabitaciónDeluxe;
        public List<Habitación> Suite;

        public Managment()
        {
            HabitaciónSimple = new List<Habitación>();
            HabitaciónDoble  = new List<Habitación>();
            HabitaciónDeluxe = new List<Habitación>();
            Suite = new List<Habitación>();

        }

        
        public void AddDoubleRoom()
        {

        }
        public void AddDeulxeRoom()
        {

        }
        public void AddSuiteRoom()
        {

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

