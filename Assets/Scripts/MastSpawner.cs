using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MastSpawner : MonoBehaviour
{
    [SerializeField] private GameObject mastPrefab;
    [SerializeField] private Transform player, lastMast, ship;

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(new Vector2(0, player.position.y),
            new Vector2(0, lastMast.position.y)) <= 5f)
        {
            GameObject spawnMast = Instantiate(mastPrefab,
                new Vector2(0, lastMast.GetChild(0).position.y),
                Quaternion.identity);
            spawnMast.transform.parent = ship;
            lastMast = spawnMast.transform;
        }
    }
}
