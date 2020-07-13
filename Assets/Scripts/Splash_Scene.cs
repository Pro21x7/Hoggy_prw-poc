/*
Following C# Code is a part of a simple Unity POC project requested by Litifer
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //SceneManagement needed to transition to next scene
public class Splash_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    //Start scene Used to implement effect of a splash image.
    void Start()
    {
        Invoke("Up",3);
        print("after Invoke");
    }

    // Update is called once per frame
    //Call to main event.
    public void Up()
    {
        SceneManager.LoadScene(1);
        print("update");        
    }
}
