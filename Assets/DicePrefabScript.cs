using UnityEngine;

public class DicePrefabScript : MonoBehaviour
{
    Rigidbody rb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity == Vector3.zero) { //if stops moving
            //how to calculate which side is on top? 
            Debug.Log("Landed!");
            

        }
    }
}
