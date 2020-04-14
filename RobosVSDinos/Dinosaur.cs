using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVSDinos
{
    class Dinosaur
    {
        public string dinosaurType;
        public int health;
        public int energy;
        public int attackPower;

        public Dinosaur(string typeName)
        {
            this.dinosaurType = typeName;
            health = 100;
            energy = 100;
            attackPower = 25;
            Console.WriteLine(typeName);
        }

        public Dinosaur()
        {
            //  member methods what this class does  

            string dinosaurType;
            int attackPower;

        }

        public void Attack(Robot robot, Dinosaur dinosaur)
        {
            robot.health -= dinosaur.attackPower;
            
            dinosaur.energy -= 10; 

        }

        
    }
}
