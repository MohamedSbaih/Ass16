using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
 

public class Character
{
    //? Create field
   public string name;
   private int health;
   protected Position position;

    public int Health { 
        get {return health; }
        set {
           health =  ConditionalHealth(value);
        }

        }

        public Character(string name, int health,Position position){
            this.name = name;
            this.Health = health;
            this.position = position;
        }
        public Character():this("No name", 100, new Position(0, 0, 0)){}

        public virtual void DisplayInfo(){
            Debug.Log($"The name is {name} and you have health {Health}");
            position.PrintPosition();
        }

        public void Attack(int damage, Character target){
            target.Health -= damage;
        }
         public void Attack(int damage, Character target, string attackType){
            Attack(damage, target);
            Debug.Log($"Attack type is {attackType}");
        }
        

    

//? Create ConditionalHealth method to prevent DRY
    public int ConditionalHealth(int value){
        if(value > 100){
            return 100;
            }else if(value < 0){
                return 0;
            }else {
                return value;
            }
    }

}
}
