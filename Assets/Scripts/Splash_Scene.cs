using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Up",3);
        print("after Invoke");
    }

    // Update is called once per frame
    public void Up()
    {
        SceneManager.LoadScene(1);
        print("update");        
    }
}
