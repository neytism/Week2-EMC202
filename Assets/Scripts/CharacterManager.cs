using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Character[] Characters;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (var characters in Characters)
        {
            characters.SimulateCharacter();
        }
    }

}
