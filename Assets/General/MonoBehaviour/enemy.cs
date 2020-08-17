using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    int curHp;
    
    public GameObject asteroid;
    public Main countasteroid;
    public soundeffector soundeffect;
    private Animator anim;
    public enemyscript enemyscr; 
    public playerscript play;
    
    // Start is called before the first frame update
    void Start()
    {
        curHp = enemyscr.Hp;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,1);
        Vector2 position = transform.position;
        position.y = position.y - speed;
        transform.position = position;

       
        anim.SetTrigger("static");
    }
     private void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.tag == "Player")
       {
           anim.SetTrigger("boom");
        
        soundeffect.Die();
        StartCoroutine(Dead());
       }
       else if( collision.gameObject.tag == "Bullet")
       {
           curHp = curHp - play.AttackDamage ;
           
       }
        if(curHp<=0)
        {
           //ship.SetActive(false);
           //GetComponent<BoxCollider2D>().enabled = false;
           Invoke("Lose",0.5f);
           StartCoroutine(Dead());
            soundeffect.Die();
            anim.SetTrigger("boom");
            GetComponent<PolygonCollider2D>().enabled = false;
            
           countasteroid.GetComponent<Main>().Count(-1);
        }
   }
    public void RecountHp(int deltaHp)
    {
        
        
    }

    IEnumerator Dead(){
       
       yield return new WaitForSeconds(0.15f);
       asteroid.SetActive(false);
   }

}
