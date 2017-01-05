using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StageMove : MonoBehaviour{
    public Image image;
    public Image image1;
    int frame;
    Camera mainCamera;
    // Use this for initialization
    void Start () {
        mainCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onClickBackMain()
    {
        StartCoroutine(loading());
    }
    public void onClickMenu()
    {
        StartCoroutine(loading1());
    }

    IEnumerator loading()
    {
        frame++;
        while (frame % 8 != 0)
        {
            image.enabled = false;
            yield return 0;
            frame++;
        }
        image.enabled = true;
        while (frame % 16 != 0)
        {
            yield return 0;
            frame++;
        }
        //SceneManager.LoadScene(1);
        float pos_tmp = mainCamera.transform.position.x;
        for (float i = 0.66f; i <= 16.67f; i++)
        {
            yield return 0;
            mainCamera.transform.position = new Vector3(pos_tmp - i, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
        frame = 0;

    }

    IEnumerator loading1()
    {
        frame++;
        while (frame % 8 != 0)
        {
            image1.enabled = false;
            yield return 0;
            frame++;
        }
        image1.enabled = true;
        while (frame % 16 != 0)
        {
            yield return 0;
            frame++;
        }
        //SceneManager.LoadScene(1);
        float pos_tmp = mainCamera.transform.position.x;
        for (float i = 0.66f; i <= 16.67f; i++)
        {
            yield return 0;
            mainCamera.transform.position = new Vector3(pos_tmp + i, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
        frame = 0;
    }
}
