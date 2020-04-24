using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolinController : MonoBehaviour
{
    public char key;
    public int secondsToDroop;
    Animator an;
    KeyCode realKey;
    private bool notDrooped;
    public GameObject alert;
    // Start is called before the first frame update
    void Start()
    {
        this.notDrooped = true;
        this.an = GetComponent<Animator>();
        this.an.SetInteger("AnimState", 0);
        switch (this.key)
        {
            case 'q':
                this.realKey = KeyCode.Q;
                break;
            case 'w':
                this.realKey = KeyCode.W;
                break;
            case 'e':
                this.realKey = KeyCode.E;
                break;
            case 'r':
                this.realKey = KeyCode.R;
                break;
            default:
                break;
        }
        this.alert.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.secondsToDroop >= 0 && Time.time >= this.secondsToDroop && this.notDrooped)
        {
            this.an.SetInteger("AnimState", 1);
            this.notDrooped = false;
            this.alert.SetActive(true);
        }
        if(Input.GetKeyDown(this.realKey) || (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2f))
        {
            this.an.SetInteger("AnimState", 0);
            this.alert.SetActive(false);
        }
    }
}
