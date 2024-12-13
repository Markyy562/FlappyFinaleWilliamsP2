 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
