using System.Collections;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public bool IsGrown { get; private set; }

    public SO_Plants Data { get; private set; }

    [field: SerializeField]
    public GameObject IsReady { get; set; }

    [HideInInspector]
    public GameObject PlantReady { get; private set; }

    public void Initialize(SO_Plants data)
    {
        IsGrown = false;
        Data = data;
    }

    // Méthode pour que la plante puisse être récupéré lorsque la méthode est appelé
    public IEnumerator Growth()
    {
        yield return new WaitForSeconds(Data.GrowthTime);

        // _plantready sert à montre au joueur que la plante a fini de pousser
        PlantReady = Instantiate(IsReady);
        PlantReady.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        IsGrown = true;
    }
}
