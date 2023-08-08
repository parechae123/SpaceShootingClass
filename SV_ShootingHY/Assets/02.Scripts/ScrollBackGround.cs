using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{
    public float scrollsSpeed =3 ;
    public Renderer rend;
    public float upDownPos = 0;
    public float checker = 0.3f;
    public float timer;
    public float updownDelay;
    // Start is called before the first frame update
    private void Reset()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scrollsSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, upDownPos);
        upDownPos += ((Time.deltaTime * scrollsSpeed)*checker) / 2;
        timer += Time.deltaTime;
        if (timer > updownDelay)
        {
            timer = 0;
            updownDelay = Random.RandomRange(3, 10);
            checker *= -1;
        }
    }
}
