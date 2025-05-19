using UnityEngine;

public class player : MonoBehaviour
{

    public int numero;
    public float velocidade = 20;
    
    
    
    void Start()
    {
        numero = 0;
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
           gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade*  Time.deltaTime, 0, 0);
        }
    }

}
