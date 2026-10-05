using UnityEngine;

public class ChapterStart : MonoBehaviour
{
    public GameObject chapterPanel;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            chapterPanel.SetActive(false);
        }
    }
}
