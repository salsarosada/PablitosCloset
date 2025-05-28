using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prendas;
using Estilos;

namespace Factories
{
    public abstract class PrendaFactory
    {
        protected abstract Prenda CreateBasePrenda();
        protected abstract IEstilo CreateEstilo();

        public Prenda CreatePrenda()
        {
            Prenda p = CreateBasePrenda();
            p.Estilo = CreateEstilo();
            p.GameObject = new GameObject();
            SpriteRenderer spriteRenderer = p.GameObject.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>(p.Name + p.Estilo.Texture());
            p.GameObject.transform.position = p.Position;
            p.GameObject.transform.localScale = p.Scale;
            return p;
        }

    }

    public class GorroRococoFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Gorro();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Rococo();
        }
    }

    public class GorroNevadoFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Gorro();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Nevado();
        }
    }

    public class GorroFifaFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Gorro();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Fifa();
        }
    }

    public class CamisetaRococoFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Camiseta();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Rococo();
        }
    }

    public class CamisetaNevadoFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Camiseta();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Nevado();
        }
    }

    public class CamisetaFifaFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Camiseta();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Fifa();
        }
    }

    public class PantalonRococoFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Pantalon();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Rococo();
        }
    }

    public class PantalonNevadoFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Pantalon();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Nevado();
        }
    }

    public class PantalonFifaFactory : PrendaFactory
    {
        protected override Prenda CreateBasePrenda()
        {
            return new Pantalon();
        }

        protected override IEstilo CreateEstilo()
        {
            return new Fifa();
        }
    }
}
