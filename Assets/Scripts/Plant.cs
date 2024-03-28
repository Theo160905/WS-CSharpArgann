using UnityEngine;
using System.Threading.Tasks;

public class Plant : MonoBehaviour
{
    public bool IsGrown { get; private set; }

    public SO_Plants Data { get; private set; }

    public void Initialize(SO_Plants data)
    {
        IsGrown = false;
        Data = data;
    }

    public async void Growth()
    {
        await Task.Delay(Data.GrowthTime);
        Debug.Log("FINI");
        IsGrown = true;
        //Grandir la plante
    }
}
