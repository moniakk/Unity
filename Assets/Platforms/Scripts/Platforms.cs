using UnityEngine;
using System.Collections;

public class Platforms : MonoBehaviour
{

    public float TilingX = 1f;
    public float TilingY = 1f;
    Renderer render;

    void OnDrawGizmos()
    {
        render = GetComponent<Renderer>();

        if (render != null)
        {
            Material m = render.sharedMaterials[0];
            m.mainTextureScale = new Vector2(transform.localScale.x / TilingX, transform.localScale.y / TilingY);

            //   render.material = m;


        }

    }
}
