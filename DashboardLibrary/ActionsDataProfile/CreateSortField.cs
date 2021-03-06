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
    ///The CreateSortField recording.
    /// </summary>
    [TestModule("1c4d04a3-6b28-4ae4-91fa-7772eeb33959", ModuleType.Recording, 1)]
    public partial class CreateSortField : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DashboardLibrary.DashboardLibraryRepository repository.
        /// </summary>
        public static global::DashboardLibrary.DashboardLibraryRepository repo = global::DashboardLibrary.DashboardLibraryRepository.Instance;

        static CreateSortField instance = new CreateSortField();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateSortField()
        {
            varListOption = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateSortField Instance
        {
            get { return instance; }
        }

#region Variables

        string _varListOption;

        /// <summary>
        /// Gets or sets the value of variable varListOption.
        /// </summary>
        [TestVariable("3b6114b5-78a6-4e22-9134-0c3b7f5b4cf0")]
        public string varListOption
        {
            get { return _varListOption; }
            set { _varListOption = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varItemDataProfile.
        /// </summary>
        [TestVariable("bc8c09dc-2fd8-41ac-ab34-74bc09534c66")]
        public string varItemDataProfile
        {
            get { return repo.varItemDataProfile; }
            set { repo.varItemDataProfile = value; }
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

            SelectAndAddLevel(repo.TestArchitect.ActionsDataProfile.SortField.CbbFieldsInfo, repo.TestArchitect.ActionsDataProfile.SortField.BtnAddSortFieldInfo, varListOption);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestArchitect.ActionsDataProfile.SortField.ButtonFinishSortFields' at Center.", repo.TestArchitect.ActionsDataProfile.SortField.ButtonFinishSortFieldsInfo, new RecordItemIndex(1));
            repo.TestArchitect.ActionsDataProfile.SortField.ButtonFinishSortFields.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TestArchitect.ActionsDataProfile.ItemDataProfile'.", repo.TestArchitect.ActionsDataProfile.ItemDataProfileInfo, new RecordItemIndex(2));
            Validate.Exists(repo.TestArchitect.ActionsDataProfile.ItemDataProfileInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
