using UnityEngine;
using UnityEngine.UI;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class SwordCutter : MonoBehaviour {

	public Material capMaterial;
    public static int int_score;
    public TextMesh scoreText;
 
 
    void Start() {
        int_score = 1;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject victim = collision.collider.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
        {
            pieces[1].AddComponent<Rigidbody>();
            MeshCollider temp= pieces[1].AddComponent<MeshCollider>();
            temp.convex = true;
            //GetComponent<TextMesh>().text = "testing".ToString();//"Score:" + int_score;

            //scoreText = GetComponent<TextMesh>();

        }

        //Destroy(pieces[1], 1);
    }

    void Update()
    {
        scoreText.text = "Score: " + int_score.ToString();//"Score:" + int_score;
        
    }

}
