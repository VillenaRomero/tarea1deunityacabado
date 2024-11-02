using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientodepersonaje : MonoBehaviour
{
    private Transform _comtransform;
    private SpriteRenderer _comSpriteRenderer;
    public float speed = 10;
    public float xdirection = 1;
    public float ydirection = 1;

    void Awake()
    {
        _comtransform = GetComponent<Transform>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

    }
    void Update()
    {
        _comtransform.position = new Vector2(_comtransform.position.x + speed * xdirection * Time.deltaTime, _comtransform.position.y + speed * ydirection * Time.deltaTime);
        if (_comtransform.position.x >= 9.5)
        {
            xdirection = -1;
            _comSpriteRenderer.flipX = true;
        }
        else if (_comtransform.position.x <= -9.5)
        {
            xdirection = 1;
            _comSpriteRenderer.flipX = false;
        }
        if (_comtransform.position.y >= 3.3)
        {
            ydirection = -1;
            _comSpriteRenderer.flipY = true;
        }
        else if (_comtransform.position.y <= -3.3)
        {
            ydirection = 1;
            _comSpriteRenderer.flipY = false;
        }
    }
}
