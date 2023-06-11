using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{
    [SerializeField]
    private List<Material> materials;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        int index = Mathf.FloorToInt(System.DateTime.Now.Second % (float)materials.Count);
        meshRenderer.material = materials[index];
    }
}