using UnityEngine;
using System.Collections;
/// <summary>
/// 主要是按钮:
///     a. 默认的点击效果
/// 	b. 切换点击的图片
/// </summary>
public class ButtonSprite : MonoBehaviour{
	private SpriteRenderer render;
    private bool isClick=false;
	void Start(){
		render = GetComponent<SpriteRenderer> ();
	}
    void OnMouseDown() {
        isClick = true;
        render.color = new Color(0.5f, 0.5f, 0.5f);
    }
	
	void OnMouseUp(){
	}
    void Update() {
        if (!isClick) {
            render.color = new Color(0.5f, 0.5f, 0.5f) * (0.5f + 0.5f * Mathf.Sin(5 * Time.time)) + new Color(0.5f, 0.5f, 0.5f);
        }
        //if (frame == 2)
        //{
        //    render.color = Color.gray-Color.gray;
        //    frame = 0;
        //}
        //else {
        //    render.color = Color.white;
        //}

        //frame++;
    }
}