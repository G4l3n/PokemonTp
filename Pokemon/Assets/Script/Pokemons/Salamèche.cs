using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salamèche : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        PVStat = 100;
        AtqStat = 60;
        DefStat = 40;
        SpeedStat = 60;
        Type myType;
        myType = Type.Feu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Flammèche(int dmgDeal, Type atqType)
    {
        atqType = Type.Feu;
        dmgDeal = AtqStat;

    }

    public void dmgReceived(int dmgTaken)
    {

    }
}
