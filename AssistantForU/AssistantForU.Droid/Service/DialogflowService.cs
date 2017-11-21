using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ApiAiSDK;
using ApiAiSDK.Model;
using ApiAi.Android;
using ApiAi.Common;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace AssistantForU.Droid.Service
{
    public class DialogflowService
    {
        private AIConfiguration _config;
        private AIService _aiService;
        private Activity _mainActivity;

        public DialogflowService(Activity mainActivity)
        {
            _config = new AIConfiguration("<Token>", SupportedLanguage.English);
            _aiService = AIService.CreateService(Forms.Context, _config, RecognitionEngine.System);

            _mainActivity = mainActivity;

            _aiService.OnError += DialogflowService_OnError;
            _aiService.OnResult += DialogflowService_OnResult;
        }


        public void StartDialogflowService()
        {
            _aiService.StartListening();
        }

        public void StopDialogflowService()
        {
            _aiService.StopListening();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void DialogflowService_OnError(AIServiceException obj)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void DialogflowService_OnResult(AIResponse obj)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}