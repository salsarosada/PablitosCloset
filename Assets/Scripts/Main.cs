using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factories;
using Prendas;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Main : MonoBehaviour
{
    [SerializeField] Button[] _buttons;
    Prenda _gorro;
    Prenda _camiseta;
    Prenda _pantalon;
    bool _hasGorro = false;
    bool _hasPantalon = false;
    bool _hasCamiseta = false;
    private void Start()
    {
        foreach (Button button in _buttons)
        {
            button.onClick.AddListener(() =>
            {
                switch (button.gameObject.name)
                {
                    case "GorroNevado": 
                        if (_hasGorro)
                        {
                            Destroy(_gorro.GameObject);
                        }
                        _hasGorro = true;
                        _gorro = new GorroNevadoFactory().CreatePrenda(); break;
                    case "GorroFifa":
                        if (_hasGorro)
                        {
                            Destroy(_gorro.GameObject);
                        }
                        _hasGorro = true; _gorro = new GorroFifaFactory().CreatePrenda(); break;
                    case "GorroRococo":
                        if (_hasGorro)
                        {
                            Destroy(_gorro.GameObject);
                        }
                        _hasGorro = true; _gorro = new GorroRococoFactory().CreatePrenda(); break;
                    case "CamisetaNevado":
                        if (_hasCamiseta)
                        {
                            Destroy(_camiseta.GameObject);
                        }
                        _hasCamiseta = true; _camiseta = new CamisetaNevadoFactory().CreatePrenda(); break;
                    case "CamisetaFifa":
                        if (_hasCamiseta)
                        {
                            Destroy(_camiseta.GameObject);
                        }
                        _hasCamiseta = true; _camiseta = new CamisetaFifaFactory().CreatePrenda(); break;
                    case "CamisetaRococo":
                        if (_hasCamiseta)
                        {
                            Destroy(_camiseta.GameObject);
                        }
                        _hasCamiseta = true; _camiseta = new CamisetaRococoFactory().CreatePrenda(); break;
                    case "PantalonRococo":
                        if (_hasPantalon)
                        {
                            Destroy(_pantalon.GameObject);
                        }
                        _hasPantalon = true; _pantalon = new PantalonRococoFactory().CreatePrenda(); break;
                    case "PantalonNevado":
                        if (_hasPantalon)
                        {
                            Destroy(_pantalon.GameObject);
                        }
                        _hasPantalon = true; _pantalon = new PantalonNevadoFactory().CreatePrenda(); break;
                    case "PantalonFifa":
                        if (_hasPantalon)
                        {
                            Destroy(_pantalon.GameObject);
                        }
                        _hasPantalon = true; _pantalon = new PantalonFifaFactory().CreatePrenda(); break;
                }

            });
        }
    }
    
}
