﻿/**
* Modified by Augmented Startups
* 2019-11-17
* http://www.augmentedstartups.com 
* 
* opyright 2015 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
#pragma warning disable 0649

using UnityEngine;
using IBM.Watson.DeveloperCloud.Services.TextToSpeech.v1;
using IBM.Watson.DeveloperCloud.Logging;
using IBM.Watson.DeveloperCloud.Utilities;
using System.Collections;
using System.Collections.Generic;
using IBM.Watson.DeveloperCloud.Connection;

public class ExampleTextToSpeech : MonoBehaviour
{
    #region PLEASE SET THESE VARIABLES IN THE INSPECTOR
    [Space(10)]
    [Tooltip("The service URL (optional). This defaults to \"https://stream.watsonplatform.net/text-to-speech/api\"")]
    [SerializeField]
    private string _serviceUrl;
    [Header("IAM Authentication")]
    [Tooltip("The IAM apikey.")]
    [SerializeField]
    private string _iamApikey;
    #endregion

    TextToSpeech _service;
    string _testString = "<speak version=\"1.0\"><prosody pitch=\"100Hz\">I am online and ready.</prosody></speak>";  // Test string which you can initialize with any phrase or sentence.


    string _createdCustomizationId;
    CustomVoiceUpdate _customVoiceUpdate;
    string _customizationName = "unity-example-customization";
    string _customizationLanguage = "en-US";
    string _customizationDescription = "A text to speech voice customization created within Unity.";
    string _testWord = "Watson";

    private bool _synthesizeTested = false;
    private bool _getVoicesTested = false;
    private bool _getVoiceTested = false;
    private bool _getPronuciationTested = false;
    private bool _getCustomizationsTested = false;
    private bool _createCustomizationTested = false;
    private bool _deleteCustomizationTested = false;
    private bool _getCustomizationTested = false;
    private bool _updateCustomizationTested = false;
    private bool _getCustomizationWordsTested = false;
    private bool _addCustomizationWordsTested = false;
    private bool _deleteCustomizationWordTested = false;
    private bool _getCustomizationWordTested = false;

    public static int SpeakState = 0;


    void Start()
    {
        LogSystem.InstallDefaultReactors();
        Runnable.Run(CreateService());
    }

    private void Update()
    {
        switch (SpeakState)
        {
            case 1:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">At your service, sir.</prosody></speak>";  // When the corresponding command is spoken, the assistant will respond with this phrase
                Runnable.Run(Examples()); // Execute the TTS engine.
                SpeakState = 0;
                break;
            case 2:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Working on a new project?</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 3:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">With pleasure sir.</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 4:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Sure thing.</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 5:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Done. Sir, the project completion appears to be at 98%. Perhaps some enhancements?.</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 6:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Excellent choice sir.</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 7:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Excellent choice sir.</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 8:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Hello Ritesh, what can I help you with?</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 9:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">Looks great, shall I export to the 3D printer?</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 10:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">You are most welcome!</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;
            case 11:
                _testString = "<speak version=\"1.0\"><prosody pitch=\"110Hz\">It seems like you are looking an Laser pointer, shall I integrate core components into the prototype.</prosody></speak>";
                Runnable.Run(Examples());
                SpeakState = 0;
                break;

            default:

                break;
        }


    }

    private IEnumerator CreateService()
    {
        if (string.IsNullOrEmpty(_iamApikey))
        {
            throw new WatsonException("Please provide IAM ApiKey for the service.");
        }

        //  Create credential and instantiate service
        Credentials credentials = null;

        //  Authenticate using iamApikey
        TokenOptions tokenOptions = new TokenOptions()
        {
            IamApiKey = _iamApikey
        };

        credentials = new Credentials(tokenOptions, _serviceUrl);

        //  Wait for tokendata
        while (!credentials.HasIamTokenData())
            yield return null;

        _service = new TextToSpeech(credentials);

        Runnable.Run(Examples());
    }

    public static IEnumerator I1_AreYouThere()  // Coroutines which sets the state machine. Each one cooresponds to the case statement above.
    {
        Debug.Log("Are you there");
        SpeakState = 1;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I2_Design()
    {
        Debug.Log("design");
        SpeakState = 2;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I3_Open()
    {
        Debug.Log("open");
        SpeakState = 3;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I4_Rotation()
    {
        Debug.Log("rotation");
        SpeakState = 4;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }


    public static IEnumerator I5_Change()
    {
        Debug.Log("change");
        SpeakState = 5;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }


    public static IEnumerator I6_Color()
    {
        Debug.Log("color");
        SpeakState = 6;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I7_red()
    {
        Debug.Log("red");
        SpeakState = 7;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I8_Activate()
    {
        Debug.Log("activate");
        SpeakState = 8;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I9_Ahead()
    {
        Debug.Log("ahead");
        SpeakState = 9;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I10_Thank()
    {
        Debug.Log("thank you");
        SpeakState = 10;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }

    public static IEnumerator I11_Looking()
    {
        Debug.Log("Looking at");
        SpeakState = 11;
        Debug.Log("SpeakState" + SpeakState);
        yield return null;
    }




    private IEnumerator Examples()
    {

        //  Synthesize
        Log.Debug("ExampleTextToSpeech.Examples()", "Attempting synthesize.");
        _service.Voice = VoiceType.en_US_Michael;  // Set your Voice here
        _service.ToSpeech(HandleToSpeechCallback, OnFail, _testString, true);
        while (!_synthesizeTested)
            yield return null;

        //	Get Voices
        Log.Debug("ExampleTextToSpeech.Examples()", "Attempting to get voices.");
        _service.GetVoices(OnGetVoices, OnFail);
        while (!_getVoicesTested)
            yield return null;

        //	Get Voice
        Log.Debug("ExampleTextToSpeech.Examples()", "Attempting to get voice {0}.", VoiceType.en_US_Michael);
        _service.GetVoice(OnGetVoice, OnFail, VoiceType.en_US_Michael);
        while (!_getVoiceTested)
            yield return null;

        //	Get Pronunciation
        Log.Debug("ExampleTextToSpeech.Examples()", "Attempting to get pronunciation of {0}", _testWord);
        _service.GetPronunciation(OnGetPronunciation, OnFail, _testWord, VoiceType.en_US_Michael);
        while (!_getPronuciationTested)
            yield return null;


        //  Update Customization
        Log.Debug("ExampleTextToSpeech.Examples()", "Attempting to update a customization");
        Word[] wordsToUpdateCustomization =
        {
            new Word()   // This code may not be neccesary 
            {
                word = "hello",
                translation = "hullo"
            },
            new Word()
            {
                word = "goodbye",
                translation = "gbye"
            },
            new Word()
            {
                word = "hi",
                translation = "ohioooo"
            }
        };

        _customVoiceUpdate = new CustomVoiceUpdate()
        {
            words = wordsToUpdateCustomization,
            description = "My updated description",
            name = "My updated name"
        };

        Log.Debug("ExampleTextToSpeech.Examples()", "Attempting to add words to a customization");
        Word[] wordArrayToAddToCustomization =
        {
            new Word()
            {
                word = "bananna",
                translation = "arange"
            },
            new Word()
            {
                word = "orange",
                translation = "gbye"
            },
            new Word()
            {
                word = "tomato",
                translation = "tomahto"
            }
        };

        Words wordsToAddToCustomization = new Words()
        {
            words = wordArrayToAddToCustomization
        };

        SpeakState = 0;
        Log.Debug("ExampleTextToSpeech.Examples()", "Text to Speech examples complete.");
    }

    void HandleToSpeechCallback(AudioClip clip, Dictionary<string, object> customData = null)
    {
        PlayClip(clip);
    }

    private void PlayClip(AudioClip clip)
    {
        if (Application.isPlaying && clip != null)
        {
            GameObject audioObject = new GameObject("AudioObject");
            AudioSource source = audioObject.AddComponent<AudioSource>();
            source.spatialBlend = 0.0f;
            source.loop = false;
            source.clip = clip;
            source.Play();

            Destroy(audioObject, clip.length);

            _synthesizeTested = true;
        }
    }

    private void OnGetVoices(Voices voices, Dictionary<string, object> customData = null)
    {
        Log.Debug("ExampleTextToSpeech.OnGetVoices()", "Text to Speech - Get voices response: {0}", customData["json"].ToString());
        _getVoicesTested = true;
    }

    private void OnGetVoice(Voice voice, Dictionary<string, object> customData = null)
    {
        Log.Debug("ExampleTextToSpeech.OnGetVoice()", "Text to Speech - Get voice  response: {0}", customData["json"].ToString());
        _getVoiceTested = true;
    }

    private void OnGetPronunciation(Pronunciation pronunciation, Dictionary<string, object> customData = null)
    {
        Log.Debug("ExampleTextToSpeech.OnGetPronunciation()", "Text to Speech - Get pronunciation response: {0}", customData["json"].ToString());
        _getPronuciationTested = true;
    }


    private void OnFail(RESTConnector.Error error, Dictionary<string, object> customData)
    {
        Log.Error("ExampleTextToSpeech.OnFail()", "Error received: {0}", error.ToString());
    }
}