using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShooter.Scene.Gameplay.Enemy
{
    public interface IEnemyModel : IBaseModel
    {

    }

    public class EnemyModel : BaseModel, IEnemyModel
    {

    }
}