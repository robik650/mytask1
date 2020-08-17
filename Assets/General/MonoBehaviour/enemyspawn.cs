using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject[] enemy;
    public float min;
    public float max;
     public float minYpos;
    public float maxYpos;


    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Random.Range(min,max));
        Vector2 pos = new Vector2(Random.Range(minYpos,maxYpos),transform.position.y);
        GameObject e = Instantiate(enemy[Random.Range(0,enemy.Length)],pos,Quaternion.identity) as GameObject;
        Repeat();
    }
}

