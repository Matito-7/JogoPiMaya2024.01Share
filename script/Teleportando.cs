using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportando : MonoBehaviour
{
    [SerializeField] private Transform destination;
    // Start is called before the first frame update
    public Transform GetDestination()
    {
        return destination;
    }
}
