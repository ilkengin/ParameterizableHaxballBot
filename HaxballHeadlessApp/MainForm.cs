using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Nustache.Core;

namespace HaxballHeadlessApp
{
    public partial class MainForm : Form
    {
        public ChromiumWebBrowser Browser;

        //Default Values
        private readonly int DefaultMaximumPlayerCount = 12;
        private readonly int DefaultMatchTimeLmit = 3;
        private readonly int DefaultMatchScoreLimit = 3;
        private readonly string DefaultPassword = "";
        private readonly string DefaultBotName = "IlkBot";
        private readonly bool DefaultPublic = true;
        private readonly bool DefaultWinnerStays = true;

        private readonly string HeadlessApiUrl = "https://www.haxball.com/headless";
        public MainForm()
        {
            InitializeComponent();
            BindDefaultValues();
            SetGeoLocEnability();
            SetVisibilityForAllControls(false);

            RegisterMustacheHelpers();
        }

        private void RegisterMustacheHelpers()
        {
            if (!Helpers.Contains("BoolToString"))
            {
                Helpers.Register("BoolToString", (context, arguments, options, fn, inverse) =>
                {
                    if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is bool)
                    {
                        bool mBool = (bool)arguments[0];
                        context.Write(mBool.ToString().ToLower());
                    }
                });
            }
        }

        public void InitBrowser()
        {
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(new CefSettings());
            }
            _isFirstFrame = true;
            Browser = new ChromiumWebBrowser(HeadlessApiUrl);

