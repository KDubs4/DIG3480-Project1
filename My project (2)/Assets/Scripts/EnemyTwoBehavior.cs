using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    private int lookX = 1;
    private int lookY = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(lookX, lookY, 0) * Time.deltaTime * 4);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x > 10f)
        {
            lookX = -1;
        }
        if (transform.position.x < -10f)
        {
            lookX = 1;
        }
        if (transform.position.y > 5.5)
        {
            lookY = -1;
        }
        if (transform.position.y < -3.5)
        {
            lookY = 1;
        }
    }
}