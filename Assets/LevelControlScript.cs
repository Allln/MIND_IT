using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using System.Collections; 

public class LevelControlScript : MonoBehaviour
{
    GameObject[] toEnable, toDisable;

    public GameObject correctSign, incorrectSign;

    public static int currentSceneIndex = 1;
    
    public string whichBoardGot;

    public string answer;
    public string theName;
    public GameObject inputField;
    
    UnityEngine.TouchScreenKeyboard keyboard;
    public static string keyboardText = "";
    public AudioSource win;
    public AudioSource lost;
    public static bool check = false;
    public static int reset_id = 3;
    public static int fail_id = 0;

    void Start(){
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        toEnable = GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable = GameObject.FindGameObjectsWithTag("ToDisable");
        foreach(GameObject element in toEnable){
            element.gameObject.SetActive(false);
        }
    }
    

    public void RightAnswer(){
        foreach(GameObject element in toDisable){
            element.gameObject.SetActive(false);
        }
        check = true;
        win.Play();
        correctSign.gameObject.SetActive(true);
        int Boardgot = PlayerPrefs.GetInt(whichBoardGot);
        if(Boardgot == 1)
            Invoke("LoadNextLevel", 2f);
        else
            Invoke("GetBoard", 2f);
    }
    public void WrongAnswer(){
        foreach(GameObject element in toDisable){
            element.gameObject.SetActive(false);
        }
        reset_id = reset_id - 1;
        check = false;
        fail_id = 1;
        lost.Play();
        incorrectSign.SetActive(true);
        Invoke("GotoMainMenu", 1f);
    }
    void GetBoard(){ 
        correctSign.SetActive(false);
        incorrectSign.SetActive(true);
        PlayerPrefs.SetInt(whichBoardGot, 1);
        Invoke("LoadNextLevel",1f);
    }
    void LoadNextLevel(){
        correctSign.SetActive(false);
        incorrectSign.SetActive(true);
        SceneManager.LoadScene(currentSceneIndex + 1);
        
    }
    void GotoMainMenu(){
        check = false;
        incorrectSign.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }


    public void StoreName(){
        theName = inputField.GetComponent<Text>().text;
        foreach(GameObject element in toDisable){
            element.gameObject.SetActive(false);
        }
        int Boardgot = PlayerPrefs.GetInt(whichBoardGot);
        if(answer != theName){
            lost.Play();
            check = false;
            fail_id = 1;
            incorrectSign.SetActive(true);
            Invoke("GotoMainMenu",1f);
        }
        if(answer == theName){
            correctSign.gameObject.SetActive(true);
            win.Play();
            check = true;
            if(Boardgot == 1){
                correctSign.gameObject.SetActive(true);
                Invoke("LoadNextLevel", 2f);
            }
            else
                Invoke("GetBoard", 2f);
        }
    }
}
