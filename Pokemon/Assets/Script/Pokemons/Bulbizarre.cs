using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbizarre : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        PVStat = 120;
        AtqStat = 40;
        DefStat = 60;
        SpeedStat = 30;
        Type myType;
        myType = Type.Plante;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Soin(int Healing)
    {
        PVStat += 30;
        if (PVStat > 120)
        {
            PVStat = 120;
        }
    }

}
