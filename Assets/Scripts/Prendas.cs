using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UIElements;
using Estilos;

namespace Prendas
{
    public abstract class Prenda
    {
        protected Sprite _sprite;
        protected string _name;
        protected GameObject _gameObject;
        protected Vector3 _position, _scale;
        protected IEstilo _estilo;

        public Prenda(Vector3 position, Vector3 scale, string name)
        {
            _name = name;
            _position = position;
            _scale = scale;
        }

        public IEstilo Estilo
        {
            get { return _estilo; }
            set { _estilo = value; }
        }

        public Sprite Sprite { set { _sprite = value; } }

        public GameObject GameObject { get { return _gameObject; } set { _gameObject = value; } }

        public string Name { get { return _name; } }

        public Vector3 Position
        {
            get { return _position; }

        }

        public Vector3 Scale
        {
            get { return _scale; }

        }

    }
    public class Gorro : Prenda
    {
        public Gorro () : base (new Vector3(3, 3.1f, 0), new Vector3(3.6f, 3.6f, 3.6f), "Gorro")
        {
            
        }

    }

    public class Camiseta : Prenda
    {
        public Camiseta() : base(new Vector3(3, 0.85f, 0), new Vector3(8.5f, 8.5f, 8.5f), "Camiseta")
        {

        }
    }

    public class Pantalon : Prenda
    {
        public Pantalon () : base(new Vector3(3, -1.75f, 0), new Vector3(10.15f, 10.15f, 10.15f), "Pantalon")
        {

        }
    }
}
