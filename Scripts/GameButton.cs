using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
        public bool isHit;

        public Counter counter;
        float x ;


    public void Update() {
        
        x= Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x);
    }


    public void OnButtonClick()
    {
        if(x<= 6 || (x>=86 && x<=96))
        {
            StartCoroutine(ResetHit());
            counter.IncreaseCounter();
        }
   
        else if((x>176 && x<=188))
        {
            StartCoroutine(ResetHit());
            counter.IncreaseCounter();
        }

        else if((x>276 && x<=290))
        {
            StartCoroutine(ResetHit());
            counter.IncreaseCounter();
        }

        else if ((x>300 && x<=359))
        {
            StartCoroutine(ResetHit());
            counter.IncreaseCounter();
        }






    }

    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f);
        isHit = false;
    }





}
