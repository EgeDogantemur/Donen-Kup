using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public void Awake() {
        
        Instance = this;
    }
        
    private void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0 , 0 );
    }


    








}
