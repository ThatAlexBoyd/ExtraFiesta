using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class CityButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private TMP_Text label; //assigned in prefab

    private City cityAssigned;

    public void SetupCityButton(City city)
    {
        cityAssigned = city;
        label.text = cityAssigned.DisplayName;
    }

    public void OnPointerClick(PointerEventData data)
    {
        GameController.Instance.CitySelected(cityAssigned);
    }


}
