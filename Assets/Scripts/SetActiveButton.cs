using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject m_object;
    private bool m_active;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_object.SetActive(m_active);
    }
    public void SetObjectActive()
    {
        m_active = !m_active;
    }
}
