using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Collectable : MonoBehaviour
{
    public float Food;

    void OnTriggerEnter(Collider collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player != null)
        {
            player.Collect(Food);
        }

        Destroy(gameObject);
    }
}