using ExternalTestingUtility.Cheats;
using Refract.UI.Core.Interfaces;
using Refract.UI.Core.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExternalTestingUtility.Cheats.BlackOps3.ClassSetType;
using static ExternalTestingUtility.Cheats.BlackOps3.loadoutClass_t;

namespace ExternalTestingUtility
{
    public partial class MainForm : Form, IThemeableControl
    {
        public MainForm()
        {
            // Sets up stealth calls for native funcs to try to avoid api hooking
            NativeStealth.SetStealthMode(NativeStealthType.ManualInvoke);

            InitializeComponent();
            UIThemeManager.OnThemeChanged(this, OnThemeChanged_Implementation);
            this.SetThemeAware();
            MaximizeBox = true;
            MinimizeBox = true;
        }

        public IEnumerable<Control> GetThemedControls()
        {
            yield return InnerForm;
            yield return button1;
            yield return button2;
        }

        private void OnThemeChanged_Implementation(UIThemeInfo currentTheme)
        {
        }


        private void InnerForm_ControlContents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InnerForm_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            new Task(() => { BlackOps3.Cbuf_AddText("lobbyLaunchGame"); }).Start();
            BlackOps3.Dvar_SetFromStringByName("party_minPlayers", "1");
            BlackOps3.Dvar_SetFromStringByName("lobbyDedicatedSearchSkip", "1");
            BlackOps3.Dvar_SetFromStringByName("lobbySearchTeamSize", "1");
            BlackOps3.Dvar_SetFromStringByName("lobbySearchSkip", "1");
            BlackOps3.Dvar_SetFromStringByName("lobbyMergeDedicatedEnabled", "0");
            BlackOps3.Dvar_SetFromStringByName("lobbyMergeEnabled", "0");
            new Task(() => { BlackOps3.Cbuf_AddText("lobbyLaunchGame"); }).Start();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
         
         BlackOps3.Dvar_SetFromStringByName("party_minPlayers", "1");
         BlackOps3.Dvar_SetFromStringByName("lobbyDedicatedSearchSkip", "1");
         BlackOps3.Dvar_SetFromStringByName("lobbySearchTeamSize", "1");
         BlackOps3.Dvar_SetFromStringByName("lobbySearchSkip", "1");
         BlackOps3.Dvar_SetFromStringByName("lobbyMergeDedicatedEnabled", "0");
         BlackOps3.Dvar_SetFromStringByName("lobbyMergeEnabled", "0");
        }
    }
}
