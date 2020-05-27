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

namespace DashboardLibrary.ActionsDataProfile
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenDisplayField recording.
    /// </summary>
    [TestModule("07abafb4-cd62-41b9-8491-34b9536541ea", ModuleType.Recording, 1)]
    public partial class OpenDisplayField : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DashboardLibrary.DashboardLibraryRepository repository.
        /// </summary>
        public static global::DashboardLibrary.DashboardLibraryRepository repo = global::DashboardLibrary.DashboardLibraryRepository.Instance;

        static OpenDisplayField instance = new OpenDisplayField();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenDisplayField()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenDisplayField Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestArchitect.ActionsDataProfile.DislayField.DisplayFields' at Center.", repo.TestArchitect.ActionsDataProfile.DislayField.DisplayFieldsInfo, new RecordItemIndex(0));
            repo.TestArchitect.ActionsDataProfile.DislayField.DisplayFields.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TestArchitect.ActionsDataProfile.DislayField.ChkName'.", repo.TestArchitect.ActionsDataProfile.DislayField.ChkNameInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TestArchitect.ActionsDataProfile.DislayField.ChkNameInfo, "Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TestArchitect.ActionsDataProfile.DislayField.ChkSource'.", repo.TestArchitect.ActionsDataProfile.DislayField.ChkSourceInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TestArchitect.ActionsDataProfile.DislayField.ChkSourceInfo, "Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TestArchitect.ActionsDataProfile.DislayField.ChkStatus'.", repo.TestArchitect.ActionsDataProfile.DislayField.ChkStatusInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TestArchitect.ActionsDataProfile.DislayField.ChkStatusInfo, "Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TestArchitect.ActionsDataProfile.DislayField.ChkNotes'.", repo.TestArchitect.ActionsDataProfile.DislayField.ChkNotesInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TestArchitect.ActionsDataProfile.DislayField.ChkNotesInfo, "Checked", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}