using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeypadTest : MonoBehaviour
{
    string correctCode = "2143";
    string inputCode = "";
    public GameObject crate;
    public GameObject canvas;
    bool triggerState = false;
    public GameObject collidingObject;
    public GameObject objectInHand;

    // public void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.GetComponent<Rigidbody>()) {
    //         collidingObject = other.gameObject;
    //     }
    // }

    // public void OnTriggerExit(Collider other)
    // {
    //     collidingObject = null;
    // }


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isButtonPressed()){
            isCodeCorrect();
        }
        
        // if(Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2f && collidingObject) {
        //     if(collidingObject.transform.tag=="Key"){
        //         GrabObject();
        //     }
            
        // }

        // if(Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") < 0.2f && objectInHand) {
        //         ReleaseObject();
        // }
        
    }

    // public void GrabObject()
    // {
    //     objectInHand = collidingObject;
    //     objectInHand.transform.SetParent (this.transform);
    //     objectInHand.GetComponent<Rigidbody>().isKinematic = true;
    // }

    // private void ReleaseObject()
    // {
    //     objectInHand.GetComponent<Rigidbody>().isKinematic = false;
    //     objectInHand.transform.SetParent (null);
    //     objectInHand = null;
    // }

    private bool isCodeCorrect(){
            if(inputCode.Length == correctCode.Length){
                if(inputCode == correctCode){
                    Destroy(crate);
                    GetComponent<LineRenderer>().enabled = false;
                    return true;
                    //keypad.SetActive(false);
                }
                else{
                    inputCode = "";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    return false;
                }
            }  
        return false;
    }

    public bool isButtonPressed(){
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")<0.2f){
            triggerState = false;
        }
        GetComponent<LineRenderer>().SetPosition(0, transform.position);

        if(Physics.Raycast(ray, out hit, 0.4f)){
            GetComponent<LineRenderer>().SetPosition(1, hit.point);
            Debug.Log(hit.collider.gameObject.name);

            if(hit.collider.gameObject.name=="Button 0"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="0";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                }
            }
            else if(hit.collider.gameObject.name=="Button 1"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="1";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 2"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="2";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 3"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="3";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 4"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="4";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 5"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="5";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 6"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="6";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 7"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="7";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 8"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="8";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button 9"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode+="9";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            else if(hit.collider.gameObject.name=="Button Red"){
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger")> 0.2f && triggerState==false){
                    inputCode="";
                    canvas.GetComponent<TMP_Text>().text = inputCode;
                    triggerState = true;
                }
            }
            return true;
        }
        else{
            GetComponent<LineRenderer>().SetPosition(1, transform.position+transform.forward*0.4f);
        }
        return false;
    }
}
