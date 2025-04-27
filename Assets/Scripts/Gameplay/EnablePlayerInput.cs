using Platformer.Core;
using Platformer.Model;
using System;

namespace Platformer.Gameplay
{
    /// <summary>
    /// This event is fired when user input should be enabled.
    /// </summary>
    public class EnablePlayerInput : Simulation.Event<EnablePlayerInput>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        /// <summary>
        /// Indica si se debe habilitar o deshabilitar la entrada del jugador.
        /// </summary>
        public bool EnableInput { get; set; } = true;

        /// <summary>
        /// Evento opcional que se ejecuta cuando el estado de control cambia.
        /// </summary>
        public event Action<bool> OnInputStateChanged;

        public override void Execute()
        {
            var player = model.player;
            //player.controlEnabled = true;

            if (player != null)
            {
                // Solo cambiar si el estado actual es diferente
                if (player.controlEnabled != EnableInput)
                {
                    player.controlEnabled = EnableInput;
                    OnInputStateChanged?.Invoke(EnableInput);
                }
            }
        }
    }
}
