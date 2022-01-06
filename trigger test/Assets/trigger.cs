using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Color m_oldColor = Color.white;
    public GameObject Spieler;
    private void OnTriggerEnter(Collider Spieler)
    {
        Renderer render = GetComponent<Renderer>();

        m_oldColor = render.material.color;
        render.material.color = Color.green;
    }
}
