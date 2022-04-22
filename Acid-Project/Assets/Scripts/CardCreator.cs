using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCreator
{
    [SerializeField]
    private GameObject cardTemplatePrefab;//!< Prefab which holds the card template

    /*! \function CreateCard
     * \brief Creates a card from a prefab and set of information from a Card object using card id
     * Returns 1 on succesful card creation and 0 on a failure
     */
    public int CreateCard(int cardID, Transform location)
    {
        //Create card template object
        GameObject currentCard = GameObject.Instantiate(cardTemplatePrefab, location);

        //Get Components of the card to edit
        Text title = currentCard.transform.Find("Title").gameObject.GetComponent<Text>();
        Text cost = currentCard.transform.Find("Cost").gameObject.GetComponent<Text>(); 
        Text movt = currentCard.transform.Find("Movt").gameObject.GetComponent<Text>();
        Text desc = currentCard.transform.Find("Desc").gameObject.GetComponent<Text>();

        //Set Text and Image using information from Card object


        //Return 1 on success
        return 0;
    }
}
