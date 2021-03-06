﻿using pdxpartyparrot.Core.Camera;
using pdxpartyparrot.Core.Network;
using pdxpartyparrot.Game.State;

namespace pdxpartyparrot.ssjAug2018.GameState
{
    public sealed class Game : pdxpartyparrot.Game.State.GameState
    {
        public override void OnEnter()
        {
            base.OnEnter();

            InitializeManagers();

            NetworkManager.Instance.StartLANHost();
        }

        public override void OnExit()
        {
            NetworkManager.Instance.Stop();

            base.OnExit();
        }

        private void InitializeManagers()
        {
            ViewerManager.Instance.FreeViewers();
            ViewerManager.Instance.AllocateViewers(1);
        }
    }
}
