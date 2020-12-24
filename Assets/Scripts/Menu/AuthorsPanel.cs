using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Animator))]
public class AuthorsPanel : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AnimationClip _hiding;

    public void Hide(GameObject panel)
    {
        _animator.Play("Hiding");

        StartCoroutine(ClosePanel(panel));
    }

    private IEnumerator ClosePanel(GameObject panel)
    {
        yield return new WaitForSeconds(_hiding.length);

        gameObject.SetActive(false);
        panel.SetActive(true);
    }
}
