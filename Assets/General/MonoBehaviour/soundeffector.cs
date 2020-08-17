using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffector : MonoBehaviour
{
  public AudioSource audit;
  public AudioClip attack, die, lose, win;

  
  public void Attackk()
  {
      audit.PlayOneShot(attack);
  }
  public void Die()
  {
      audit.PlayOneShot(die);
  }
  public void Win()
  {
      audit.PlayOneShot(win);
  }
  public void Lose()
  {
      audit.PlayOneShot(lose);
  }
}
