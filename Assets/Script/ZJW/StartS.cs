using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartS : MonoBehaviour {
    public Text text;
    Camera mainCamera;
    int frame = 0;
	// Use this for initialization
	void Start () {
        mainCamera = Camera.main; 
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void onClick() {
        StartCoroutine(loading());
    }

    IEnumerator loading() {
        frame++;
        while(frame % 16 != 0) {
            text.color = new Color(text.color.r, text.color.g, text.color.b,  1.0f * Mathf.Sin(frame/10f));
            yield return 0;
            frame++;
        }
        while (frame % 16 != 0){
            yield return 0;
            frame++;
        }
        //SceneManager.LoadScene(1);
        float pos_tmp = mainCamera.transform.position.x;
        for (float i=0.66f;i<=16.67f;i++){
            yield return 0;
            mainCamera.transform.position = new Vector3(pos_tmp+i, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
        frame = 0;

    }
}
