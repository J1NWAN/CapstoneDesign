using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    [SerializeField]
    private KeyCode jumpKeyCode = KeyCode.Space;
    [SerializeField]
    private CameraController cameraController;
    private Movement3D movement3D;

    private Animator animator; // 유니티의 애니메이터
    
    void Awake()
    {
        movement3D = GetComponent<Movement3D>();    
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if(x != 0 || z != 0) animator.SetFloat("isMove", 5.0f);
        else {
            animator.SetFloat("isMove", 0.0f);
        }

        movement3D.MoveTo(new Vector3(x, 0, z));

        if(Input.GetKeyDown(jumpKeyCode)) {
            movement3D.JumpTo();
        }

        float mouseX = Input.GetAxis("Mouse X"); // 마우스 좌/우 움직임
        float mouseY = Input.GetAxis("Mouse Y"); // 마우스 위/아래 움직임

        if(mouseX > 0) transform.Rotate(Vector3.up, 2.6f);
        else if(mouseX < 0) transform.Rotate(Vector3.up, -2.6f);

        cameraController.RotateTo(mouseX, mouseY);
    }
}
