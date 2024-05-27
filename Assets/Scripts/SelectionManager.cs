using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    IRaycastProvider iRayProvider;
    ISelector iSelector;
    ISelectionMode iSelectionMode;

    private Transform currentSelection;

    private void Awake()
    {
        iRayProvider = GetComponent<IRaycastProvider>();
        iSelector = GetComponent<ISelector>();
        iSelectionMode = GetComponent<ISelectionMode>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSelection != null)
            iSelectionMode.OnDeselect(currentSelection);
            iSelector.Check(iRayProvider.CreateRay());
            currentSelection = iSelector.GetSelection();
        if (currentSelection != null)
            iSelectionMode.OnSelect(currentSelection);
        
    }
}
