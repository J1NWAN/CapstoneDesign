using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class SceneController : MonoBehaviour
{
    public GameObject titleMenu;
    public GameObject guideMenu;
    public GameObject guideMenu2;
    private void Start() {
        
    }

    public void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            guideBtnCloseClicked();
        }
    }

    public void guideBtnClicked() {
        titleMenu.SetActive(false);
        guideMenu.SetActive(true);
    }

    public void guideBtnCloseClicked() {
         guideMenu.SetActive(false);
         guideMenu2.SetActive(false);
         titleMenu.SetActive(true);
        
    }

    public void guideNextBtn() { 
        guideMenu.SetActive(false);
        guideMenu2.SetActive(true);
    }

    public void startBtnClicked() {
        SceneManager.LoadScene("MainScene");
    }

    public void exitBtnClicked() {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void tutorialSceneChange() {
        SceneManager.LoadScene("TutorialScene");
    }
}
