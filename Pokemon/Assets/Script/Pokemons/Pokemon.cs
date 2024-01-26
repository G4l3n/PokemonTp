using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public int PVStat { get; set; }
    public int AtqStat  { get; set; }
    public int DefStat { get; set; }
    public int SpeedStat { get; set; }
    public enum Type {Feu, Eau, Plante};


    public Dictionary<string, int> WeaknessAndStrength =
        new Dictionary<string, int>
        {
            {"Feu", 2},
            {"Eau", 2},
            {"Plante", 2}
        };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        charge(AtqStat);
    }

    public void charge(int dmgDeal)
    {
        dmgDeal = (int)(AtqStat * 0.2);
        Debug.Log(dmgDeal);
    }


}
