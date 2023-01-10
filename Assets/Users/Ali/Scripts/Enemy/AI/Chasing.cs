using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float stoppingDistance;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); // target de�i�kenini sahneden OyunObjesinin etiketinin ismini bulup transformuna e�itliyoruz.
        // K�saca target adl� de�i�kenimiz art�k Player isimli objemizin pozisyonlar�n� bar�nd�r�yor.
    }
    private void Update()
    {
        ChasePlayer(); // A�a��daki ChasePlayer adl� metodumuzu �a��r�yoruz.
    }

    private void ChasePlayer()
    {
        if (Vector3.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime); // �uanki pozisyonumuzu Vector3 S�n�f�n�n MoveTowards metodunu �a��rarak kendi pozisyonumuzu target pozisyonuna set etmeye �al���yoruz.
            // speed * Time.deltaTime ise h�z�m�z� zaman ile �arp�p daha optimum bir h�za ula�mam�z� sa�l�yor.
        }
    }
}
