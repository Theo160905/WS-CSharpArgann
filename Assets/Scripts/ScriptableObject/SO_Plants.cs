using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Plants")]
public class SO_Plants : ScriptableObject
{
    public string Name;
    public int ID;
    public int BuyValue;
    public int SaleValue;
    public int GrowthTime;

    public int Nb_Plants;

    public GameObject Prefab;
}
