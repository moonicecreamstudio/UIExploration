using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMover : MonoBehaviour
{
    public AnimationCurve _curve;
    public RectTransform _window;
    public Vector2 _startPosition;
    public Vector2 _goalPosition;
    public float _speed;
    private float _current, _target;

    // Start is called before the first frame update
    void Start()
    {
        _window = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        _current = Mathf.MoveTowards(_current, _target, _speed * Time.deltaTime);

        _window.anchoredPosition = Vector2.Lerp(_startPosition, _goalPosition, _curve.Evaluate(_current));
    }

    public void buttonPressed()
    {
        _target = _target == 0 ? 1 : 0;
    }

    public void buttonOn()
    {
        _target = 1;
    }
    public void buttonOff()
    {
        _target = 0;
    }
}
