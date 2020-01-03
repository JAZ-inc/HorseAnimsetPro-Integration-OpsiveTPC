using MalbersAnimations.HAP;
using UnityEngine;
using UnityEngine.Events;

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
            StartDismount();
        }
    }

    private void ResetUCCCamera()
    {
        //Enable the UCC camera since there is now a UCC character again!
        m_Camera.enabled = true;
        CanDismount = false;
    }

    private void StartMount()
    {
        //Disable the UCC camera since there is no UCC character on the horse.
        if (m_Camera != null)
        {
            m_Camera.enabled = false;
        }
        else
        { Debug.LogError("The 'HAPRide' script requires a reference to the Camera with a UCC Camera Controller script attached."); }
    }

    private void StartDismount()
    {
        //Trying to dismount a horse!
        mRider.DismountAnimal();
    }
}
