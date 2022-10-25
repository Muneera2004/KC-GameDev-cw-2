using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Muneera";
        int heroHight = 5;
        int heroage = 18;
        int heroSuperPower = 90;
        print(heroName+heroHight+heroage+heroSuperPower);

        string villainName = "Moon";
        int villainHight= 190;
        int villainage = 10;
        string villaniSuperPower = "None";
        print(villainName + villainHight + villainage + villaniSuperPower);

        string ageDifference = "Muneera" + "Moon";
        print(heroage - villainage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}