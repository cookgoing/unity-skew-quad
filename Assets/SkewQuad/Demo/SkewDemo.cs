using UnityEngine;

[ExecuteInEditMode]
public class SkewDemo : MonoBehaviour {
	public SkewQuad quad;

	void Update () 
	{
		quad.UpdateMeshAndTexture();
	}
}
