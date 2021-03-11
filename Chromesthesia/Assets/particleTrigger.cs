using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z <= Main.Instance.Player.transform.position.z){
            transform.GetChild(0).gameObject.SetActive(true);
        }
        
    }
}
