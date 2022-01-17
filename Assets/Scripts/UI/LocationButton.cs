using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TMP_Text label; //assigned in prefab

    private Marker locationAssigned;

    public void SetupLocationButton(Marker location)
    {
        locationAssigned = location;
        label.text = locationAssigned.DisplayName;
    }

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("location");
    }
}
