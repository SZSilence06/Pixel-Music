using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using MusicGame;
public class isMusicPlay : MonoBehaviour {
    public Image image;
    private Image image_child;
    private int frame = 0;
    public bool isPlayM;

    isMusicPlay musicPlay0 = null;
    isMusicPlay musicPlay1 = null;

	// Use this for initialization
	void Start () {
        image_child = image.transform.FindChild("Image").gameObject.GetComponent<Image>();
        isPlayM = !StageData.GetInstance().Muted;
        image_child.enabled = !isPlayM;

        GameObject sound0 = GameObject.Find("stage0").transform.Find("Canvas").Find("sound").gameObject;
        GameObject sound1 = GameObject.Find("stage1").transform.Find("Canvas").Find("sound").gameObject;
        musicPlay0 = sound0.GetComponent<isMusicPlay>();
        musicPlay1 = sound1.GetComponent<isMusicPlay>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onClick(){
        StageData.GetInstance().Muted = !StageData.GetInstance().Muted;

        musicPlay0.isPlayM = !StageData.GetInstance().Muted;
        musicPlay1.isPlayM = !StageData.GetInstance().Muted;

        musicPlay0.UpdateLook();
        musicPlay1.UpdateLook();
    }

    public void UpdateLook()
    {
        StartCoroutine(Change());
    }

    IEnumerator Change(){
        while (frame < 3)
        {
            image.enabled = false;
            image_child.enabled = !image_child.enabled;
            yield return 0;
            frame++;
        }
        image.enabled = true;
        frame = 0;
        AudioListener.volume = isPlayM ? 1.0f : 0.0f;
    }
}
