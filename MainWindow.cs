using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonic3Din2D_Helper
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Task.Run(UUpdate);
        }

        public async void UUpdate()
        {
            Watchers watchers = new Watchers();

            while (true)
            {
                if (watchers.Init())
                    BeginInvoke(() => { label_status.Text = "Connected to the game!"; });
                else
                {
                    BeginInvoke(() => { label_status.Text = "Game not detected!"; });
                    await Task.Delay(16);
                    continue;
                }

                if (chkSetNiceLives.Checked)
                    watchers.SetNiceLives();

                if (chkBlueShield.Checked)
                    watchers.SetShield(1);
                else if (chkFireShield.Checked)
                    watchers.SetShield(2);
                else if (chkLightningShield.Checked)
                    watchers.SetShield(3);
                else if (chkBubbleShield.Checked)
                    watchers.SetShield(4);
                else if (chkHomingShield.Checked)
                    watchers.SetShield(5);

                if (chkBossCheckPoint.Checked)
                    watchers.BossCheckPoint();
                if (chkDD1JumpCheckPoint.Checked)
                    watchers.DD1CheckPoint();

                if (chkGameComplete.Checked)
                    watchers.SetGameComplete();

                await Task.Delay(16);
            }
        }
    }
}
