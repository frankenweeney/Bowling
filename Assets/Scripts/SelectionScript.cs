using TMPro;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{

    public float moveSpeed = 2f;
    private Renderer objRenderer;
    private Color originalColor;
    public Color hoverColor = Color.yellow;
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        if (objRenderer != null)
        {
            originalColor = objRenderer.material.color;
        }
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (objRenderer != null)
        {
            objRenderer.material.color = hoverColor;
        }
    }

    private void OnMouseExit()
    {
        if (objRenderer != null)
        {
            objRenderer.material.color = originalColor;
        }
    }
}
