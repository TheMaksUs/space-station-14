using System;
using Robust.Server.Interfaces.GameObjects;
using Robust.Shared.GameObjects;
using Robust.Shared.Interfaces.GameObjects;
using Robust.Shared.IoC;
using Robust.Shared.Maths;

namespace Content.Server.GameObjects.Components.Items.Storage.Fill
{
    internal sealed class ToolLockerFillComponent : Component, IMapInit
    {
        public override string Name => "ToolLockerFill";

#pragma warning disable 649
        [Dependency] private readonly IEntityManager _entityManager;
#pragma warning restore 649

        void IMapInit.MapInit()
        {
            var storage = Owner.GetComponent<IStorageComponent>();
            var random = new Random(DateTime.Now.GetHashCode() ^ Owner.Uid.GetHashCode());

            void Spawn(string prototype)
            {
                storage.Insert(_entityManager.SpawnEntity(prototype));
            }

            if (random.Prob(0.4f))
            {
                Spawn("HazardVestClothing");
            }

            if (random.Prob(0.7f))
            {
                Spawn("FlashlightLantern");
            }

            if (random.Prob(0.7f))
            {
                Spawn("Screwdriver");
            }

            if (random.Prob(0.7f))
            {
                Spawn("Wrench");
            }

            if (random.Prob(0.7f))
            {
                Spawn("Welder");
            }

            if (random.Prob(0.7f))
            {
                Spawn("Crowbar");
            }

            if (random.Prob(0.7f))
            {
                Spawn("Wirecutter");
            }

            if (random.Prob(0.2f))
            {
                Spawn("Multitool");
            }

            if (random.Prob(0.2f))
            {
                Spawn("UtilityBeltClothing");
            }

            if (random.Prob(0.05f))
            {
                Spawn("YellowGloves");
            }

            if (random.Prob(0.4f))
            {
                Spawn("HelmetEngineering");
            }

            for (var i = 0; i < 3; i++)
            {
                if (random.Prob(0.3f))
                {
                    Spawn("CableStack");
                }
            }
        }
    }
}
