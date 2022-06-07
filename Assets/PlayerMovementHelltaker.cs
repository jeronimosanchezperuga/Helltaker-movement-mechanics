using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementHelltaker : MonoBehaviour
{
    public float speed;
    public Transform targetTR;

    public Transform upTarget;
    public Transform downTarget;
    public Transform leftTarget;
    public Transform rightTarget;

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W) && upTarget)
        {
            targetTR = upTarget;
            upTarget = null;
            downTarget = null;
            leftTarget = null;
            rightTarget = null;

        }
        if (Input.GetKeyDown(KeyCode.S) && downTarget)
        {
            targetTR = downTarget;
            upTarget = null;
            downTarget = null;
            leftTarget = null;
            rightTarget = null;

        }
        if (Input.GetKeyDown(KeyCode.A) && leftTarget)
        {
            targetTR = leftTarget;
            upTarget = null;
            downTarget = null;
            leftTarget = null;
            rightTarget = null;

        }
        if (Input.GetKeyDown(KeyCode.D) && rightTarget)
        {
            targetTR = rightTarget;
            upTarget = null;
            downTarget = null;
            leftTarget = null;
            rightTarget = null;

        }

        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Casillero")
        {
            TargetManager tm = other.gameObject.GetComponent<TargetManager>();
            upTarget =  tm.upTarget;
            downTarget = tm.downTarget;
            leftTarget = tm.leftTarget;
            rightTarget = tm.rightTarget;
        }
    }
}