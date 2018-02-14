using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class asteroidMovement : MonoBehaviour {

    public Text lifeText;
    
   
   
    private mananger scriptPc;
    private int life;
    
   
    // Use this for initialization
    

     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            

            life -= 1;
            // para refrescar el texto de vidas
            Updatelife();
        }
    }
    void Start()
    {
        scriptPc = GameObject.Find("PC").GetComponent<mananger>();
        life = Random.Range(1, 6);
        // para refrescar el texto de vidas
        Updatelife();
        

    }
    // Update is called once per frame
    void Update()
    {
        if (life <= 0 )
        {
            scriptPc.AddScore(1);
            Destroy(this.gameObject);
            
        }   
    }
    void Updatelife()
    {
        lifeText.text = "" + life;
    }

}