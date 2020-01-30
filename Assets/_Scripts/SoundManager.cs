using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;
using EventInstance = FMOD.Studio.EventInstance;
using RuntimeManager = FMODUnity.RuntimeManager;

public class SoundManager : Singleton<SoundManager>
{
    [Header("FMOD Evenement")]

    [EventRef]
    public string ambiantSoundCollectible;
    private EventInstance ambiantSoundCollectibleInstance;

    [EventRef]
    public string contactSoundCollectible;
    private EventInstance contactSoundCollectibleInstance;

    [EventRef]
    public string ambiantSoundInterestPoint;
    private EventInstance ambiantSoundInterestPointInstance;

    [EventRef]
    public string contactSoundInterestPoint;
    private EventInstance contactSoundInterestPointInstance;

    [EventRef]
    public string changeCompassFonction;
    private EventInstance changeCompassFonctionInstance;

    [EventRef]
    public string perfectCompassFonction;
    private EventInstance perfectCompassFonctionInstance;

    [EventRef]
    public string newInterestPointFocus;
    private EventInstance newInterestPointFocusInstance;

    [EventRef]
    public string newPartCreate;
    private EventInstance newPartCreateInstance;

    [EventRef]
    public string newPartCreateImpossible;
    private EventInstance newPartCreateImpossibleInstance;

    [EventRef]
    public string movementOnPath;
    private EventInstance movementOnPathInstance;

    [EventRef]
    public string endOfRoad;
    private EventInstance endOfRoadInstance;

    [EventRef]
    public string previsualisation;
    private EventInstance previsualisationInstance;

    [EventRef]
    public string deathOfCharacter;
    private EventInstance deathOfCharacterInstance;

    [EventRef]
    public string nearAWall;
    private EventInstance nearAWallInstance;

    [EventRef]
    public string activationOfPower;
    private EventInstance activationOfPowerInstance;


    private void Awake()
    {
        ambiantSoundCollectibleInstance = RuntimeManager.CreateInstance(ambiantSoundCollectible);
        contactSoundCollectibleInstance = RuntimeManager.CreateInstance(contactSoundCollectible);
        ambiantSoundInterestPointInstance = RuntimeManager.CreateInstance(ambiantSoundInterestPoint);
        contactSoundInterestPointInstance = RuntimeManager.CreateInstance(contactSoundInterestPoint);
        changeCompassFonctionInstance = RuntimeManager.CreateInstance(changeCompassFonction);
        perfectCompassFonctionInstance = RuntimeManager.CreateInstance(perfectCompassFonction);
        newInterestPointFocusInstance = RuntimeManager.CreateInstance(newInterestPointFocus);
        newPartCreateInstance = RuntimeManager.CreateInstance(newPartCreate);
        newPartCreateImpossibleInstance = RuntimeManager.CreateInstance(newPartCreateImpossible);
        movementOnPathInstance = RuntimeManager.CreateInstance(movementOnPath);
        endOfRoadInstance = RuntimeManager.CreateInstance(endOfRoad);
        previsualisationInstance = RuntimeManager.CreateInstance(previsualisation);
        deathOfCharacterInstance = RuntimeManager.CreateInstance(deathOfCharacter);
        nearAWallInstance = RuntimeManager.CreateInstance(nearAWall);
        activationOfPowerInstance = RuntimeManager.CreateInstance(activationOfPower);
    }


    /// <summary>
    /// When the player touch a collectible
    /// DONE
    /// </summary>
    public void ContactSoundCollectible()
    {
        contactSoundCollectibleInstance.start();
    }

    /// <summary>
    /// When the player touch the interest point
    /// DONE
    /// </summary>
    public void ContactSoundInterestPoint()
    {
        contactSoundInterestPointInstance.start();
    }

    /// <summary>
    /// When the player touch a collectible and there is not all the collectible collected
    /// </summary>
    public void ChangeCompassFonction()
    {
        changeCompassFonctionInstance.start();
    }

    /// <summary>
    /// When the player touch a collectible and there is exactly the right amount of collectible collected
    /// </summary>
    public void PerfectCompassFonction()
    {
        perfectCompassFonctionInstance.start();
    }

    /// <summary>
    /// When the player touch a interest point 
    /// </summary>
    public void NewInterestPointFocus()
    {
        newInterestPointFocusInstance.start();
    }

    /// <summary>
    /// When the player hit the button to create a path
    /// Done
    /// </summary>
    public void NewPartCreate()
    {
        newPartCreateInstance.start();
        print("Sound");

    }

    /// <summary>
    /// When the player hit the button to create a path but the player can't spawn it
    /// </summary>
    public void NewPartCreateInpossible()
    {
        newPartCreateImpossibleInstance.start();
    }

    /// <summary>
    /// When the player slide on the path
    /// </summary>
    public void MovementOnPath()
    {
        movementOnPathInstance.start();
    }

    /// <summary>
    /// When the player is near the end of the road
    /// </summary>
    public void EndOfRoad()
    {
        endOfRoadInstance.start();
    }

    /// <summary>
    /// when the player move his arm to move the previsualisation
    /// </summary>
    public void Previsualisation()
    {
        previsualisationInstance.start();
    }

    /// <summary>
    /// when the player hit a wall
    /// DONE
    /// </summary>
    public void DeathOfCharacter()
    {
        deathOfCharacterInstance.start();
    }

    /// <summary>
    /// When the player is near a wall
    /// </summary>
    public void NearAWall()
    {
        nearAWallInstance.start();
    }

    /// <summary>
    /// When the player using an ability
    /// </summary>
    public void ActivationOfPower()
    {
        activationOfPowerInstance.start();
    }





























    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
