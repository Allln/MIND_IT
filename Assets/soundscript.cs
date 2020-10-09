using System.Collections;
using UnityEngine;

public class soundscript : MonoBehaviour
{
    void Awake(){
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update

}
