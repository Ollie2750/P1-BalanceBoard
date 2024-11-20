using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeahBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject Sphere;

    Animator animator;

    private AnimatorClipInfo[] clipInfo;

    // Start is called before the first frame update
    void Start()
    {
        Sphere.SetActive(false);
        animator = GetComponent<Animator>();
        Debug.Log(GetCurrentClipName());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("metarig|Roll up");
        }
    }

    public string GetCurrentClipName()
    {
        int layerIndex = 0;
        clipInfo = animator.GetCurrentAnimatorClipInfo(layerIndex);
        return clipInfo[0].clip.name;
    }
}
