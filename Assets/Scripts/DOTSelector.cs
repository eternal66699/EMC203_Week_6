using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTSelector : MonoBehaviour, ISelector
{
    [SerializeField] string selectableTag = "Selectable";
    public List<SelectableTEXT> selectable;
    public float threshold;
    private Transform _selection;

    public void Check(Ray ray)
    {
        _selection = null;
        for (int i = 0; i < selectable.Count; i++)
        {
            Vector3 vector1 = ray.direction;
            Vector3 vector2 = selectable[i].transform.position - ray.origin;

            float lookpercentage = Vector3.Dot(vector1.normalized, vector2.normalized);
        }
    }

    public Transform GetSelection() { return _selection; }
}
