using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update

    public float animationSpeed = 0.05f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
