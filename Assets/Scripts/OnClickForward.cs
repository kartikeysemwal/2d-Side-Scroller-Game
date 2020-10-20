using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickForward : MonoBehaviour
{
    PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton()
    {
        Debug.Log("In function");
        pm.Jump();
    }
}
