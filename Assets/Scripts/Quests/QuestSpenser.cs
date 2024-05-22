using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSpenser : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EndDialog == true)
        {
            Time.timeScale = 1;
            Dialog1.SetActive(false);
        }

        
    }
    void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "Player");
            Time.timeScale = 0;
            Dialog1.SetActive(true);
        }
}
