using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float startWaitTime;
    [SerializeField] private Transform moveSpot;
    [SerializeField] private float maxX;
    [SerializeField] private float minX;
    [SerializeField] private float maxZ;
    [SerializeField] private float minZ;
    private float waitTime;

    private void Start()
    {
        waitTime = startWaitTime; // waitTime de�i�kenini componentlerinin i�inde de�eriyle oynayabildi�imiz startWaitTime isimli de�i�kenimize e�itliyoruz.
        moveSpot.position = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minZ, maxZ)); // moveSpot pozisyonumuzu yeni bir Vector3 olu�turup i�erisine rastgele alanlar olu�turup yukar�da belirledi�imiz maxX, maxZ, minX ve minZ aralar�nda yeni pozisyonlar set ediyoruz. transform.position.y komutunun amac� y ekseninde haraket etmesini istemememizden kaynaklan�yor, bu kod olmasa y �zerinde de haraket edebilir hale gelir ve havaya gidebilir.
    }

    private void Update()
    {
        SetPositionTowardsForPatroling(); // SetPositionTowardsForPatroling adl� metodunu �a��r�yoruz.
        SetRandomMoveSpot(); // SetRandomMoveSpot adl� metodunu �a��r�yoruz.
    }

    private void SetPositionTowardsForPatroling()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime); // �uanki pozisyonumuzu Vector3 ileriye gitme metoduna e�itleyip i�erisine �uanki pozisyonumuzu moveSpot pozisyonuna e�itlemeye �al���yor (gitmeye �al���yor). speed de�i�kenini zaman ile �arp�p daha optimize bir h�za ula��yoruz.
    }

    private void SetRandomMoveSpot()
    {
        if (Vector3.Distance(transform.position, moveSpot.position) < 0.2f) // e�er Vector3 uzakl�k metodu ile pozisyonumuz ile moveSpotun pozisyonu aras�nda 0.2f 'ten dah k���k gap (bo�luk) ise  
        {
            if (waitTime <= 0) // e�er waitTime de�i�keni k���k veya e�it 0 ise
            {
                moveSpot.position = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minZ, maxZ)); // moveSpot pozisyonumuzu yeni bir Vector3 olu�turup i�erisine rastgele alanlar olu�turup yukar�da belirledi�imiz maxX, maxZ, minX ve minZ aralar�nda yeni pozisyonlar set ediyoruz. transform.position.y komutunun amac� y ekseninde haraket etmesini istemememizden kaynaklan�yor, bu kod olmasa y �zerinde de haraket edebilir hale gelir ve havaya gidebilir.
                waitTime = startWaitTime; // Tekrardan e�er waitTime de�i�keni 0 dan k���k veya e�it ise startWaitTime a e�itle.
            }
            else
            {
                waitTime -= Time.deltaTime; // Yukar�daki waitTime s�f�rdan b�y�k ise bu kod �al��t�r�l�r burada da waitTime de�i�kenini ikide bir ��kart�p yeni bir zamana e�itliyoruz.
            }
        }
    }
}