            Controls.Add(Browser);
            Browser.Dock = DockStyle.None;
            Browser.FrameLoadEnd += CefBrowser_FrameLoadEnd;
            Browser.IsBrowserInitializedChanged += CefBrowser_BrowserInitializedChanged;
            Browser.BringToFront();
        }

        private void BindDefaultValues()
        {
            textBox_RoomName.Text = DefaultBotName + (DefaultWinnerStays ? " | WinnerStays" : "");
            textBox_BotName.Text = DefaultBotName;
            textBox_MaxPlayers.Text = DefaultMaximumPlayerCount.ToString();
            textBox_ScoreLimit.Text = DefaultMatchScoreLimit.ToString();
            textBox_TimeLimit.Text = DefaultMatchTimeLmit.ToString();
            textBox_roomPassword.Text = DefaultPassword;

            checkBox_Public.Checked = DefaultPublic;
            checkBox_WinnerStays.Checked = DefaultWinnerStays;
        }

        private void SetVisibilityForAllControls(bool isBotActive)
        {
            textBox_RoomName.Enabled = !isBotActive;
            textBox_BotName.Enabled = !isBotActive;
            textBox_MaxPlayers.Enabled = !isBotActive;
            textBox_ScoreLimit.Enabled = !isBotActive;
            textBox_TimeLimit.Enabled = !isBotActive;
            textBox_roomPassword.Enabled = !isBotActive;

            var overrideGeoLoc = checkBox_OverrideGeoLoc.Checked;
            textBox_GeoCode.Enabled = !isBotActive && overrideGeoLoc;
            textBox_GeoLat.Enabled = !isBotActive && overrideGeoLoc;
            textBox_GeoLong.Enabled = !isBotActive && overrideGeoLoc;
            label_GeoCode.Enabled = !isBotActive && overrideGeoLoc;
            label_GeoLat.Enabled = !isBotActive && overrideGeoLoc;
            label_GeoLong.Enabled = !isBotActive && overrideGeoLoc;

            label1.Enabled = !isBotActive;
            label2.Enabled = !isBotActive;
            label3.Enabled = !isBotActive;
            label4.Enabled = !isBotActive;
            label5.Enabled = !isBotActive;
            label6.Enabled = !isBotActive;
            label7.Enabled = !isBotActive;


            checkBox_Public.Enabled = !isBotActive;
            checkBox_WinnerStays.Enabled = !isBotActive;
            checkBox_OverrideGeoLoc.Enabled = !isBotActive;

            button_CreateRoom.Enabled = !isBotActive;
            button_Stop.Enabled = isBotActive;
        }

        private void CheckRoomUrlAsync()
        {
            Task.Run(() =>
            {
                while (!BrowserContainsRoomUrl())
                {
                    Thread.Sleep(1000);
                }

                RoomCreated();
            });
        }

        private bool BrowserContainsRoomUrl()
        {
            var result = FetchRoomUrlFromBrowser();

            return !string.IsNullOrEmpty(result);
        }

        private void RoomCreated()
        {
            Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                Browser.Dock = DockStyle.None;

                //prepare room url link
                var roomLinkText = FetchRoomUrlFromBrowser().Replace("\n", "".Trim());
                var linkStartIndex = roomLinkText.IndexOf("http", StringComparison.Ordinal);
                roomUrlLink.Text = roomLinkText;
                var url = roomLinkText.Substring(linkStartIndex, roomLinkText.Length - linkStartIndex);
                roomUrlLink.Links.Add(linkStartIndex, roomLinkText.Length - linkStartIndex, url);
            });
        }

        private string FetchRoomUrlFromBrowser()
        {
            string script = @"var iframe = document.querySelector('iframe');
                              var iframeDocument = iframe.contentDocument || iframe.contentWindow.document;
                              iframeDocument.querySelector('#roomlink').innerText;";
            string result = null;
            bool resultCame = false;
            Browser.EvaluateScriptAsync(script).ContinueWith(x =>
            {
                result = (string) x.Result.Result;
                resultCame = true;
            });

            while (!resultCame)
            {
            }

            return result;
        }

        private void CefBrowser_BrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            if (Browser.IsBrowserInitialized)
            {
                CheckRoomUrlAsync();
            }
        }

        private bool _isFirstFrame = true;

        private void CefBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (!_isFirstFrame)
            {
                return;
            }

            _isFirstFrame = false;
            Thread.Sleep(2000);
            var jsContent = File.ReadAllText(@"ParameterizableBotControllerTemplate.js");
            var config = CreateBotConfig();

            jsContent = Render.StringToString(jsContent, config);

            Browser.ExecuteScriptAsync(jsContent);
            Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                Browser.Dock = DockStyle.Fill;
            });
        }

        private void CheckBox_WinnerStays_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_WinnerStays.Checked)
            {
                if (!textBox_RoomName.Text.Contains("WinnerStays"))
                {
                    textBox_RoomName.Text += @" | WinnerStays";
                }
            }
            else
            {
                textBox_RoomName.Text = textBox_RoomName.Text.Replace(" | WinnerStays", "");
            }
        }

        private void RoomUrlLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roomUrlLink.Links[roomUrlLink.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (e.Link.LinkData is string target && target.StartsWith("http"))
            {
                System.Diagnostics.Process.Start(target);
            }
        }

        private void Button_CreateRoom_Click(object sender, EventArgs e)
        {
            var configErrorMessage = CheckConfigValues();
            if (!string.IsNullOrEmpty(configErrorMessage))
            {
                MessageBox.Show(configErrorMessage);
                return;
            }
            SetVisibilityForAllControls(true);
            InitBrowser();
        }

        private string CheckConfigValues()
        {
            if (!int.TryParse(textBox_MaxPlayers.Text, out var maxPlayers) || maxPlayers < 1)
            {
                return "Please check max player number!";
            }

            bool overrideGeoLoc = checkBox_OverrideGeoLoc.Checked;
            if (overrideGeoLoc && !float.TryParse(textBox_GeoLat.Text, out _))
            {
                return "Please check geo lat!";
            }

            if (overrideGeoLoc && !float.TryParse(textBox_GeoLong.Text, out _))
            {
                return "Please check geo long!";
            }

            if (string.IsNullOrEmpty(textBox_RoomName.Text))
            {
                return "Room name cannot be empty!";
            }

            if (string.IsNullOrEmpty(textBox_BotName.Text))
            {
                return "Bot name cannot be empty!";
            }
            return null;
        }
        private BotConfig CreateBotConfig()
        {
            if (!int.TryParse(textBox_MaxPlayers.Text,out var maxPlayers))
            {
                MessageBox.Show("Please check max player number!");
                return null;
            }

            var overrideGeoLoc = checkBox_OverrideGeoLoc.Checked;
            var geoLat = 0f;
            if (overrideGeoLoc && !float.TryParse(textBox_GeoLat.Text, out geoLat))
            {
                MessageBox.Show("Please check geo lat!");
                return null;
            }

            var geoLong = 0f;
            if (!overrideGeoLoc || float.TryParse(textBox_GeoLong.Text, out geoLong))
            {
                return new BotConfig()
                {
                    Public = checkBox_Public.Checked,
                    WinnerStays = checkBox_WinnerStays.Checked,
                    RoomName = textBox_RoomName.Text,
                    PlayerName = textBox_BotName.Text,
                    Password = textBox_roomPassword.Text,
                    MaxPlayers = maxPlayers,
                    OverrideGeoLoc = checkBox_OverrideGeoLoc.Checked,
                    GeoCode = textBox_GeoCode.Text,
                    GeoLat = geoLat,
                    GeoLong = geoLong
                };
            }
            MessageBox.Show("Please check geo long!");
            return null;
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            Browser.Load("about:blank");
            SetVisibilityForAllControls(false);
            roomUrlLink.Text = "";
            roomUrlLink.Links.Clear();
        }

        private void CheckBox_OverrideGeoLoc_CheckedChanged(object sender, EventArgs e)
        {
            SetGeoLocEnability();
        }

        private void SetGeoLocEnability()
        {
            var overrideGeLoc = checkBox_OverrideGeoLoc.Checked;
            textBox_GeoCode.Enabled = overrideGeLoc;
            textBox_GeoLat.Enabled = overrideGeLoc;
            textBox_GeoLong.Enabled = overrideGeLoc;

            label_GeoCode.Enabled = overrideGeLoc;
            label_GeoLat.Enabled = overrideGeLoc;
            label_GeoLong.Enabled = overrideGeLoc;
        }
    }
}