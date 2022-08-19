using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace SpaceShooter.Scene.MainMenu.InputName
{
    public class InputNameView : ObjectView<IInputNameModel>
    {
        [SerializeField] private Button _oKButton;
        [SerializeField] private InputField _input;
        
        public void InitView(UnityAction<string> enterName, UnityAction oK)
        {
            _input.onValueChanged.RemoveAllListeners();
            _input.onValueChanged.AddListener(enterName);

            _oKButton.onClick.RemoveAllListeners();
            _oKButton.onClick.AddListener(oK);
        }

        protected override void InitRenderModel(IInputNameModel model)
        {
            
        }

        protected override void UpdateRenderModel(IInputNameModel model)
        {
            
        }
    }
}
