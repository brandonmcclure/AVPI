﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAVPI
{
    public partial class frmSettings : Form
    {
        VI_Settings vi_settings;
        public frmSettings(VI_Settings vi_settings)
        {
            InitializeComponent();
            MaximizeBox = false;
            this.vi_settings = vi_settings;

            List<String> localizations = new List<String>();
            foreach (RecognizerInfo ri in SpeechRecognitionEngine.InstalledRecognizers())
            {
                localizations.Add(ri.Culture.Name);
            }
            cbSettingsLanguage.DataSource = localizations;

            List<String> voices = new List<string>();
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                voices.Add(voice.VoiceInfo.Name);
            }
            cbSettingsSynthesizer.DataSource = voices;

            List<string> audio_devices = new List<string>();
            //TODO: actually enumerate audio devices.
            audio_devices.Add("Default Directsound device");

            cbSettingsRecordingDevice.DataSource = audio_devices;
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            vi_settings.recognizer_info = new CultureInfo(cbSettingsLanguage.SelectedItem.ToString());
            vi_settings.voice_info = cbSettingsSynthesizer.SelectedItem.ToString();
            this.Close();
        }
    }
}
