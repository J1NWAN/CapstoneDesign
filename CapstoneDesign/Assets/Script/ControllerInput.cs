using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public int speedForward; //전진 속도
    public int speedSide; //옆걸음 속도

    private Transform tr;
    private float dirX = 0;
    private float dirZ = 0;

    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        dirX = 0;
        dirZ = 0;

        if(OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);

            if(absX > absY)
            {
                if (coord.x > 0)
                    dirX = +1;
                else
                    dirX = -1;
            }
            else
            {
                if (coord.y > 0)
                    dirZ = +1;
                else
                    dirZ = -1;
            }
        }
        Vector3 moveDir = new Vector3(dirX * speedSide, 0, dirZ * speedForward);
        transform.Translate(moveDir * Time.smoothDeltaTime);
    }
}
