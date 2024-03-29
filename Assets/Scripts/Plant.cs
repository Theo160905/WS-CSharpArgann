using UnityEngine;
using System.Threading.Tasks;

public class Plant : MonoBehaviour
{
    public bool IsGrown { get; private set; }

    public SO_Plants Data { get; private set; }

    [SerializeField]
    private GameObject _isready;

    [HideInInspector]
    public GameObject _plantready;

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
        //Une fois que la plante a fini de pousser un symbole apparait pour signaler que le joueur peut récupérer la plante
        _plantready = Instantiate(_isready);
        _plantready.transform.position = new Vector3 (transform.position.x, transform.position.y + 1, transform.position.z);
        IsGrown = true;
    }
}
