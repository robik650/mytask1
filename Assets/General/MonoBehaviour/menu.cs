using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
public class menu : MonoBehaviour
{
    public GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OpenScene(int index)
    {
        SceneManager.LoadScene(index); 
    }
    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1); 
        
    }
    public void Continue()
    {
        if(PlayerPrefs.GetInt("current")==1)
        SceneManager.LoadScene(1);
        else if(PlayerPrefs.GetInt("current")==2)
        SceneManager.LoadScene(2);
        else if(PlayerPrefs.GetInt("current")==3)
        SceneManager.LoadScene(3);
        else if(PlayerPrefs.GetInt("current")==4)
        SceneManager.LoadScene(4);
        else
        cont.GetComponent<Button>().enabled = false;

    }
}
