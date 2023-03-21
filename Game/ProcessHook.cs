using System;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Sonic3Din2D_Helper
{
    /// <summary>
    /// Custom class with the ability to automatically hook to a target process using Tasks
    /// </summary>
    public class ProcessHook
    {
        // Internal stuff
        private readonly CancellationTokenSource CancelToken = new CancellationTokenSource();

        /// <summary>
        /// Game process
        /// </summary>
        public Process Game { get; protected set; }
        public bool IsGameHooked => Game != null && !Game.HasExited;


        /// <summary>
        /// Reports the current status for the init function. The autosplitter will check if
        /// it's set to GameInitStatus.Completed before performing any actual splitting logic.
        /// </summary>
        public GameInitStatus InitStatus { get; set; } = GameInitStatus.NotStarted;

        public ProcessHook()
        {
            Task.Run(TryConnect, CancelToken.Token);
        }

        private async Task TryConnect()
        {
            while (!CancelToken.IsCancellationRequested)
            {
                try
                {
                    Game = Process.GetProcesses().Where(p => p.ProcessName.StartsWith("Sonic3D2d")).OrderByDescending(p => p.StartTime).FirstOrDefault(p => !p.HasExited);
                } catch { }

                if (Game != null)
                {
                    Game.Exited += CallBackTryConnect;
                    return;
                }
                await Task.Delay(2000, CancelToken.Token);
            }
        }

        private void CallBackTryConnect(object sender, EventArgs e)
        {
            Game.Exited -= CallBackTryConnect;
            InitStatus = GameInitStatus.NotStarted;
            Game?.Dispose();
            Game = null;
            Task.Run(TryConnect, CancelToken.Token);
        }

        public void Dispose()
        {
            CancelToken?.Cancel();
            CancelToken?.Dispose();
            Game?.Dispose();
        }
    }

    public enum GameInitStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
}