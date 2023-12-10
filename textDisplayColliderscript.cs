using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDisplayColliderscript : MonoBehaviour
{
    public GameObject textDisplayCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("done");
            Destroy(textDisplayCollider);
        }
    }
}
