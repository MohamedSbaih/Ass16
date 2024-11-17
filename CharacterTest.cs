using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    

public class CharacterTest : MonoBehaviour
{
    void Start(){
    Position soliderPosition = new Position(1,2,1);
    Position officerPosition = new Position(3,1,7);
    Character [] character = new Character[2];
    Soldier solider = new Soldier("Mohamed",110,soliderPosition);
    Officer officer = new Officer("Ayman",-2,officerPosition);
    

    character[0] = solider;
    character[1] = officer;

    for(int i = 0; i< character.Length; i++){
        character[i].DisplayInfo();
    }

     Debug.Log($"The normal health is {solider.Health}");
     officer.Attack(30,solider,"Shooting");
     Debug.Log($"The health before attack is {solider.Health}");

      
}
}
}