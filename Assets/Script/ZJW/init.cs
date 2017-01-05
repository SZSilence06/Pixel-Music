using UnityEngine;
using System.Collections;

public class init : MonoBehaviour {
    private GameObject prefab_pix;
    public GameObject pix;
    private int total_num = 64;
    private GameObject[] pix_base = new GameObject[1024];
    private int num_sqrt;
    // Use this for initialization
    void Start() {
        prefab_pix = (GameObject)Resources.Load("prefab/pix");
        num_sqrt = (int) Mathf.Sqrt((float)total_num);
        for (int i = 0; i < num_sqrt; i++) {
            for(int j=0;j< num_sqrt; j++){
                pix_base[i * num_sqrt + j ] =(GameObject)Instantiate(prefab_pix,new Vector3(j- num_sqrt/2, num_sqrt /2- i,0f),new Quaternion(0f,0f,0f,0f));
                pix_base[i * num_sqrt + j].name = "pix"+(i* num_sqrt + j);
                pix_base[i * num_sqrt + j].transform.parent = pix.transform;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
