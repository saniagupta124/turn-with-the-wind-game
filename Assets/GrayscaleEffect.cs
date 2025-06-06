using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class GrayscaleEffect : MonoBehaviour
{
    public Material material;
    [Range(0, 1)] public float blend = 0.81f;

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (material != null)
        {
            material.SetFloat("_Blend", blend);
            Graphics.Blit(src, dest, material);
        }
        else
        {
            Graphics.Blit(src, dest);
        }
    }
}
