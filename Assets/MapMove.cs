using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float mapSpeed = 10f;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
        
    }

}
