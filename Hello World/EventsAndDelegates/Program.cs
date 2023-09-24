using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Audio
    {
        public string Title{ get; set; }
    }
    public class AudioEncoder
    {
        public delegate void AudioEncoderEventHandler(object source, EventArgs args);

        public event AudioEncoderEventHandler AudioEncoded;

        public void Encode(Audio audio)
        {
            Console.WriteLine("Encoding Audio");

            Thread.Sleep(6000);

            OnAudioEncoded(); git config --global user.email "anujrane7614@gmail.com"



        }

        protected virtual void OnAudioEncoded(object source, EventArgs args) 
        {
        
            AudioEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var audio = new Audio() { Title = "title1"};

            var audioEncoder = new AudioEncoder();

            var phoneService = new PhoneService();

            audioEncoder.AudioEncoded += phoneService.OnAudioEncoded;

            audioEncoder.Encode(audio);
        }
    }

    public class PhoneService
    {
        public void OnAudioEncoded(object source, EventArgs args) 
        {
            Console.WriteLine("Phone Service");
        }
    }
}
