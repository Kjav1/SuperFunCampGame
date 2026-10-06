using UnityEngine;
using UnityEngine.InputSystem;

public class DiceManagerScript : MonoBehaviour
{
    float diceHeight = 5f; 
    Vector3 diceTorque; 
    float diceMinTorque = 0.1f; 
    float diceMaxTorque = 0.7f; 

    [SerializeField] GameObject dice;
    InputAction diceRoll; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        diceRoll = InputSystem.actions.FindAction("Dice"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (diceRoll.WasPressedThisFrame()) {
            //Instantiates Dice
            GameObject diceBlock = Instantiate(dice);
            
            diceBlock.transform.position = new Vector3(0, 3, 0);

            Rigidbody diceRB = diceBlock.GetComponent<Rigidbody>(); 
            if (diceRB != null) {
                //tosses dice into air
                diceRB.AddForce(Vector3.up * diceHeight, ForceMode.Impulse); 
                
                //Random spin force (torque) on dice
                diceTorque = new Vector3(Random.Range(diceMinTorque, diceMaxTorque), Random.Range(diceMinTorque, diceMaxTorque), Random.Range(diceMinTorque, diceMaxTorque));
                diceRB.AddTorque(diceTorque, ForceMode.Impulse);
            }
        }
    }


}
