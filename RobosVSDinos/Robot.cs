using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVSDinos
{
    class Robot
    {
        public string robotName;
        public int health;
        public int powerLevel;
        public string weapon;
        public int attackPower;

        public Robot(string typeName, int health, int powerlevel, string weapon, int attackpower)
        {
            this.robotName = typeName;
            this.health = 100;
            this.powerLevel = 100;
            this.weapon = "Rocket";
            this.attackPower = 25;

            this.robotName = typeName;
            this.health = 100;
            this.powerLevel = 100;
            this.weapon = "MachineGun";
            this.attackPower = 25;

            this.robotName = typeName;
            this.health = 100;
            this.powerLevel = 100;
            this.weapon = "LightSaber";
            this.attackPower = 25;

            Robot astroBoy = new Robot("AstroBoy", 100, 100, "Rocket", 25);
            Robot terminator = new Robot("Terminator", 100, 100, "MachineGun", 25);
            Robot grieveous = new Robot("Grieveous", 100, 100, "LightSaber", 25);
        }



        // member methods what the class does 

        //Robots and dinosaurs need ability to attack. Methods should take in a dinosaur and robot object;
        //ask user to pick a dino
        // ask user to pick a robot 
        // have picked dinosaur attack robot
        // have picked robot attack dinosaur
        // when attacked the oppenent losses health, and powerlevel for robots and dinosaurs loose health and engery
        // the attack power will subtract from oppenets health and powerlevel for robots
        //and will subtract health and engery for dinosuars until it has reached zero 
        // reaching zero the Robot or dinosaur will die 
        
        
        public Robot()
        {
            string robotName;
            string Weapon;
            int attackPower;
            
        }
        public void Attack(Robot robot, Dinosaur dinosaur)
        {

            Robot.health -= Dinosaur.attackPower;

            dinosaur.powerLevel-= 10;


        }
          
    } } 

