using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyRoomObjectControlScript : MonoBehaviour
{
    public GameObject darktheme, darktheme1, darktheme2, darktheme3, darktheme4, darktheme5, darktheme6, darktheme7, darktheme8, darktheme9, darktheme10, darktheme11, darktheme12, darktheme13, darktheme14, darktheme15, darktheme16;
    
    int darkthemeg,darktheme1g, darktheme2g, darktheme3g, darktheme4g, darktheme5g, darktheme6g, darktheme7g, darktheme8g, darktheme9g, darktheme10g, darktheme11g, darktheme12g, darktheme13g, darktheme14g, darktheme15g, darktheme16g; 

    void Start(){
        darkthemeg = PlayerPrefs.GetInt("darkthemeg");
        darktheme1g = PlayerPrefs.GetInt("darktheme1g");
        darktheme2g = PlayerPrefs.GetInt("darktheme2g");
        darktheme3g = PlayerPrefs.GetInt("darktheme3g");
        darktheme4g = PlayerPrefs.GetInt("darktheme4g");
        darktheme5g = PlayerPrefs.GetInt("darktheme5g");
        darktheme6g = PlayerPrefs.GetInt("darktheme6g");
        darktheme7g = PlayerPrefs.GetInt("darktheme7g");
        darktheme8g = PlayerPrefs.GetInt("darktheme8g");
        darktheme9g = PlayerPrefs.GetInt("darktheme9g");
        darktheme10g = PlayerPrefs.GetInt("darktheme10g");
        darktheme11g = PlayerPrefs.GetInt("darktheme11g");
        darktheme12g = PlayerPrefs.GetInt("darktheme12g");
        darktheme13g = PlayerPrefs.GetInt("darktheme13g");
        darktheme14g = PlayerPrefs.GetInt("darktheme14g");
        darktheme15g = PlayerPrefs.GetInt("darktheme15g");
        darktheme16g = PlayerPrefs.GetInt("darktheme16g");


    if(darkthemeg == 1){
        darktheme.SetActive(false);}
    else
        darktheme.SetActive(true);

    if(darktheme1g == 1){
        darktheme1.SetActive(false);}
    else
        darktheme1.SetActive(true);

    if(darktheme2g == 1){
        darktheme2.SetActive(false);}    
    else
        darktheme2.SetActive(true);

    if(darktheme3g == 1){
        darktheme3.SetActive(false);}    
    else
        darktheme3.SetActive(true);

    if(darktheme4g == 1){
        darktheme4.SetActive(false);}    
    else
        darktheme4.SetActive(true);

    if(darktheme5g == 1){
        darktheme5.SetActive(false);}    
    else
        darktheme5.SetActive(true);

    if(darktheme6g == 1){
        darktheme6.SetActive(false);}    
    else
        darktheme6.SetActive(true);

    if(darktheme7g == 1){
        darktheme7.SetActive(false);}    
    else
        darktheme7.SetActive(true);

    if(darktheme8g == 1){
        darktheme8.SetActive(false);}    
    else
        darktheme8.SetActive(true);

    if(darktheme9g == 1){
        darktheme9.SetActive(false);}    
    else
        darktheme9.SetActive(true);

    if(darktheme10g == 1){
        darktheme10.SetActive(false);}    
    else
        darktheme10.SetActive(true);

    if(darktheme11g == 1){
        darktheme11.SetActive(false);}    
    else
        darktheme11.SetActive(true);

    if(darktheme12g == 1){
        darktheme12.SetActive(false);}    
    else
        darktheme12.SetActive(true);

    if(darktheme13g == 1){
        darktheme13.SetActive(false);}    
    else
        darktheme13.SetActive(true);

    if(darktheme14g == 1){
        darktheme14.SetActive(false);}    
    else
        darktheme14.SetActive(true);

    if(darktheme15g == 1){
        darktheme15.SetActive(false);}    
    else
        darktheme15.SetActive(true);

    if(darktheme16g == 1){
        darktheme16.SetActive(false);}    
    else
        darktheme16.SetActive(true);
    }
}
