using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour {

    private float level;
    private bool iscavern;

    void Start()
    {
        iscavern = true;
        level = 0;
    }

    void OnTriggerEnter(Collider collider)
    {
        Player player = collider.GetComponent<Player>();
        
        if (player != null)
        {
            if (iscavern)
            {
                level++;
                // transition du joueur vers le niuveau suivant
            }
            else
            {
                // transition du joueur vers la caverne 
            }
            iscavern = !iscavern;
        }

    }
}
