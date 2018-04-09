using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript;

public class Camera_Controller : MonoBehaviour
{


    //Variables
    public float interpVelocity;
    public float interpVelocity_V;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    //public Vector3 offset;
    Vector3 targetPos;
    Vector3 targetPos_V;
    private float Y_Mag = 10.0f;
    public Rigidbody2D myRigidBody;                                 //Keeps track of own rigidbody (set in inspector)

    //Use this for keeping track
    void Awake()
    {
    }//end of awake

    // Use this for initialization
    void Start()
    {
        targetPos = transform.position;

    }//End of Start

    // Update is called once per frame
    void FixedUpdate()
    {

        if (target)
        {

            //target.transform.localPosition = offset;

            if (myRigidBody.velocity.y <= -10.0)
            {
                Y_Mag = 20.0f;
            }
            else
            {
                Y_Mag = 10.0f;
            }//endif/else

            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;
            Vector3 targetDirection = (target.transform.position - posNoZ);
            interpVelocity = targetDirection.magnitude * 5.0f; //2.0f default
            interpVelocity_V = targetDirection.magnitude * 5.0f; //2.0f default
            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);
            targetPos_V = transform.position + (targetDirection.normalized * interpVelocity_V * Time.deltaTime);
            targetPos = new Vector3(targetPos.x, targetPos_V.y, -8.0f);
            //targetPos = targetPos + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, 0.50f);

        }//Endif

    }//End of LateUpdate

}
