using UnityEngine;

public class player : MonoBehaviour
{

    public int numero;
    public float velocidade = 2;
    
    
    
    void Start()
    {
        numero = 0;
    }

  
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(velocidade, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
           
        }

    }



}
