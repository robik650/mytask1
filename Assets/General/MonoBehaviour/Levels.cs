using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
public class Levels : MonoBehaviour
{
   
    public Button[] lvls;
    public GameObject complet;
    public GameObject complet2;
    public GameObject complet3;
    public GameObject complet4;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Lvl"))
        for (int i = 0; i < lvls.Length; i++)
        {
            if (i <= PlayerPrefs.GetInt("Lvl"))
                lvls[i].interactable = true;
            else
                lvls[i].interactable = false;
        }
        if(PlayerPrefs.GetInt("complete")==1)
       complet.SetActive(true);
       if(PlayerPrefs.GetInt("complete")==2)
       complet2.SetActive(true);
       if(PlayerPrefs.GetInt("complete")==3)
       complet3.SetActive(true);
       if(PlayerPrefs.GetInt("complete")==4)
       complet4.SetActive(true);
       

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DeletAll()
    {
        PlayerPrefs.DeleteAll();
    }
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index); 
    }
}
