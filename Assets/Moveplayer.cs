using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour{
    public float jump = 10f;
    public float jump2 = 12f;

    int jumpCount;

    public void Jump_Btn(){
        if(jumpCount == 0){
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump,0);
            jumpCount +=1;
        }

        else if (jumpCount == 1){
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2,0);
            jumpCount +=1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag.CompareTo("Land") == 0){
            jumpCount = 0;
        }
    }
}
