using UnityEngine;

public class Collectable : MonoBehaviour,ICollectable
{

    public int value;
    void Start()
    {
        
    }
    public void Collect()
    {
        //-> sumar puntos
        //->poner un sonido
        //->ser destruida
        print("has coleccionado una moneda de valor :" + value);
        Destroy(gameObject);
    }
}
