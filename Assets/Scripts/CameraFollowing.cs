using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public float followSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position,newPos,followSpeed); // lerp daha yumuşak takip sunuyor

            Vector3 newPos2 = new Vector3(target2.position.x, target.position.y, target2.position.z);
            target2.position = Vector3.Lerp(target2.position,newPos2,followSpeed);
        }
    }
}
