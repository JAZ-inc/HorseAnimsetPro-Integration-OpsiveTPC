using MalbersAnimations.HAP;
using UnityEngine;

public class HAPDismount : MonoBehaviour
{
    [Tooltip("A reference to the Ultimate Character Controller camera.")]
    [SerializeField] private Camera m_Camera;
    [Tooltip("A reference to the MRide component on this Ultimate Character Controller Character.")]
    [SerializeField] private MRider mRider;
    [Tooltip("The input name used for dismounting.")]
    [SerializeField] private string inputName;
    bool CanDismount=false;


    // Start is called before the first frame update
    void Awake()
    {
        mRider = this.GetComponent<MRider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(inputName))
        {
            NewMethod();
        }

        if (mRider.IsRiding && CanDismount == false)
        {
            CanDismount = true;
        }

        if (CanDismount == true) {
        if (!mRider.IsOnHorse)
        {
            //Enable the UCC camera since there is now a UCC character on the horse again!
            m_Camera.enabled = true;
            CanDismount = false;
        }
    }

    }

    private void NewMethod()
    {
        //Trying to dismount a horse!
        mRider.DismountAnimal();
    }
}
