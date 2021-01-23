using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileManager : MonoBehaviour
{

    public GameObject[] tileprefabs;

    private Transform playertransform;
    private float spawnz = 0.0f;
    private float tilelength = 50.0f;
    private int amountoftilesonscreen = 5;
    private List<GameObject> activetiles;
    private float safezone = 55f;
    private int lastPrefabIndex = 0;

    private void Start()
    {

        activetiles = new List<GameObject>();
        playertransform = GameObject.FindWithTag("Player").transform;

        for (int i = 0; i < amountoftilesonscreen; i++)
        {
            if (i < 2)
                SpawnTile(0);
            else
                SpawnTile();
        }
    }

    private void Update()
    {

        if (playertransform.position.z - safezone > (spawnz - amountoftilesonscreen * tilelength))
        {

            SpawnTile();
            DeleteTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {

        GameObject go;
        if(prefabIndex==-1)

            go = Instantiate(tileprefabs[RandomPrefabIndex()]) as GameObject;

        else
            go = Instantiate(tileprefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
         go.transform.position = Vector3.forward * spawnz;
         spawnz += tilelength;
         activetiles.Add(go);
    }

    private void DeleteTile()
    {

        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tileprefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tileprefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;



    }
}