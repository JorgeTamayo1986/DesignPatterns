using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
       private static Singleton instance;
        public string IsCreate;
        protected Singleton() {
            IsCreate = "Instancia creada";
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null) 
                    instance = new Singleton();

                return instance;
            }
        }
    }
}
