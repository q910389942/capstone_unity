using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showObj : MonoBehaviour
{
    public GameObject obj;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            obj.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}