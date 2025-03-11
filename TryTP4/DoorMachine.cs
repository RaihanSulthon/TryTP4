using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTP4
{
    class DoorMachine
    {
        private enum state { Terbuka, Terkunci};
        private state currentState;

        public DoorMachine()
        {
            currentState = state.Terkunci;
            Console.WriteLine("Pintu Terkunci");
        }

        public void BukaPintu()
        {
            if(currentState == state.Terbuka)
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
            else
            {
                currentState = state.Terbuka;
                Console.WriteLine("Pintu Terkunci");
            }
        }

        public void TutupPintu()
        {
            if(currentState == state.Terkunci)
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
            else
            {
                currentState = state.Terkunci;
                Console.WriteLine("Pintu Terbuka");
            }
        }
    }
}
