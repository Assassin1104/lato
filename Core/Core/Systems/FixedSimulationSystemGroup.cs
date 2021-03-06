using Unity.Entities;

namespace Latios.Systems
{
    [DisableAutoCreation]
    public class FixedSimulationSystemGroup : ComponentSystemGroup
    {
        protected override void OnUpdate()
        {
            LatiosWorld lw = World as LatiosWorld;
            if (!lw.paused)
            {
                foreach (var sys in Systems)
                {
                    SuperSystem.UpdateManagedSystem(sys);
                }
            }
        }
    }
}

