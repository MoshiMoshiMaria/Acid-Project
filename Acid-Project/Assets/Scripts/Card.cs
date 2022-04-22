using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//In future, this information will be taken from a txt file and used in the constructor - so look forward to writing that code

public class Card
{
    public int i_id;//!< ID of the card
    public string s_name;//!< Name of the Card
    public int i_action;//!< Action of the card - int code will define action, extra parameters supplied elsewhere
    public List<int> l_extraInfo;//!< Extra info needed by the action in order to work - length will depend on the action
    public int i_cost;//!< Cost of the card to perform action
    public int i_moveLength;//!< How much movement the card can be burned for

    public string s_description;//!< Description of the card and it's use

    [SerializeField]
    private Image image;//!< Image to be displayed on the card

    /*! \function Card
     * \brief Constructor for the Card class
     * Constructor takes the name, action code and the extra information
     */
    public Card(int id, string name, int action, List<int> extraInfo)
    {
        i_id = id;
        s_name = name;
        i_action = action;
        //l_extraInfo = new List<int>(extraInfo.Count); //Doing this an easier way now
        l_extraInfo = extraInfo;

        //load image with same name
    }

    /*! \function DisplayCard
     * \brief Function to display a card on a given template
     * Each CardTemplate object will be modified by this class inorder to 
     */
    //public void DisplayCard(CardTemplate displayCanvas)
    //{
    //    //Unimplemented
    //}
}
