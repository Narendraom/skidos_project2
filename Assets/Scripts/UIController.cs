using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    [SerializeField]
    Text dataText;

    public void FetchButtonClicked()
    {
        dataText.text = NativeBridge.RetreiveData();

    }
}
