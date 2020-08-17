using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Main : MonoBehaviour

{
    int countenemy;
    public int asteroid;
    public Text asteroidCount;
    public GameObject win;
    public GameObject lose;
    public GameObject pause;
    public soundeffector soundeffect;
    public Transform Player;
 
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("current", SceneManager.GetActiveScene().buildIndex);
    }
    public void Count(int killasteroid)
    {
        asteroid = asteroid + killasteroid;

        if(asteroid == 0)
        Win();
    }
       public void OpenScene(int index)
    {
        SceneManager.LoadScene(index); 
    }
    // Update is called once per frame
    void Update()
    {
        asteroidCount.text = asteroid.ToString();
        
    }
    void Win()
    {
        Debug.Log("победа");
      win.SetActive(true);
      Time.timeScale = 0;
      if(!PlayerPrefs.HasKey("Lvl")||PlayerPrefs.GetInt("Lvl") < SceneManager.GetActiveScene().buildIndex){
      PlayerPrefs.SetInt("Lvl", SceneManager.GetActiveScene().buildIndex);
      
    }
      Debug.Log(PlayerPrefs.GetInt("Lvl"));
      soundeffect.Win();
      if(!PlayerPrefs.HasKey("complete"))
      PlayerPrefs.SetInt("complete",SceneManager.GetActiveScene().buildIndex);

    }
    public void Lose()
    {
        Debug.Log("победа");
        lose.SetActive(true);
        Time.timeScale = 0f;
        soundeffect.Lose();
    }
    public void Pauseon()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
       
    }
    public void Pauseoff()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;

        
    }
    public void ReloadLvl()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
        
      
    Time.timeScale = 1f;
    
    
  }
  public void NextLvl()
  {
    Time.timeScale = 1f;
    
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
