using UnityEngine;

public class KeyController : MonoBehaviour
{
    [Header("Low Major")]
    [SerializeField] private GameObject _lowC;
    [SerializeField] private GameObject _lowD;
    [SerializeField] private GameObject _lowE;
    [SerializeField] private GameObject _lowF;
    [SerializeField] private GameObject _lowG;
    [SerializeField] private GameObject _lowA;
    [SerializeField] private GameObject _lowB;

    [Header("Low Sharp")]
    [SerializeField] private GameObject _lowCs;
    [SerializeField] private GameObject _lowDs;
    [SerializeField] private GameObject _lowFs;
    [SerializeField] private GameObject _lowGs;
    [SerializeField] private GameObject _lowAs;

    [Header("High Major")]
    [SerializeField] private GameObject _highC;
    [SerializeField] private GameObject _highD;
    [SerializeField] private GameObject _highE;
    [SerializeField] private GameObject _highF;
    [SerializeField] private GameObject _highG;
    [SerializeField] private GameObject _highA;
    [SerializeField] private GameObject _highB;

    [Header("High Sharp")]
    [SerializeField] private GameObject _highCs;
    [SerializeField] private GameObject _highDs;
    [SerializeField] private GameObject _highFs;
    [SerializeField] private GameObject _highGs;
    [SerializeField] private GameObject _highAs;


    private void Update()
    {
        //------- LOW MAJORS -----------//

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _lowC.SetActive(false);
            _lowC.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.W))
        {
            _lowD.SetActive(false);
            _lowD.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.E))
        {
            _lowE.SetActive(false);
            _lowE.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.R))
        {
            _lowF.SetActive(false);
            _lowF.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.T))
        {
            _lowG.SetActive(false);
            _lowG.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _lowA.SetActive(false);
            _lowA.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.U))
        {
            _lowB.SetActive(false);
            _lowB.SetActive(true);
        }// end note

        //------- LOW SHARPS -----------//

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _lowCs.SetActive(false);
            _lowCs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _lowDs.SetActive(false);
            _lowDs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _lowFs.SetActive(false);
            _lowFs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            _lowGs.SetActive(false);
            _lowGs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            _lowAs.SetActive(false);
            _lowAs.SetActive(true);
        }// end note

        //------- HIGH MAJORS -----------//

        if (Input.GetKeyDown(KeyCode.I))
        {
            _highC.SetActive(false);
            _highC.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.O))
        {
            _highD.SetActive(false);
            _highD.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.P))
        {
            _highE.SetActive(false);
            _highE.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            _highF.SetActive(false);
            _highF.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            _highG.SetActive(false);
            _highG.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            _highA.SetActive(false);
            _highA.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.End))
        {
            _highB.SetActive(false);
            _highB.SetActive(true);
        }// end note

        //------- HIGH SHARPS -----------//

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            _highCs.SetActive(false);
            _highCs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            _highDs.SetActive(false);
            _highDs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            _highFs.SetActive(false);
            _highFs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Plus))
        {
            _highGs.SetActive(false);
            _highGs.SetActive(true);
        }// end note
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            _highAs.SetActive(false);
            _highAs.SetActive(true);
        }// end note

    }// Update

}// class
