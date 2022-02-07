using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudcontoller : MonoBehaviour
{
    // Start is called before the first frame update
        private float minimum = 1.0f;
    private float magSpeed=10.0f;
        private float magnification = 0.07f;
    void start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed * this.magSpeed) * this.magnification);
    }
}
