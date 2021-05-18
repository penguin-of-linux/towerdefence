﻿using Components;
using UnityEngine;

namespace Controllers
{
    public class CameraController : MonoBehaviour
    {
        private Camera cam;
        private float targetZoom;
        private float zoomFactor = 3f;
        [SerializeField] private float zoomLerpSpeed = 10;
 
        // Start is called before the first frame update
        void Start()
        {
            cam = Camera.main;
            // ReSharper disable once PossibleNullReferenceException
            targetZoom = cam.orthographicSize;
        }
 
        // Update is called once per frame
        void Update()
        {
            float scrollData = Input.GetAxis("Mouse ScrollWheel");
            targetZoom -= scrollData * zoomFactor;
            targetZoom = Mathf.Clamp(targetZoom, 4.5f, 8f);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
        }

        private GameObject target;
    }
}
