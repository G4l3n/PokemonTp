using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class DmgDealer : MonoBehaviour
{
    public GameObject[] pokemonInScene;

    // Start is called before the first frame update
    void Start()
    {
        if (pokemonInScene == null)
        {
            pokemonInScene = GameObject.FindGameObjectsWithTag("Pokemon");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
