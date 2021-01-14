using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using IJunior.TypedScenes;

[RequireComponent(typeof(Collider2D))]
public class Obstacle : Spawnable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            Menu.Load();

            Destroy(gameObject);
        }
    }
}
