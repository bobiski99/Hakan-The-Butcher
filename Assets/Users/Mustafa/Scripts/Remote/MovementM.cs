using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementM : MonoBehaviour
{

    private CharacterController m_charCont;
    float m_horizontal;
    float m_vertical;

    public float PlayerSpeed = 0.3f;
    public float DashRange = 50f;
    Vector3 m_playerMovement;
    private Rigidbody rb;


    void Start()
    {
        m_charCont = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        m_horizontal = Input.GetAxis("Horizontal");
        m_vertical = Input.GetAxis("Vertical");

        m_playerMovement = new Vector3(m_horizontal, 0f, m_vertical) * PlayerSpeed;
        m_charCont.Move(m_playerMovement);
        if (Input.GetKeyDown("space"))
        {
            Dash();
        }

    }


    void Dash()
    {
        m_charCont.Move(m_playerMovement * DashRange * Time.deltaTime * 100f);
    }


}
