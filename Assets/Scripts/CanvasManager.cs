using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CanvasManager : MonoBehaviour
{
    #region Public Properties

    public GameObject IronManGO;
    public GameObject DefaultFaceGO;

    #endregion

    #region Private Fields

    private ARFaceManager arFaceManager;
    private TextMeshProUGUI textMeshPro;
    //private GameObject selectedMask;
    
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        arFaceManager = GameObject.Find("AR Session Origin").GetComponent<ARFaceManager>();
        textMeshPro = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IronManFaceSelect()
    {
        arFaceManager.facePrefab = IronManGO;
        textMeshPro.text = "Iron Man";
        ReloadComponents();
    }

    public void DefaultFaceSelect()
    {
        arFaceManager.facePrefab = DefaultFaceGO;
        textMeshPro.text = "Default Face";
        ReloadComponents();
    }

    void ReloadComponents()
    {
        GameObject arSessionGO = GameObject.Find("AR Session");
        GameObject arSessionOriginGO = GameObject.Find("AR Session Origin");
        arSessionGO.SetActive(false);
        arSessionOriginGO.SetActive(false);
        arSessionGO.SetActive(true);
        arSessionOriginGO.SetActive(true);
    }
}
