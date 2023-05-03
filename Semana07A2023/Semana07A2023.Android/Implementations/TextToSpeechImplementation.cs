using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Semana07A2023.Interfaces;
using System;
using Android.Speech.Tts;

namespace Semana07A2023.Droid.Implementations
{
    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        public void OnInit([GeneratedEnum] OperationResult status)
        {
            throw new NotImplementedException();
        }

        public void Speak(string text)
        {
            throw new NotImplementedException();
        }
    }
}