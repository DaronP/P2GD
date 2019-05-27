using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvl : MonoBehaviour
{


    public double xp;
    double attack = 1;
    double defense = 1;
    public int plevel = 0;
    public EnemyLvl elevel;
    public float health = 100;

    // Start is called before the first frame update
    void Start()
    {
        elevel = FindObjectOfType<EnemyLvl>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("l"))
        {
            xp += 10;

            if (xp % 100 == 0)
            {

                SubirNivel();

            }
        } 

        /*
        if (xp % 10 == 0)
        {

            SubirNivel();

        }*/

        
    }

    void SubirNivel()
    {
        plevel += 1;
        attack = attack * 1.1;
        defense = defense * 1.1;

        Debug.Log("Player Attack = " + attack);

        elevel.eLvl = plevel;
        elevel.attack = elevel.attack * 1.1;
        elevel.defense = elevel.defense * 1.1;

        Debug.Log("Enemy attack = " + elevel.attack);
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "XP")
        {
            xp += 1;
        }
    }
}
