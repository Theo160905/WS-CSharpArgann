using UnityEngine;
using System.Threading.Tasks;

public class Plant : MonoBehaviour
{
    public bool IsGrown { get; private set; }

    public SO_Plants Data { get; private set; }

    [SerializeField]
    private GameObject _isready;

    public void Initialize(SO_Plants data)
    {
        IsGrown = false;
        Data = data;
    }

    //Méthode pour que la plante puisse être récupéré lorsque la méthode est appelé
    public async void Growth()
    {
        //Async pour attrendre le temps de chaque temps de pousse de chauque plantes
        await Task.Delay(Data.GrowthTime);
        GameObject newTruc = Instantiate(_isready);
        newTruc.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);
        newTruc.transform.parent = gameObject.transform;
        IsGrown = true;
    }
}
