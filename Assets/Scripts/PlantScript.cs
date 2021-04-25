using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public int plantStage = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        growPlant();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void growPlant()
    {
        int i = 0;
        foreach (Transform stage in transform)
        {
            if (i == plantStage)
                stage.gameObject.SetActive(true);
            else
                stage.gameObject.SetActive(false);
            i++;
        }
    }
}
