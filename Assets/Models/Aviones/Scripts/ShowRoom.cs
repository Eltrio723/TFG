using System;

using UnityEngine;

public class ShowRoom : MonoBehaviour
{
    #region Private fields

    private int _index;

    #endregion

    #region Private monobeahviour methods

    private void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.down, 10f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            Next();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            Previous();
    }

    #endregion

    #region Public methods

    public void Next()
    {
        transform.GetChild(_index).gameObject.SetActive(false);

        _index = GetCount(++_index, 0, transform.childCount - 1);

        transform.GetChild(_index).gameObject.SetActive(true);
    }

    public void Previous()
    {
        transform.GetChild(_index).gameObject.SetActive(false);

        _index = GetCount(--_index, 0, transform.childCount - 1);

        transform.GetChild(_index).gameObject.SetActive(true);
    }

    #endregion

    #region Private static methods

    private static int GetCount(int currentValue, int min, int max)
    {
        var length = max - min + 1;

        if (currentValue < min)
        {
            var overflow = Math.Abs(currentValue) - Math.Abs(min);
            overflow = overflow % length;
            currentValue = max + 1 - overflow;
        }
        else if (currentValue > max)
        {
            var overflow = Math.Abs(Math.Abs(currentValue) - Math.Abs(max));
            overflow = overflow % length;
            currentValue = min - 1 + overflow;
        }

        return currentValue;
    }

    #endregion
}
