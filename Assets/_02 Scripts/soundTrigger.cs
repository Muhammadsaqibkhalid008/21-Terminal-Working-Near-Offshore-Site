using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SoundObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "valve")
        {
            SoundObj.SetActive(true);
            print("hit");
        }
    }
}
