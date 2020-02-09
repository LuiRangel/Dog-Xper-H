using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
     public float setTime = 20.0f;
    // Update is called once per frame
    void Update()
    {
        setTime -= Time.deltaTime;
         if (setTime <= 0.0f){
              SceneManager.LoadScene(0);
         }
    }
}
