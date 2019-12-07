using MalbersAnimations.HAP;
using UnityEngine;

public class HAPDismount : MonoBehaviour
{
    [Tooltip("A reference to the Ultimate Character Controller camera.")]
    [SerializeField] private Camera m_Camera;
    public MRider mRider;

    // Start is called before the first frame update
    void Start()
    {
        mRider=this.GetComponent<MRider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            NewMethod(); }
    }

    private void NewMethod()
    {
        //Enable the UCC camera since there is now a UCC character on the horse again!
        m_Camera.enabled = true;
        //Trying to dismount a horse!
        mRider.DismountAnimal();
    }
}
