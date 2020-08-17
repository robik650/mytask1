using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class background : MonoBehaviour
{
    public Transform place;
    public Chunk[] ChunkPrefab;
    public List<Chunk> spawnChunk = new List<Chunk>();
    public Chunk firstChunk;
    // Start is called before the first frame update
    void Start()
    {
        spawnChunk.Add(firstChunk);
    }
    void Update()
    {
        
        if (place.position.y > spawnChunk[spawnChunk.Count-1].End.position.y+5)
        {
            SpawnChunks();
            
        }
    }
    private void SpawnChunks()
    {
      Chunk newChunk = Instantiate(GetRandomChunk());
      newChunk.transform.position = spawnChunk[spawnChunk.Count-1].End.position-newChunk.Begin.localPosition;
      spawnChunk.Add(newChunk);
      if(spawnChunk.Count>=5)
      {
          Destroy(spawnChunk[0].gameObject);
          spawnChunk.RemoveAt(0);
         }
    }
    private Chunk GetRandomChunk()
        {
        List<float> chances  = new List<float>();
        for(int i = 0; i < ChunkPrefab.Length; i++)
        {
            chances.Add(ChunkPrefab[i].chance.Evaluate(place.transform.position.y));
        }

        float value = Random.Range(0,chances.Sum());

        float sum = 0;

        for(int i = 0; i < chances.Count ; i++)
        {
            sum += chances[i];
            if(value <sum)
            {   
                return ChunkPrefab[i];
            }
        }
        return ChunkPrefab[ChunkPrefab.Length-1];
    }
}