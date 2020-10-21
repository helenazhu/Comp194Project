using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class Keypad : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public GameObject rightHand;
>>>>>>> Stashed changes
    public GameObject crate;
    int buttonName;
    bool codeStatus = false;
    string codeTrue = "2143";
    string codeTemp = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (iscodeCorrect() == false){
            GetComponent<AudioSource>().Play();
        }
        else{
            crate.GetComponent<OVRGrabbable>().enabled = false;
            crate.transform.GetChild(0).GetComponent<OVRGrabbable>().enabled = true;
            crate.transform.GetChild(0).GetComponent<BoxCollider>().enabled = true;
            crate.transform.GetChild(1).GetComponent<OVRGrabbable>().enabled = true;
            crate.transform.GetChild(1).GetComponent<BoxCollider>().enabled = true;
<<<<<<< Updated upstream
        } 
=======
        }
>>>>>>> Stashed changes
    }
    
    private bool iscodeCorrect()
    {
        ArrayList buttonList = new ArrayList();
        for (int i = 0; i < 10; i++){
            buttonList.Add(new Keypad());
        }
        Keypad clear = new Keypad();
        if(getButtonDown() != 11){
            codeTemp += getButtonDown().ToString();
        }
        
        if(codeTemp.Length == 4){
            if(codeTemp.Equals(codeTrue)){
                return true;
            }else{
                codeTemp = "";
                return false;
            }
        }else{
            return false;
        }
    }

    public int getButtonDown(){
<<<<<<< Updated upstream
        Ray ray = new Ray(transform.position, transform.forward);
=======
        Ray ray = new Ray(rightHand.transform.position, rightHand.transform.forward);
>>>>>>> Stashed changes
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 0.05f)){
            if (hit.collider.gameObject.name == "Button0"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 0;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button1"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 1;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button2"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 2;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button3"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 3;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button4"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 4;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button5"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 5;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button6"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 6;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button7"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 7;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button8"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 8;
                return buttonName;
            }
            else if (hit.collider.gameObject.name == "Button9"){
                hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                buttonName = 9;
                return buttonName;
            }
        }
        return 11;
    }
    }

