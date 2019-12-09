using UnityEngine;
using MalbersAnimations.HAP;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Character.Abilities;



public class HAPRide : DetectObjectAbilityBase
{
    [Tooltip("A reference to the Ultimate Character Controller camera.")]
    [SerializeField] private Camera m_Camera;
    [Tooltip("A reference to the Rider Script Component on this character.")]
    public MRider mRider;

    protected override void AbilityStarted()
    {
        base.AbilityStarted();
        //Disable the UCC camera since there is no UCC character on the horse.
        if (m_Camera != null)
        {
            m_Camera.enabled = false;
        }
        else
        { Debug.LogError("The 'HAPRide' script requires a reference to the Camera with a UCC Camera Controller script attached."); }

        //Trying to mount a horse!
        mRider.MountAnimal();
    }

}
