﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DashboardLibrary.ActionsPage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NavigateNewPage recording.
    /// </summary>
    [TestModule("bf9826af-e4ad-4e2c-89d2-83f5be10c12a", ModuleType.Recording, 1)]
    public partial class NavigateNewPage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DashboardLibrary.DashboardLibraryRepository repository.
        /// </summary>
        public static global::DashboardLibrary.DashboardLibraryRepository repo = global::DashboardLibrary.DashboardLibraryRepository.Instance;

        static NavigateNewPage instance = new NavigateNewPage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NavigateNewPage()
        {
            varName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NavigateNewPage Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varName.
        /// </summary>
        [TestVariable("b1b90102-b72f-4f41-a881-59557ee6a285")]
        public string varName
        {
            get { return repo.varName; }
            set { repo.varName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestArchitect.TestPageTab' at Center.", repo.TestArchitect.TestPageTabInfo, new RecordItemIndex(0));
            repo.TestArchitect.TestPageTab.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}