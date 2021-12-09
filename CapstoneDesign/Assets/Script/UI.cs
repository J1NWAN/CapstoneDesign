using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField]
    public Slider hpBar;
    private float maxHp = 100;
    private float curHp = 100;
    private float imsi;
    private int count = 0;
    private float time = 0;
    private float gameTime = 0;
    public AudioClip clip;
    public GameObject image;
    public GameObject gameObject;
    private void Start()
    {
        imsi = (float)curHp / (float)maxHp;
    }

    private void Update()
    {
        gameTime += Time.deltaTime;
        if (transform.position.z < 49)
        {
            if (gameTime >= 5.0f)
            {
                gameTime = 0;
                curHp -= 2;
                imsi = (float)curHp / (float)maxHp;
            }
        }
        HandleHp();

        if (imsi <= 0 || Input.GetKey("escape"))
        {
            time += Time.deltaTime;

            if (count == 0) {
                count++;
                DeadSound();
                gameObject.GetComponent<OVRPlayerController>().enabled = false;
            }

            if (time >= 2.5f)
                image.SetActive(true);

            if (time >= 7.0f)
                SceneChange();
        }
    }

    private void HandleHp() {
        hpBar.value = Mathf.Lerp(hpBar.value, imsi, Time.deltaTime * 10);
    }

    public void ExitGame()
    { 
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    private void DeadSound() {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = clip;
        audio.Play();
    }

    private void SceneChange() {
        SceneManager.LoadScene("LoseScene");
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Damge") {
            curHp -= 0.1f;
            imsi = (float)curHp / (float)maxHp;
            HandleHp();

            Color color = new Color(255f/255f, 0f/255f, 0f/255f);
            hpBar.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
        } else {

            Color color = new Color(70f/255f, 255f/255f, 70f/255f);
            hpBar.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
        }
    }
}
