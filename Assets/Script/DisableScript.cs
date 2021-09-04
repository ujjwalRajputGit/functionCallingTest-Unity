using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScript : MonoBehaviour
{
    void Awake() {
        Debug.Log(this.name + " awake called");
    }

    void OnEnable() {
        Debug.Log(this.name + " on enable called");
    }
    
    void Start()
    {
        Debug.Log(this.name + " start called");        
    }

    void Update()
    {
        // Debug.Log(this.name + " update called");        
    }
}
