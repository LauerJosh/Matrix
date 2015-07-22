using UnityEngine;
using System.Collections;

public class ScrollMaterialMulti : MonoBehaviour {
	
	public float scrollSpeed = 0.5f;
	public bool scrollX = true;
	private float offset;
	
	void Update () {
		offset += Time.deltaTime * scrollSpeed;
		
		if (scrollX) {
			renderer.materials[0].SetTextureOffset ("_MainTex", new Vector2 (offset, 0));
			renderer.materials[1].SetTextureOffset ("_MainTex", new Vector2 (offset, 0));
		} else {
			renderer.materials[0].SetTextureOffset ("_MainTex", new Vector2 (0, offset));
			renderer.materials[1].SetTextureOffset ("_MainTex", new Vector2 (0, offset));
		}
	}
}
