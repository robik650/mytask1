using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    int curHp;
    
    Rigidbody2D rb;
    public float speed;
    public GameObject bullet;
    public Transform shoot;
    public GameObject ship;
    public Main main;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public Joystick joystick;
    public soundeffector soundeffect;
    public playerscript play;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        curHp =play.Hp;
        shoot.transform.position = new Vector3(transform.position.x, transform.position.y+0.4f,transform.position.z);
    }
   // public void Move(Vector2 dir)
    //{
    //    transform.Translate(dir* Time.deltaTime*speed);
 //   }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       
       Vector2 position = transform.position;
       position.x = position.x + 0.1f * horizontal;
       position.y = position.y + 0.1f * vertical;
       transform.position = position;
        position.x = position.x + 0.1f *joystick.Horizontal;
       position.y = position.y + 0.1f *joystick.Vertical;
       transform.position = position;



       if(curHp==3)
       {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
       }
       if(curHp==2)
       {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(false);
       }
       
       if(curHp==1)
       {
        heart1.SetActive(true);
        heart2.SetActive(false);
        heart3.SetActive(false);
       }
       if(curHp<=0)
        {
           ship.SetActive(false);
           //GetComponent<BoxCollider2D>().enabled = false;
           Invoke("Lose",0.5f);
           main.Lose();
           soundeffect.Lose();
           heart1.SetActive(false);
        heart2.SetActive(false);
        heart3.SetActive(false);
           
        }
       
   }

   public void Attack()
   {
       Instantiate(bullet,shoot.transform.position,transform.rotation);
       soundeffect.Attackk();
   }
   
     private void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.gameObject.tag == "Enemy")
       {
        curHp = curHp-1;
       }
   }

}