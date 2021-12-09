using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Player : MonoBehaviour
{   
    public float posX, posY, posZ;
    public GameObject escape;
    void Start()
    {
        transform.position = new Vector3(posX, posY, posZ);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(  "X축: " + transform.position.x + 
        //             "Y축: " + transform.position.y + 
        //             "Z축: " + transform.position.z  );

        if (transform.position.x >= 44 && transform.position.z >= 58) {
            SceneChange();
        }
    }


    private void SceneChange() {
        SceneManager.LoadScene("VictoryScene");
    }
}
