using UnityEngine;
using System.Collections;


public class rayCast_ : MonoBehaviour
{
    public HitScore thehitscore;

    public GameObject ZemanID;
    public GameObject DrahosID;
    public Transform pultZ;
    public Transform pultD;

    
   
   void Start()
    {
        GameObject zemanID;
        zemanID = Instantiate(ZemanID, pultZ.position, Quaternion.identity) as GameObject;
        zemanID.name = "zemainID";

        GameObject drahosID;
        drahosID = Instantiate(DrahosID, pultD.position, Quaternion.identity) as GameObject;
        drahosID.name = "drahosID";  
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldpoint, Vector2.zero);

            if (!hit)
            {
                Debug.Log("No hit");
            }

            if (hit.collider.CompareTag("Zeman"))
            {
               
                thehitscore.ScoreZtoAdd();
                Destroy(GameObject.FindWithTag("Zeman"));
                Destroy(GameObject.FindWithTag("Drahos"));
                StartCoroutine(Changeposotions());

                // Při kliknutí na protikandidáta zavibruje
                if (PlayerPrefs.GetInt("prezident", 0) == 1)
                {
                    Handheld.Vibrate();
                }
                // Při kliknutí na mého kandidáta přehrát zvuk
                if (PlayerPrefs.GetInt("prezident", 0) == 0)
                {
                    GetComponent<AudioSource>().Play();
                }

            }

            if (hit.collider.CompareTag("Drahos"))
            {

                thehitscore.ScoreDtoAdd();
                Destroy(GameObject.FindWithTag("Drahos"));
                Destroy(GameObject.FindWithTag("Zeman"));
                StartCoroutine(Changeposotions());

                // Při kliknutí na protikandidáta zavibruje
                if (PlayerPrefs.GetInt("prezident", 0) == 0)
                {
                    Handheld.Vibrate();
                }
                // Při kliknutí na mého kandidáta přehrát zvuk
                if (PlayerPrefs.GetInt("prezident", 0) == 1)
                {
                    GetComponent<AudioSource>().Play();
                }

            }

        }
    }

    IEnumerator Changeposotions()
    {
        yield return new WaitForSeconds(0.5f);
        int Change = Random.Range(1, 3);
        if (Change == 1)
        {
            pultZ.position = pultZ.position;
           
            GameObject Zeman = Instantiate(ZemanID, pultZ.position, Quaternion.identity) as GameObject;
            Zeman.name = "zemainID";

            GameObject drahos = Instantiate(DrahosID, pultD.position, Quaternion.identity) as GameObject;
            drahos.name = "drahosID";
        }
        else
        {

            GameObject Zeman = Instantiate(ZemanID, pultD.position, Quaternion.identity) as GameObject;
            Zeman.name = "zemainID";
            
            GameObject drahos = Instantiate(DrahosID, pultZ.position, Quaternion.identity) as GameObject;
            drahos.name = "drahosID";
        }
       
    }
}

   




