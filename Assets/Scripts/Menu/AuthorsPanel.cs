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

    [SerializeField] private GameObject _mainMenu;

    public void Hide()
    {
        StartCoroutine(CloseAuthorsPanel());
    }

    private IEnumerator CloseAuthorsPanel()
    {
        _animator.Play(_hiding.name);

        yield return new WaitForSeconds(_hiding.length);

        gameObject.SetActive(false);
        _mainMenu.SetActive(true);
    }
}
