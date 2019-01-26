using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVolumeCntrlr_v0._4
{
    // sample program
        static class Program
        {
            [DllImport("user32.dll")]
            public static extern IntPtr FindWindow(string strClassName, string strWindowName);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

                static void Main()
                {
                //var hWnd = FindWindow("SpotifyMainWindow", "Spotify");
                //if (hWnd == IntPtr.Zero)
                //    return;

                //uint pID1;
                //GetWindowThreadProcessId(hWnd, out pID1);
                //if (pID1 == 0)
                //    return;
                //int pID2 = Convert.ToInt32(pID1);
                int pID2 = 1084;
                //float? curVol = VolumeHelper.GetApplicationVolume(pID2);
                //Console.WriteLine(curVol);
                VolumeHelper.SetApplicationVolume(pID2, 100f);
                //curVol = VolumeHelper.GetApplicationVolume(pID2);
                //Console.WriteLine(curVol);

                //var curAudio = VolumeHelper.GetCurrentAudioSessions();
                //    Console.WriteLine(curAudio[0]);
                //    Console.ReadLine();
         
                }
        }
   
}
