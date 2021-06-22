using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string header;
    [TextArea(3,10)]
    public string content;

    IEnumerator Show()
    {
        yield return new WaitForSecondsRealtime(.5f);
        TooltipSystem.Show(content, header);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(Show());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        TooltipSystem.Hide();
    }
}