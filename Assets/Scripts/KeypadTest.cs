using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadTest : MonoBehaviour
{
    string correctCode = "2143";
    string inputCode = "";
    public GameObject crate;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isCodeCorrect();
    }

    private bool isCodeCorrect(){
        if(isButtonPressed()){
            if(inputCode.Length == correctCode.Length){
                if(inputCode == correctCode){
                    crate.GetComponent<OVRGrabbable>().enabled = false;
                    crate.transform.GetChild(0).gameObject.GetComponent<OVRGrabbable>().enabled = true;
                    crate.transform.GetChild(0).gameObject.GetComponent<BoxCollider>().enabled = true;
                    crate.transform.GetChild(1).gameObject.GetComponent<OVRGrabbable>().enabled = true;
                    crate.transform.GetChild(1).gameObject.GetComponent<BoxCollider>().enabled = true;
                    return true;
                    //keypad.SetActive(false);
                }
                else{
                    inputCode = "";
                    return false;
                }
            }  
        } 
        return false;
    }

    public bool isButtonPressed(){
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.gameObject.name=="Button1"){
                inputCode+="1";
            }
            else if(hit.collider.gameObject.name=="Button2"){
                inputCode+="2";
            }
            else if(hit.collider.gameObject.name=="Button3"){
                inputCode+="3";
            }
            else if(hit.collider.gameObject.name=="Button3"){
                inputCode+="3";
            }
            else if(hit.collider.gameObject.name=="Button4"){
                inputCode+="4";
            }
            else if(hit.collider.gameObject.name=="Button5"){
                inputCode+="5";
            }
            else if(hit.collider.gameObject.name=="Button6"){
                inputCode+="6";
            }
            else if(hit.collider.gameObject.name=="Button7"){
                inputCode+="7";
            }
            else if(hit.collider.gameObject.name=="Button8"){
                inputCode+="8";
            }
            else if(hit.collider.gameObject.name=="Button9"){
                inputCode+="9";
            }
            else if(hit.collider.gameObject.name=="ButtonRed"){
                inputCode="";
            }
            return true;
        }
        return false;
    }
}
