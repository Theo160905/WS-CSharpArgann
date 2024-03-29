using UnityEngine;

public class Plot : MonoBehaviour
{
    private PlayerMain _playermain;

    public Plant Plant { get; private set; }

    // Méthode pour que le joueur puisse poser une plante
    public void PlantSeed(SO_Plants seedData)
    {
        if (Plant != null)
        {
            return;
        }

        GameObject obj = Instantiate(seedData.Prefab, transform.position, Quaternion.identity);
        Plant = obj.GetComponent<Plant>();
        Plant.Initialize(seedData);
        StartCoroutine(Plant.Growth());
    }

    // Méthode pour pouvoir récupérer la plant posser sur le "plot"
    public int GatherPlant()
    {
        if (Plant == null || !Plant.IsGrown)
        {
            return 0;
        }

        SO_Plants data = Plant.Data;
        Destroy(Plant.gameObject);
        Destroy(Plant.PlantReady);
        Plant = null;
        return data.SaleValue;
    }
}
