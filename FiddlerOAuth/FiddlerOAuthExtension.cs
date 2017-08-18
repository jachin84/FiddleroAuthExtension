using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;
using FiddlerOAuth.Properties;

// Require 4.6 of Fiddler
[assembly: Fiddler.RequiredVersion("4.6.0.0")]

namespace FiddlerOAuth
{
   public class FiddlerOAuthExtension : IAutoTamper3
    {

        private bool _oAuthExtensionEnabled;

        private TabPage _oAuthExtensionTabPage;
        private FiddlerOAuthUI _fiddlerOAuthUI;


        public FiddlerOAuthExtension()
        {
            _oAuthExtensionEnabled = FiddlerApplication.Prefs.GetBoolPref("extensions.oauthextension.enabled", false);
            FiddlerApplication.UI.UNSTABLE_OfferTab("&oAuth Extension", (s, o) => CreateOrShowTab());
        }

        private void CreateOrShowTab()
        {
            if (_oAuthExtensionTabPage == null && _fiddlerOAuthUI == null)
            {
                _oAuthExtensionTabPage = new TabPage("oAuth");
                FiddlerApplication.UI.tabsViews.ImageList.Images.Add(Resources.oauth);
                _oAuthExtensionTabPage.ImageIndex = (int)FiddlerApplication.UI.tabsViews.ImageList.Images.Count - 1;

                _fiddlerOAuthUI = new FiddlerOAuthUI(_oAuthExtensionEnabled);
                _fiddlerOAuthUI.ExtensionEnabled += (o, e) =>
                {
                    
                    _oAuthExtensionEnabled = true;
                    FiddlerApplication.Prefs.SetBoolPref("extensions.oauthextension.enabled", _oAuthExtensionEnabled);
                };

                _fiddlerOAuthUI.ExtensionDisabled += (o, e) =>
                {
                    _oAuthExtensionEnabled = false;
                    FiddlerApplication.Prefs.SetBoolPref("extensions.oauthextension.enabled", _oAuthExtensionEnabled);
                };
                _oAuthExtensionTabPage.Controls.Add(_fiddlerOAuthUI);
                _fiddlerOAuthUI.Dock = DockStyle.Fill;
                FiddlerApplication.UI.tabsViews.TabPages.Add(_oAuthExtensionTabPage);
            }

            // Show the tab
            FiddlerApplication.UI.tabsViews.SelectTab(_oAuthExtensionTabPage);
        }

        #region Implementation of IFiddlerExtension

        public void OnLoad()
        {
            /* NB: OnLoad might not get called until ~after~ one of
               the AutoTamper methods was called, because sessions are 
               processed while Fiddler is loading. */

            if (_oAuthExtensionEnabled)
            {
                CreateOrShowTab();
            }
            
            FiddlerApplication.Log.LogString("FiddlerOAuthExention loaded");
        }

        public void OnBeforeUnload() {/*noop*/}

        #endregion


        #region Implementation of IAutoTamper

        public void AutoTamperRequestBefore(Session oSession)
        {
            //throw new NotImplementedException();
        }

        public void AutoTamperRequestAfter(Session oSession)
        {
            //throw new NotImplementedException();
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            //throw new NotImplementedException();
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
            //throw new NotImplementedException();
        }

        public void OnBeforeReturningError(Session oSession)
        {
            //throw new NotImplementedException();
        }

        public void OnPeekAtResponseHeaders(Session oSession)
        {
            //throw new NotImplementedException();
        }

        public void OnPeekAtRequestHeaders(Session oSession)
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
