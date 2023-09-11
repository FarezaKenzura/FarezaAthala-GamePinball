using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    public float springPower;
    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Read Input
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring joinSpring = hinge.spring;

        // Mengubah value spring saat input ditekan dan dilepas
        if(Input.GetKey(input))
        {
            joinSpring.spring = springPower;
        } else {
            joinSpring.spring = 0;
        }

        hinge.spring = joinSpring;
    }
}
