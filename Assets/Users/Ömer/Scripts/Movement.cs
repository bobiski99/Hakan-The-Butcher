using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private CharacterController m_charCont;
    float m_horizontal;
    float m_vertical;

    public float PlayerSpeed = 0.3f;


    void Start()
    {
        m_charCont = GetComponent<CharacterController>();

    }


    void Update()
    {
        m_horizontal = Input.GetAxis("Horizontal");
        m_vertical = Input.GetAxis("Vertical");

        Vector3 m_playerMovement = new Vector3(m_horizontal, 0f, m_vertical) * PlayerSpeed;
        m_charCont.Move(m_playerMovement);
    }

}
