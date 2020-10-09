using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public static GameObject highscore;

    public static void StartGame(){
        if(LevelControlScript.reset_id < 1){
            PlayerPrefs.DeleteAll();  
            LevelControlScript.currentSceneIndex = 1;
        }
        int x = PlayerPrefs.GetInt("highscore");
        if(LevelControlScript.check == true){
            x = x + 1;
            PlayerPrefs.SetInt("highscore",x);
            PlayerPrefs.Save();
        }
        if(LevelControlScript.fail_id == 1){
            x = LevelControlScript.currentSceneIndex;
            PlayerPrefs.SetInt("highscore",x);
            PlayerPrefs.Save();
            LevelControlScript.fail_id = 0;
        }
        LevelControlScript.check = false;
        
        if(x > 1){
            SceneManager.LoadScene(x);
            PlayerPrefs.SetInt("highscore", x);
            PlayerPrefs.Save();
        }
        /*else if(LevelControlScript.currentSceneIndex != 1){
            SceneManager.LoadScene(LevelControlScript.currentSceneIndex);
            PlayerPrefs.SetInt("highscore", LevelControlScript.currentSceneIndex);
            PlayerPrefs.Save();
        }*/
        else 
        {
            PlayerPrefs.SetInt("highscore", LevelControlScript.currentSceneIndex);
            PlayerPrefs.Save();
            LevelControlScript.currentSceneIndex = 1;
            SceneManager.LoadScene(1);   
        }
    }

    public void GoToTrophyRoom(){
        SceneManager.LoadScene("endgame");
    }

    public void ResetPlayerPrefs(){
        PlayerPrefs.DeleteAll();  
        LevelControlScript.currentSceneIndex = 1;
    }
}
