using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float speed = 6f;
    float timeDel = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delete());
    }
IEnumerator Delete(){
    yield return new WaitForSeconds(timeDel);
    gameObject.SetActive(false);
}
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        StopCoroutine(Delete());
        gameObject.SetActive(false);
       
    }
  
}