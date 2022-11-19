1) Clone this repository onto your machine.
2) Open project and import Opsive UCC (TPC or FPC should both work)
3) Import and set up an Opsive character.
4) Add the Rider script from HAP and the new HAPRide ability to your Opsive character.
5) Go to the rider component and click the "Setup Mount Layer" button to add the riding animations to your animator controller. Then add the HAPDismount Script as a new component on your Opsive character.
6) Set the component references in the ability HAPRide and scripts Rider, and HAPDismount as they are shown in the images.
7) You will have no cameras rendering when the character goes to mount the horse unless you add a camera which follows the characters Head transform. I recommend one of the HAP camera prefabs. Place this camera below your UCC camera in the hierarchy so it will just take over when the UCC camera component is disabled for the HAPRide ability.


Step 6 Visual references.
1:
[MRider and HAPDismount Scripts Component Setup](https://pasteboard.co/IKbtLRD.jpg)
2:
[Cameras Setup](https://pasteboard.co/IKbsXpV.jpg)
3:
[HAPRide Ability Setup](https://pasteboard.co/IKbtaxm.jpg)
4:
[(Final Camera Error Fix) Event Setup](https://pasteboard.co/INcuX2v.jpg)

Optional Step to remove the IndexOutOfBounds error:
Go into KinematicObjectManager.cs which is a script included with Opsive UCC at the time of writing.
Change the code here:
 `private void SetCharacterMovementInputInternal(int characterIndex, float horizontalMovement, float forwardMovement)
        {
            m_Characters[characterIndex].HorizontalMovement = horizontalMovement;
            m_Characters[characterIndex].ForwardMovement = forwardMovement;
        }`
        
To this code:
 `private void SetCharacterMovementInputInternal(int characterIndex, float horizontalMovement, float forwardMovement)
        {
            if (characterIndex >0) {
            m_Characters[characterIndex].HorizontalMovement = horizontalMovement;
            m_Characters[characterIndex].ForwardMovement = forwardMovement;
            }
        }`


Optional step to tweak the reins and get them looking more realistic:[Tweak the IKReins Component on your Horse](https://pasteboard.co/IQ5Ourm.jpg)

That should remove all errors and give a seamless integrated effect.
Enjoy!
