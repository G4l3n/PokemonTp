using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dresseur : MonoBehaviour
{

    [SerializeField] private List<GameObject> pokemons = new List<GameObject>();
    [SerializeField] private int nbOfPokemonInTeam;
    [HideInInspector] public string nameOfPokemon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetTeam()
    {
        for (int i = 0; i < nbOfPokemonInTeam; i++)
        {
            int index = Random.Range(0, pokemons.Count);
            GameObject pokemonInTeam = pokemons[index];
            pokemons.Remove(pokemonInTeam);
            Instantiate(pokemonInTeam).name = nameOfPokemon;
        }
    }
}
