
using UnityEngine;
using TMPro;

using UnityEngine.XR;

public class TextToSpeech : MonoBehaviour
{
    public TextMeshPro _text;

    // Start is called before the first frame update
    private InputData _inputData;


    private void Start()
    {
        _inputData = GetComponent<InputData>();
    }
    // Update is called once per frame
    void Update()
    {
        _inputData._leftController.TryGetFeatureValue(CommonUsages.triggerButton, out bool isPressed);
        if (isPressed)
        {
           
        }
        else {
         
        }
    }


  
}