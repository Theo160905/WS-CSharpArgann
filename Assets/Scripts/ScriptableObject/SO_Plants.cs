using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Plants")]
public class SO_Plants : ScriptableObject
{
    public GameObject Prefab;

    [field: SerializeField]
    public string Name { get; private set; }

    [field: SerializeField]
    public int BuyValue { get; private set; }

    [field: SerializeField]
    public int SaleValue { get; private set; }

    [field: SerializeField]
    public int GrowthTime { get; private set; }
}
