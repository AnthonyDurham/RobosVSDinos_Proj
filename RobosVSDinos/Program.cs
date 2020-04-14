using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVSDinos
{
    class Program
    {
        static void Main(string[] args)
        {
           Dinosaur tRex = new Dinosaur("TRex");
          Dinosaur raptor = new Dinosaur("Raptor");
          Dinosaur triceratops = new Dinosaur("Triceratops");
            string response = Console.ReadLine();
            
            
            Robot astroBoy = new Robot("AstroBoy",100,100,"Rocket",25);
            Robot terminator = new Robot("Terminator",100,100,"MachineGun",25);
            Robot grievous = new Robot("Grievous",100,100,"LightSaber",25);
            string typeName  = Console.ReadLine();
        }

       

      
        
    }


}
