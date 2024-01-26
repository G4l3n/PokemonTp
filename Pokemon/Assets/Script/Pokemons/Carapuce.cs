using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carapuce : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        PVStat = 100;
        AtqStat = 50;
        DefStat = 60;
        SpeedStat = 50;
        Type myType;
        myType = Type.Eau;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PistoletAO(int dmgDeal, Type atqType)
    {
        atqType = Type.Eau;
        dmgDeal = (int)(AtqStat * 0.90);

    }

}
