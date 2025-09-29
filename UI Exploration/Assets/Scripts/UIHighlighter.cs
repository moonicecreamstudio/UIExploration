using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using static System.Net.Mime.MediaTypeNames;

public class UIHighlighter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI _text;
    private Color _startingColor;
    public Color _highlightedColor;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        Color startingColor = _text.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _text.color = Color.yellow;
        _text.fontSize = 42;
        Debug.Log("Mouse on.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _text.color = Color.white;
        _text.fontSize = 32;
        Debug.Log("Mouse off.");
    }
}
