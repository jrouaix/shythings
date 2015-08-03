using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAudio.Wave;
using System.Threading;

namespace ShyThings.Tests
{
    [TestClass]
    public class NAudioTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int waveInDevices = WaveIn.DeviceCount;

            var ts = new ThreadStart(() =>
            {
                var waveIn = new WaveInEvent();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += delegate (object sender, WaveInEventArgs e)
                {

                };
                waveIn.WaveFormat = new WaveFormat(44100, 1);
                waveIn.StartRecording();
                waveIn.StopRecording();
            });

            var t = new Thread(ts) { IsBackground = true };
            t.Start();
            Thread.Sleep(TimeSpan.FromSeconds(120));


        }


    }
}
