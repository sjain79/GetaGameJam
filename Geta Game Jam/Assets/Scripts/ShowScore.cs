using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    private TextMeshProUGUI myTextMesh;

    private void Awake()
    {
        myTextMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        myTextMesh.text = "Score " + GameManager.score;
    }
}