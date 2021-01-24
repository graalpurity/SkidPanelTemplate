using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace Skid_Panel_Template_V2.Handler
{
    public static class DiscordH
    {
        public static DiscordRpcClient client;

        public static class Discord
        {
            public static void DiscordID()
            {
                client = new DiscordRpcClient("801140733075521536");
                client.Initialize();
            }

            public static void Start()
            {
                if (!client.IsInitialized)
                {
                    client.Initialize();
                }
                client.SetPresence(new RichPresence()
                {
                    Details = $"Home panel | Topmost: {MainFrm.topMost}",
                    State = $"Idle",
                    Assets = new Assets()
                    {
                        LargeImageKey = "c_",
                        LargeImageText = "Skid Panel Template",
                    }
                });
            }

            //these if statements checking if you're booting someone, you could use just a else statement for the last one but im doing if false just incase 
            public static void Homepage()
            {
                if (MainFrm.Frying == false)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = $"Home panel | Topmost: {MainFrm.topMost}",
                        State = $"Idle",
                        Assets = new Assets()
                        {
                            LargeImageKey = "c_",
                            LargeImageText = "Skid Panel Template",
                        }
                    });
                }
                if (MainFrm.Frying == true)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = $"Home panel | Topmost: {MainFrm.topMost}",
                        State = $"Frying skids",
                        Assets = new Assets()
                        {
                            LargeImageKey = "c_",
                            LargeImageText = "Skid Panel Template",
                        }
                    });
                }
            }

            public static void Booter()
            {
                if (MainFrm.Frying == false)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = $"Boot panel | Topmost: {MainFrm.topMost}",
                        State = $"Idle",
                        Assets = new Assets()
                        {
                            LargeImageKey = "c_",
                            LargeImageText = "Skid Panel Template",
                        }
                    });

                    if (MainFrm.Frying == true)
                    {
                        client.SetPresence(new RichPresence()
                        {
                            Details = $"Boot panel | Topmost: {MainFrm.topMost}",
                            State = $"Frying skids",
                            Assets = new Assets()
                            {
                                LargeImageKey = "c_",
                                LargeImageText = "Skid Panel Template",
                            }
                        });
                    }
                }
            }

            public static void Frying()
            {
                //this one does not need the if statement
                //var Booter = new Skid_Panel_Template_V2.Frms.Controls.Booter(); //you could do like "frying {Booter.ipTextBox.Text}"
                client.SetPresence(new RichPresence()
                {
                    Details = $"Boot panel | Topmost: {MainFrm.topMost}",
                    State = $"Frying skids",
                    Assets = new Assets()
                    {
                        LargeImageKey = "c_",
                        LargeImageText = "Skid Panel Template",
                    }
                });
            }

            public static void Settings()
            {
                if (MainFrm.Frying == false)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = $"Settings panel | Topmost: {MainFrm.topMost}",
                        State = $"Idle",
                        Assets = new Assets()
                        {
                            LargeImageKey = "c_",
                            LargeImageText = "Skid Panel Template",
                        }
                    });
                    if (MainFrm.Frying == true)
                    {
                        client.SetPresence(new RichPresence()
                        {
                            Details = $"Settings panel | Topmost: {MainFrm.topMost}",
                            State = $"Frying skids",
                            Assets = new Assets()
                            {
                                LargeImageKey = "c_",
                                LargeImageText = "Skid Panel Template",
                            }
                        });
                    }
                }
            }
        }
    }
}
