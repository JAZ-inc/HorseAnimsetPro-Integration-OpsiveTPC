1) Clone this repository onto your machine.
2) Open project and import Opsive UCC (TPC or FPC should both work)
3) Import and set up an Opsive character.
4) Add the HAPRide ability to your Opsive character.
5) Add the HAPDismount Script as a new component on your Opsive character.
6) Set the component references in the ability HAPRide and HAPDismount as they are shown in the images.

Step 6 Visual references.
1:
[MRider and HAPDismount Scripts Component Setup](https://pasteboard.co/IKbtLRD.jpg)
2:
[Cameras Setup](https://pasteboard.co/IKbsXpV.jpg)
3:
[HAPRide Ability Setup](https://pasteboard.co/IKbtaxm.jpg)

Optional Step to remove the IndexOutOfBounds error:
Go into KinematicObjectManager.cs which is a script included with Opsive UCC at the time of writing.
Change the code here:
` private void SetCharacterMovementInputInternal(int characterIndex, float horizontalMovement, float forwardMovement)
        {
            m_Characters[characterIndex].HorizontalMovement = horizontalMovement;
            m_Characters[characterIndex].ForwardMovement = forwardMovement;
        }`
        
        To this code:
` private void SetCharacterMovementInputInternal(int characterIndex, float horizontalMovement, float forwardMovement)
        {
            if (characterIndex >0) {
            m_Characters[characterIndex].HorizontalMovement = horizontalMovement;
            m_Characters[characterIndex].ForwardMovement = forwardMovement;
            }
        }`

That should remove all errors.
Enjoy!
