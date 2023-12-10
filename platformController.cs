using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour
{
    public GameObject[] tilePrefabs1;
    public GameObject[] tilePrefabs2;
    public GameObject[] tilePrefabs3;
    public GameObject finalisedTile;
    
    private Transform playerTransform;
    private float spawnZ;
    private float tileLength;
    private int ShowTilesOnScreen = 2;
    private float safeZone;
    private int lastTileIndex = 0;
    private int randomInt;
    private int platformControl;

    private List<GameObject> activeTiles; 
    // Start is called before the first frame update
    void Start()
    {

        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
        platformControl = MenuController.platformDecider;
        Debug.Log(platformControl);
       
       
       for (int i = 0; i <ShowTilesOnScreen; i++)
       {
           SpawnTile ();
       }

       if(platformControl == 1)
        {
           safeZone = 50f;
           spawnZ = -60f;
        }
        else if(platformControl == 2)
        {
            safeZone = 70f;
            spawnZ = -80f;
        }
        else if(platformControl == 3)
        {
            safeZone = 90f;
            spawnZ = -100f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( playerTransform.position.z - safeZone > (spawnZ - ShowTilesOnScreen * tileLength))
        {
            SpawnTile();
            Deletetile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {

       if(platformControl == 1)
       {
       finalisedTile = Instantiate(tilePrefabs1[RandomPrefabIndex()]) as GameObject; 
       tileLength = 60;
       }
       else if(platformControl == 2)
       {
       finalisedTile = Instantiate(tilePrefabs2[RandomPrefabIndex()]) as GameObject;
       tileLength = 80;   
       }
       else if(platformControl == 3)
       { 
       finalisedTile = Instantiate(tilePrefabs3[RandomPrefabIndex()]) as GameObject;   
       tileLength = 100;  
       }
       finalisedTile.transform.SetParent (transform);
       finalisedTile.transform.position = Vector3.forward * spawnZ;
       spawnZ += tileLength;
       activeTiles.Add (finalisedTile);
    }
    private void Deletetile()
    {
    
        Destroy (activeTiles [0]);
        activeTiles.RemoveAt (0);
    }

    private int RandomPrefabIndex()
    {
        while(randomInt == lastTileIndex)
        {
            randomInt = Random.Range(0, tilePrefabs1.Length);
        }

        lastTileIndex = randomInt;
        return randomInt;
    }
}
