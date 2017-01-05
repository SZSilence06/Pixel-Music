using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class isMusicPlay : MonoBehaviour {
    public Image image;
    private Image image_child;
    private int frame = 0;
    public bool isPlayM;
	// Use this for initialization
	void Start () {
        image_child = image.transform.FindChild("Image").gameObject.GetComponent<Image>();
        isPlayM = true;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onClick(){
        StartCoroutine(Change());
    }

    IEnumerator Change(){
        while (frame < 3)
        {
            image.enabled = false;
            isPlayM = !isPlayM;
            image_child.enabled = !isPlayM;
            yield return 0;
            frame++;
        }
        image.enabled = true;
        frame = 0;
        AudioListener.volume = isPlayM ? 1.0f : 0.0f;
    }
}
