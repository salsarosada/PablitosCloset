using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Estilos
{
    public interface IEstilo
    {

        public string Texture();
    }

    public class Rococo : IEstilo
    {
        public string Texture()
        {
            return "_Rococo";
        }
    }

    public class Nevado : IEstilo
    {
        public string Texture()
        {
            return "_Nevado";
        }
    }

    public class Fifa : IEstilo
    {
        public string Texture()
        {
            return "_Fifa";
        }
    }
}
