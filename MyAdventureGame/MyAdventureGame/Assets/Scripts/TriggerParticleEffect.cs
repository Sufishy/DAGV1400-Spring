using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particleSystem; // reference to the particle system girly

    public int firstEmissionAmount = 10; // exposed variable for first emission
    public int secondEmissionAmount = 20; // variable for second emission
    public int thirdEmissionAmount = 30; // third emission
    public float delayBetweenEmissions = 0.5f; // time between emissions
    
    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop(); // fix for particles playing at beginning
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // check if the player triggered the event
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }
    
    // coroutine to emit particles mutliple times with delays
    private IEnumerator EmitParticlesCoroutine()
    {
        //first emission
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
        
        //second
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
        
        //third
        particleSystem.Emit(thirdEmissionAmount);
    }
}