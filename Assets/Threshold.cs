using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Threshold : MonoBehaviour
{
        public Slider thresholdSlider;

        public void SetMaxHealth(int threshold)
        {
            this.thresholdSlider.maxValue = threshold;
        }
        public void Setthreshold(int threshold)
        {
            this.thresholdSlider.value = threshold;
        }
}
