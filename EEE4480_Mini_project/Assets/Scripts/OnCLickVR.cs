using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OnCLickVR : MonoBehaviour
{
    public InputActionProperty inputActionProperty;

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputActionProperty.action.ReadValue<float>() > 0)
        {
            obj.GetComponent<Animator>().Play("Knob Animation");
        }
        
    }
}
