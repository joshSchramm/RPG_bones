/* -----------------------------------------------------------------------------------
 * Class Name: UI_Buttons
 * -----------------------------------------------------------------------------------
 * Author: Joshua Schramm
 * Date Created: 
 * Last Updated:
 * -----------------------------------------------------------------------------------
 * Purpose: 
 * -----------------------------------------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Buttons : MonoBehaviour, ISelectHandler, IPointerEnterHandler
{

    #region VARIABLES
    
    #endregion

    #region GETTERS/SETTERS

    #endregion

    /* ------------------------------------------------------------------------------
    * Function Name: OnPointerEnter
    * Return types: N/A
    * Argument types: N/A
    * Author: 
    * Date Created: 
    * Last Updated: 
    * ------------------------------------------------------------------------------
    * Purpose: Detects when the mouse hovers over a button
    * ------------------------------------------------------------------------------
    */

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Do something.
        Debug.Log("<color=red>Event:</color> Completed mouse highlight.");
    }

    /* ------------------------------------------------------------------------------
    * Function Name: OnSelect
    * Return types: N/A
    * Argument types: N/A
    * Author: 
    * Date Created: 
    * Last Updated: 
    * ------------------------------------------------------------------------------
    * Purpose: Detects when the button becomes the 'current selection' with other input besides the mouse
    * ------------------------------------------------------------------------------
    */

    public void OnSelect(BaseEventData eventData)
    {
        // Do something.
        Debug.Log("<color=red>Event:</color> Completed selection.");
    }    
    
}
// End UI_Buttons