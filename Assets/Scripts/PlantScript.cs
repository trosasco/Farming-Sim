using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    public int plantStage = 0;
    public DayController dc;

    private int dayPlanted;
    private int age;
    
    // Start is called before the first frame update
    void Start()
    {
        dayPlanted = dc.day;
        growPlant();
    }

    // Update is called once per frame
    void Update()
    {
        if (dc.day > dayPlanted)
        {
            dayPlanted = dc.day;
            age += 1;
        }

        if (plantStage < age)
        {
            if (age == 0)
            {
                plantStage = age;
                growPlant();
            }
            else if (age == 1)
            {
                plantStage = age;
                growPlant();
            }
            else if (age == 2)
            {
                plantStage = age;
                growPlant();
            }
            else if (age == 3)
            {
                plantStage = age;
                growPlant();
            }
            else if (age == 4)
            {
                plantStage = age;
                growPlant();
            }
        }
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
