using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertBehavior : MonoBehaviour
{
    private GameObject player;
    public GameObject violin;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("MainCamera");
        Transform parent = this.violin.transform;
        this.transform.LookAt(this.player.transform);
        this.transform.position = parent.position;
        this.transform.position = new Vector3(this.transform.position.x - 0.3f, this.transform.position.y + 0.4f, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(this.player.transform);
    }
}
