﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Pulsar4X.UI.Panels
{
    partial class TaskGroup_Panel : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>   
        /// Gets the TG selection combo box. 
        /// </summary>
        public ComboBox TaskGroupSelectionComboBox
        {
            get { return m_oTaskGroupName; }
        }

        /// <summary>
        /// Similarly this is the faction selection combo box.
        /// </summary>
        public ComboBox FactionSelectionComboBox
        {
            get { return m_oFactionName; }
        }

        /// <summary>
        /// This textbox is where the TG location should be printed.
        /// </summary>
        public TextBox TaskGroupLocationTextBox
        {
            get { return m_oTGLocation; }
        }

        /// <summary>
        /// Textbox for speed setting
        /// </summary>
        public TextBox SetSpeedTextBox
        {
            get { return m_oCurSpeedBox; }
        }

        /// <summary>
        /// Textbox for max speed.
        /// </summary>
        public TextBox MaxSpeedTextBox
        {
            get { return m_oMaxSpeedBox; }
        }

        /// <summary>
        /// ETA and distance to destination box.
        /// </summary>
        public TextBox TimeDistanceTextBox
        {
            get { return m_oTimeDistTextBox; }
        }

        /// <summary>
        /// Here is where the list of potential taskgroup locations should be printed.
        /// </summary>
        public ListBox SystemLocationsListBox
        {
            get { return m_oSystemLocationsListBox; }
        }

        /// <summary>
        /// Allowed actions go here.
        /// </summary>
        public ListBox AvailableActionsListBox
        {
            get { return m_oActionsAvailableListBox; }
        }

        /// <summary>
        /// Current orders are placed here.
        /// </summary>
        public ListBox PlottedMovesListBox
        {
            get { return m_oPlottedMoveListBox; }
        }

        /// <summary>
        /// Secondary orders listbox: minerals, installation, ground units, commanders, teams, pdc parts, and anything else.
        /// </summary>
        public ListBox TaskgroupSecondaryListBox
        {
            get { return m_oTaskgroupSecondaryListBox; }
        }

        /// <summary>
        /// Secondary orders groupbox: will have text for the above.
        /// </summary>
        public GroupBox TaskgroupSecondaryGroupBox
        {
            get { return m_oTaskGroupSecondaryGroupBox; }
        }

        /// <summary>
        /// Should detected contacts be displayed?
        /// </summary>
        public CheckBox DisplayContactsCheckBox
        {
            get { return m_oContactsCheckBox; }
        }

        /// <summary>
        /// Should moons be destinations?
        /// </summary>
        public CheckBox DisplayMoonsCheckBox
        {
            get { return m_oMoonsCheckBox; }
        }

        /// <summary>
        /// display taskgroups checkbox.
        /// </summary>
        public CheckBox DisplayTaskGroupsCheckBox
        {
            get { return m_oTaskGroupsCheckBox; }
        }

        /// <summary>
        /// Display waypoints checkbox.
        /// </summary>
        public CheckBox DisplayWaypointsCheckBox
        {
            get { return m_oWaypointCheckBox; }
        }

        /// <summary>
        /// Filter orders based on what is possible to accomplish given the selected place and taskgroup?
        /// </summary>
        public CheckBox OrderFilteringCheckBox
        {
            get { return m_oOrderFilteringCheckBox; }  
        }

        /// <summary>
        /// Display survey points as taskgroup move orders targets.
        /// </summary>
        public CheckBox DisplaySurveyLocationsCheckBox
        {
            get { return m_oSurveyLocationsCheckBox; }
        }

        /// <summary>
        /// Do not display any surveyed bodies or survey points.
        /// </summary>
        public CheckBox ExcludeSurveyedCheckBox
        {
            get { return m_oExcludeSurveyedCheckBox; }
        }

        /// <summary>
        /// Place any completed orders back in the order list so that a taskgroup will repeatedly perform an order cycle such as "go to here, get a mine, go to there, drop it off"
        /// </summary>
        public CheckBox CycleMovesCheckBox
        {
            get { return m_oCycleMovesCheckBox; }
        }

        /// <summary>
        /// creates a new task group.
        /// </summary>
        public Button NewTaskGroupButton
        {
            get { return m_oNewTGButton; }
        }

        /// <summary>
        /// Renames the selected task group.
        /// </summary>
        public Button RenameTaskGroupButton
        {
            get { return m_oRenameTGButton; }
        }

        /// <summary>
        /// Sets speed to user entered value if valid.
        /// </summary>
        public Button SetSpeedButton
        {
            get { return m_oSetSpeedButton; }
        }

        /// <summary>
        /// Sets speed to maximum possible
        /// </summary>
        public Button MaxSpeedButton
        {
            get { return m_oMaxSpeedButton; }
        }

        /// <summary>
        /// Adds a taskgroup order to the current task group's orders list
        /// </summary>
        public Button AddMoveButton
        {
            get { return m_oAddMoveButton; }
        }

        /// <summary>
        /// Removes the last order issued to the current task group.
        /// </summary>
        public Button RemoveButton 
        { 
            get { return m_oRemoveButton; } 
        }

        /// <summary>
        /// Clears all taskgroup orders.
        /// </summary>
        public Button RemoveAllButton
        {
            get { return m_oRemoveAllButton; }
        }

        /// <summary>
        /// Time and distance for only the current order.
        /// </summary>
        public RadioButton CurrentTDRadioButton
        {
            get { return m_oCurrentTDRadioButton; }
        }

        /// <summary>
        /// Time and distance for all orders.
        /// </summary>
        public RadioButton AllOrdersTDRadioButton
        {
            get { return m_oAllOrdersRadioButton; }
        }

        #region Organization Tab

        /// <summary>
        /// Move a ship from the selected taskgroup to the current taskgroup
        /// </summary>
        public Button OrgMoveLeftButton
        {
            get { return m_oOrgMoveLeftButton; }
        }

        /// <summary>
        /// Move a ship from the current taskgroup to the selected taskgroup.
        /// </summary>
        public Button OrgMoveRightButton
        {
            get { return m_oOrgMoveRightButton; }
        }

        /// <summary>
        /// Which taskgroup has the user selected?
        /// </summary>
        public ComboBox OrgSelectedTGComboBox
        {
            get { return m_oOrgSelectedTGComboBox; }
        }

        /// <summary>
        /// List of ships from the current TG.
        /// </summary>
        public ListBox OrgCurrentTGListBox
        {
            get { return m_oOrgCurrentTGListBox; }
        }

        /// <summary>
        /// List of ships from the selected TG
        /// </summary>
        public ListBox OrgSelectedTGListBox
        {
            get { return m_oOrgSelectedTGListBox; }
        }

        /// <summary>
        /// Name of the selected Taskgroup.
        /// </summary>
        public TextBox OrgCurrentTGTextBox
        {
            get { return m_oOrgCurrentTGTextBox; }
        }
        
        #endregion 

        #region Special Orders Tab
        /// <summary>
        /// The list of primary default orders. these will be done before secondary default orders.
        /// </summary>
        public ComboBox PrimaryDefaultOrderComboBox
        {
            get { return m_oPrimaryDefaultOrdersComboBox; }
        }
        public ComboBox SecondaryDefaultOrderComboBox
        {
            get { return m_oSecondaryDefaultOrdersComboBox; }
        }

        /// <summary>
        /// How should conditionals be handled? should they interrupt orders?
        /// </summary>
        public ComboBox ConditionalAConditionComboBox
        {
            get { return m_oCondAConditionComboBox; }
        }
        public ComboBox ConditionalAOrderComboBox
        {
            get { return m_oCondAOrderComboBox; }
        }

        public ComboBox ConditionalBConditionComboBox
        {
            get { return m_oCondBConditionComboBox; }
        }
        public ComboBox ConditionalBOrderComboBox
        {
            get { return m_oCondBOrderComboBox; }
        }
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_oTaskGroupName = new System.Windows.Forms.ComboBox();
            this.m_oShipsBox = new System.Windows.Forms.GroupBox();
            this.m_oGeneralTGDetailsBox = new System.Windows.Forms.GroupBox();
            this.m_oTaskForceName = new System.Windows.Forms.ComboBox();
            this.m_oTFLabel = new System.Windows.Forms.Label();
            this.m_oLocationLabel = new System.Windows.Forms.Label();
            this.m_oTGLocation = new System.Windows.Forms.TextBox();
            this.m_oFactionName = new System.Windows.Forms.ComboBox();
            this.m_oFactionLabel = new System.Windows.Forms.Label();
            this.m_oTaskGroupLabel = new System.Windows.Forms.Label();
            this.m_oTaskGroupTabControl = new System.Windows.Forms.TabControl();
            this.m_oTaskGroupOrdersTabPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.m_oReloadParaButton = new System.Windows.Forms.Button();
            this.m_oLaunchParaButton = new System.Windows.Forms.Button();
            this.m_oRecoverParaButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.m_oShieldsOnButton = new System.Windows.Forms.Button();
            this.m_oShieldsOffButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_oHyperOnButton = new System.Windows.Forms.Button();
            this.m_oHyperOffButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_oAssembleButton = new System.Windows.Forms.Button();
            this.m_oSaveEscortsButton = new System.Windows.Forms.Button();
            this.m_oDetachButton = new System.Windows.Forms.Button();
            this.m_oRecallEscortsButton = new System.Windows.Forms.Button();
            this.m_oEscortButton = new System.Windows.Forms.Button();
            this.m_oDeployEscortsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_oEqualizeMaintButton = new System.Windows.Forms.Button();
            this.m_oEqualizeFuelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_oMissileLaunchButton = new System.Windows.Forms.Button();
            this.m_oNoDefaultButton = new System.Windows.Forms.Button();
            this.m_oNoConditionsButton = new System.Windows.Forms.Button();
            this.m_oTaskGroupOrdersBox = new System.Windows.Forms.GroupBox();
            this.m_oRepeatOrdersTextBox = new System.Windows.Forms.TextBox();
            this.m_oRepeatOrderButton = new System.Windows.Forms.Button();
            this.m_oCycleMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oOrderDelayTextBox = new System.Windows.Forms.TextBox();
            this.m_oOrderDelayLabel = new System.Windows.Forms.Label();
            this.m_oAutoRouteCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oLoadAmtTextBox = new System.Windows.Forms.TextBox();
            this.m_oOrbitalDistanceTextBox = new System.Windows.Forms.TextBox();
            this.m_oLoadLimitLabel = new System.Windows.Forms.Label();
            this.m_oOrbitalDistanceLabel = new System.Windows.Forms.Label();
            this.m_oRemoveAllButton = new System.Windows.Forms.Button();
            this.m_oRemoveButton = new System.Windows.Forms.Button();
            this.m_oAddMoveButton = new System.Windows.Forms.Button();
            this.m_oPlottedMoveLabel = new System.Windows.Forms.Label();
            this.m_oActionsAvailableLabel = new System.Windows.Forms.Label();
            this.m_oSystemLocationsLabel = new System.Windows.Forms.Label();
            this.m_oPlottedMoveListBox = new System.Windows.Forms.ListBox();
            this.m_oActionsAvailableListBox = new System.Windows.Forms.ListBox();
            this.m_oSystemLocationsListBox = new System.Windows.Forms.ListBox();
            this.m_oCopyOrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oIncCondOrdersCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oIncDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.m_oCopyOrdersButton = new System.Windows.Forms.Button();
            this.m_oSystemDisplayOptionsBox = new System.Windows.Forms.GroupBox();
            this.m_oShowAllPopsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oOrderFilteringCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oExcludeSurveyedCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oSurveyLocationsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oWrecksCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oLifePodsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oCometsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oContactsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oWaypointCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oTaskGroupsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oAsteroidsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oMoonsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oSpecialOrdersTabPage = new System.Windows.Forms.TabPage();
            this.m_oTaskforceTrainingGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oStartTaskforceTrainingButton = new System.Windows.Forms.Button();
            this.m_oSubordinateFormationGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oSubordinateFormationsListBox = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.m_oCopyConditionalCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oCopyDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oMatchSpeedsCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oCopyOrdersToSubordinateButton = new System.Windows.Forms.Button();
            this.m_oCondOrderAGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oCondAOrderLabel = new System.Windows.Forms.Label();
            this.m_oCondACondLabel = new System.Windows.Forms.Label();
            this.m_oCondAOrderComboBox = new System.Windows.Forms.ComboBox();
            this.m_oCondAConditionComboBox = new System.Windows.Forms.ComboBox();
            this.m_oSuperiorFormationGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oSaveFormationButton = new System.Windows.Forms.Button();
            this.m_oSuperiorFormationComboBox = new System.Windows.Forms.ComboBox();
            this.m_oCombineTaskgroupGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oSaveCombineButton = new System.Windows.Forms.Button();
            this.m_oCombineTaskgroupsComboBox = new System.Windows.Forms.ComboBox();
            this.m_oCondOrderBGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oCondBOrderLabel = new System.Windows.Forms.Label();
            this.m_oCondBCondLabel = new System.Windows.Forms.Label();
            this.m_oCondBOrderComboBox = new System.Windows.Forms.ComboBox();
            this.m_oCondBConditionComboBox = new System.Windows.Forms.ComboBox();
            this.m_oDefaultOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oDefaultSecondaryLabel = new System.Windows.Forms.Label();
            this.m_oDefaultPrimaryLabel = new System.Windows.Forms.Label();
            this.m_oSecondaryDefaultOrdersComboBox = new System.Windows.Forms.ComboBox();
            this.m_oPrimaryDefaultOrdersComboBox = new System.Windows.Forms.ComboBox();
            this.m_oProtectThreatAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oBearingThreatLabel = new System.Windows.Forms.Label();
            this.m_oOffsetthreatLabel = new System.Windows.Forms.Label();
            this.m_oThreatDistanceLabel = new System.Windows.Forms.Label();
            this.m_oTaskGroupThreatLabel = new System.Windows.Forms.Label();
            this.m_oThreatLabel = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.m_oOrganizationTabPage = new System.Windows.Forms.TabPage();
            this.m_oShipMoveToTGGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oOrgSelectedTGListBox = new System.Windows.Forms.ListBox();
            this.m_oOrgCurrentTGListBox = new System.Windows.Forms.ListBox();
            this.m_oOrgSMModeButton = new System.Windows.Forms.Button();
            this.m_oOrgDivideTG = new System.Windows.Forms.Button();
            this.m_oOrgSplitTGButton = new System.Windows.Forms.Button();
            this.m_oOrgMoveLeftButton = new System.Windows.Forms.Button();
            this.m_oOrgMoveRightButton = new System.Windows.Forms.Button();
            this.m_oOrgSelectedTGComboBox = new System.Windows.Forms.ComboBox();
            this.m_oOrgCurrentTGTextBox = new System.Windows.Forms.TextBox();
            this.m_oHistoryTabPage = new System.Windows.Forms.TabPage();
            this.m_oNavalOrgTabPage = new System.Windows.Forms.TabPage();
            this.m_oTaskGroupInfoTabPage = new System.Windows.Forms.TabPage();
            this.m_oCargoFightersTroopsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oDefaultCondEscortOrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oOOBGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oOrderTimeDistBox = new System.Windows.Forms.GroupBox();
            this.m_oAllOrdersRadioButton = new System.Windows.Forms.RadioButton();
            this.m_oCurrentTDRadioButton = new System.Windows.Forms.RadioButton();
            this.m_oTimeDistTextBox = new System.Windows.Forms.TextBox();
            this.m_oOfficerBox = new System.Windows.Forms.GroupBox();
            this.m_oSeniorOfficerTextBox = new System.Windows.Forms.TextBox();
            this.m_oInitiativeBox = new System.Windows.Forms.GroupBox();
            this.m_oInitiativeButton = new System.Windows.Forms.Button();
            this.m_oCurrentInitTextBox = new System.Windows.Forms.TextBox();
            this.m_oCurrentInitLabel = new System.Windows.Forms.Label();
            this.m_oMaxInitLabel = new System.Windows.Forms.Label();
            this.m_oMaxInitTextBox = new System.Windows.Forms.TextBox();
            this.m_oSurveyBox = new System.Windows.Forms.GroupBox();
            this.m_oGeoTextBox = new System.Windows.Forms.TextBox();
            this.m_oGeoLabel = new System.Windows.Forms.Label();
            this.m_oGravLabel = new System.Windows.Forms.Label();
            this.m_oGravTextBox = new System.Windows.Forms.TextBox();
            this.m_oCenterShowGF = new System.Windows.Forms.GroupBox();
            this.m_oShowGroundForces = new System.Windows.Forms.CheckBox();
            this.m_oCenterMapCheckBox = new System.Windows.Forms.CheckBox();
            this.m_oSpeedBox = new System.Windows.Forms.GroupBox();
            this.m_oMaxSpeedButton = new System.Windows.Forms.Button();
            this.m_oSetSpeedButton = new System.Windows.Forms.Button();
            this.m_oMaxSpeedBox = new System.Windows.Forms.TextBox();
            this.m_oCurSpeedBox = new System.Windows.Forms.TextBox();
            this.m_oButtonBox = new System.Windows.Forms.GroupBox();
            this.m_oDeleteTGButton = new System.Windows.Forms.Button();
            this.m_oOOBButton = new System.Windows.Forms.Button();
            this.m_oRenameTGButton = new System.Windows.Forms.Button();
            this.m_oAddColonyButton = new System.Windows.Forms.Button();
            this.m_oSystemMapButton = new System.Windows.Forms.Button();
            this.m_oNewTGButton = new System.Windows.Forms.Button();
            this.m_oTaskGroupSecondaryGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oTaskgroupSecondaryListBox = new System.Windows.Forms.ListBox();
            this.m_oGeneralTGDetailsBox.SuspendLayout();
            this.m_oTaskGroupTabControl.SuspendLayout();
            this.m_oTaskGroupOrdersTabPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.m_oTaskGroupOrdersBox.SuspendLayout();
            this.m_oCopyOrdersGroupBox.SuspendLayout();
            this.m_oSystemDisplayOptionsBox.SuspendLayout();
            this.m_oSpecialOrdersTabPage.SuspendLayout();
            this.m_oTaskforceTrainingGroupBox.SuspendLayout();
            this.m_oSubordinateFormationGroupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.m_oCondOrderAGroupBox.SuspendLayout();
            this.m_oSuperiorFormationGroupBox.SuspendLayout();
            this.m_oCombineTaskgroupGroupBox.SuspendLayout();
            this.m_oCondOrderBGroupBox.SuspendLayout();
            this.m_oDefaultOrderGroupBox.SuspendLayout();
            this.m_oProtectThreatAxisGroupBox.SuspendLayout();
            this.m_oOrganizationTabPage.SuspendLayout();
            this.m_oShipMoveToTGGroupBox.SuspendLayout();
            this.m_oTaskGroupInfoTabPage.SuspendLayout();
            this.m_oOrderTimeDistBox.SuspendLayout();
            this.m_oOfficerBox.SuspendLayout();
            this.m_oInitiativeBox.SuspendLayout();
            this.m_oSurveyBox.SuspendLayout();
            this.m_oCenterShowGF.SuspendLayout();
            this.m_oSpeedBox.SuspendLayout();
            this.m_oButtonBox.SuspendLayout();
            this.m_oTaskGroupSecondaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_oTaskGroupName
            // 
            this.m_oTaskGroupName.FormattingEnabled = true;
            this.m_oTaskGroupName.Location = new System.Drawing.Point(54, 52);
            this.m_oTaskGroupName.Name = "m_oTaskGroupName";
            this.m_oTaskGroupName.Size = new System.Drawing.Size(171, 21);
            this.m_oTaskGroupName.TabIndex = 1;
            // 
            // m_oShipsBox
            // 
            this.m_oShipsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_oShipsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_oShipsBox.Location = new System.Drawing.Point(251, 3);
            this.m_oShipsBox.MaximumSize = new System.Drawing.Size(2000, 215);
            this.m_oShipsBox.MinimumSize = new System.Drawing.Size(600, 215);
            this.m_oShipsBox.Name = "m_oShipsBox";
            this.m_oShipsBox.Size = new System.Drawing.Size(745, 215);
            this.m_oShipsBox.TabIndex = 2;
            this.m_oShipsBox.TabStop = false;
            this.m_oShipsBox.Text = "Ships in TaskGroup - Double-Click to open Ship window";
            // 
            // m_oGeneralTGDetailsBox
            // 
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oTaskForceName);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oTFLabel);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oLocationLabel);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oTGLocation);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oFactionName);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oFactionLabel);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oTaskGroupLabel);
            this.m_oGeneralTGDetailsBox.Controls.Add(this.m_oTaskGroupName);
            this.m_oGeneralTGDetailsBox.Location = new System.Drawing.Point(5, 3);
            this.m_oGeneralTGDetailsBox.MaximumSize = new System.Drawing.Size(240, 140);
            this.m_oGeneralTGDetailsBox.MinimumSize = new System.Drawing.Size(240, 140);
            this.m_oGeneralTGDetailsBox.Name = "m_oGeneralTGDetailsBox";
            this.m_oGeneralTGDetailsBox.Size = new System.Drawing.Size(240, 140);
            this.m_oGeneralTGDetailsBox.TabIndex = 3;
            this.m_oGeneralTGDetailsBox.TabStop = false;
            this.m_oGeneralTGDetailsBox.Text = "Details and Special Orders";
            // 
            // m_oTaskForceName
            // 
            this.m_oTaskForceName.FormattingEnabled = true;
            this.m_oTaskForceName.Location = new System.Drawing.Point(54, 111);
            this.m_oTaskForceName.Name = "m_oTaskForceName";
            this.m_oTaskForceName.Size = new System.Drawing.Size(171, 21);
            this.m_oTaskForceName.TabIndex = 28;
            // 
            // m_oTFLabel
            // 
            this.m_oTFLabel.AutoSize = true;
            this.m_oTFLabel.Location = new System.Drawing.Point(10, 106);
            this.m_oTFLabel.MaximumSize = new System.Drawing.Size(35, 26);
            this.m_oTFLabel.MinimumSize = new System.Drawing.Size(35, 26);
            this.m_oTFLabel.Name = "m_oTFLabel";
            this.m_oTFLabel.Size = new System.Drawing.Size(35, 26);
            this.m_oTFLabel.TabIndex = 27;
            this.m_oTFLabel.Text = "Task  Force";
            // 
            // m_oLocationLabel
            // 
            this.m_oLocationLabel.AutoSize = true;
            this.m_oLocationLabel.Location = new System.Drawing.Point(6, 82);
            this.m_oLocationLabel.Name = "m_oLocationLabel";
            this.m_oLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.m_oLocationLabel.TabIndex = 26;
            this.m_oLocationLabel.Text = "Location";
            // 
            // m_oTGLocation
            // 
            this.m_oTGLocation.Enabled = false;
            this.m_oTGLocation.Location = new System.Drawing.Point(54, 79);
            this.m_oTGLocation.Name = "m_oTGLocation";
            this.m_oTGLocation.Size = new System.Drawing.Size(171, 20);
            this.m_oTGLocation.TabIndex = 25;
            // 
            // m_oFactionName
            // 
            this.m_oFactionName.FormattingEnabled = true;
            this.m_oFactionName.Location = new System.Drawing.Point(54, 25);
            this.m_oFactionName.Name = "m_oFactionName";
            this.m_oFactionName.Size = new System.Drawing.Size(171, 21);
            this.m_oFactionName.TabIndex = 24;
            // 
            // m_oFactionLabel
            // 
            this.m_oFactionLabel.AutoSize = true;
            this.m_oFactionLabel.Location = new System.Drawing.Point(6, 28);
            this.m_oFactionLabel.Name = "m_oFactionLabel";
            this.m_oFactionLabel.Size = new System.Drawing.Size(39, 13);
            this.m_oFactionLabel.TabIndex = 23;
            this.m_oFactionLabel.Text = "Empire";
            // 
            // m_oTaskGroupLabel
            // 
            this.m_oTaskGroupLabel.AutoSize = true;
            this.m_oTaskGroupLabel.Location = new System.Drawing.Point(6, 55);
            this.m_oTaskGroupLabel.Name = "m_oTaskGroupLabel";
            this.m_oTaskGroupLabel.Size = new System.Drawing.Size(35, 13);
            this.m_oTaskGroupLabel.TabIndex = 22;
            this.m_oTaskGroupLabel.Text = "Name";
            // 
            // m_oTaskGroupTabControl
            // 
            this.m_oTaskGroupTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_oTaskGroupTabControl.Controls.Add(this.m_oTaskGroupOrdersTabPage);
            this.m_oTaskGroupTabControl.Controls.Add(this.m_oSpecialOrdersTabPage);
            this.m_oTaskGroupTabControl.Controls.Add(this.m_oOrganizationTabPage);
            this.m_oTaskGroupTabControl.Controls.Add(this.m_oHistoryTabPage);
            this.m_oTaskGroupTabControl.Controls.Add(this.m_oNavalOrgTabPage);
            this.m_oTaskGroupTabControl.Controls.Add(this.m_oTaskGroupInfoTabPage);
            this.m_oTaskGroupTabControl.Location = new System.Drawing.Point(5, 224);
            this.m_oTaskGroupTabControl.MinimumSize = new System.Drawing.Size(600, 400);
            this.m_oTaskGroupTabControl.Name = "m_oTaskGroupTabControl";
            this.m_oTaskGroupTabControl.SelectedIndex = 0;
            this.m_oTaskGroupTabControl.Size = new System.Drawing.Size(991, 455);
            this.m_oTaskGroupTabControl.TabIndex = 39;
            // 
            // m_oTaskGroupOrdersTabPage
            // 
            this.m_oTaskGroupOrdersTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.groupBox6);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.groupBox5);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.groupBox4);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.groupBox3);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.groupBox2);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.groupBox1);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.m_oTaskGroupOrdersBox);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.m_oCopyOrdersGroupBox);
            this.m_oTaskGroupOrdersTabPage.Controls.Add(this.m_oSystemDisplayOptionsBox);
            this.m_oTaskGroupOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_oTaskGroupOrdersTabPage.Name = "m_oTaskGroupOrdersTabPage";
            this.m_oTaskGroupOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_oTaskGroupOrdersTabPage.Size = new System.Drawing.Size(983, 429);
            this.m_oTaskGroupOrdersTabPage.TabIndex = 0;
            this.m_oTaskGroupOrdersTabPage.Text = "Task Group Orders";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.m_oReloadParaButton);
            this.groupBox6.Controls.Add(this.m_oLaunchParaButton);
            this.groupBox6.Controls.Add(this.m_oRecoverParaButton);
            this.groupBox6.Location = new System.Drawing.Point(6, 357);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 71);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parasites";
            // 
            // m_oReloadParaButton
            // 
            this.m_oReloadParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oReloadParaButton.Location = new System.Drawing.Point(4, 43);
            this.m_oReloadParaButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oReloadParaButton.Name = "m_oReloadParaButton";
            this.m_oReloadParaButton.Size = new System.Drawing.Size(70, 25);
            this.m_oReloadParaButton.TabIndex = 73;
            this.m_oReloadParaButton.Text = "Reload";
            this.m_oReloadParaButton.UseVisualStyleBackColor = true;
            // 
            // m_oLaunchParaButton
            // 
            this.m_oLaunchParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oLaunchParaButton.Location = new System.Drawing.Point(4, 14);
            this.m_oLaunchParaButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oLaunchParaButton.Name = "m_oLaunchParaButton";
            this.m_oLaunchParaButton.Size = new System.Drawing.Size(70, 25);
            this.m_oLaunchParaButton.TabIndex = 51;
            this.m_oLaunchParaButton.Text = "Launch";
            this.m_oLaunchParaButton.UseVisualStyleBackColor = true;
            // 
            // m_oRecoverParaButton
            // 
            this.m_oRecoverParaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oRecoverParaButton.Location = new System.Drawing.Point(76, 14);
            this.m_oRecoverParaButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oRecoverParaButton.Name = "m_oRecoverParaButton";
            this.m_oRecoverParaButton.Size = new System.Drawing.Size(70, 25);
            this.m_oRecoverParaButton.TabIndex = 52;
            this.m_oRecoverParaButton.Text = "Recover";
            this.m_oRecoverParaButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.m_oShieldsOnButton);
            this.groupBox5.Controls.Add(this.m_oShieldsOffButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 50);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shields";
            // 
            // m_oShieldsOnButton
            // 
            this.m_oShieldsOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oShieldsOnButton.Location = new System.Drawing.Point(4, 14);
            this.m_oShieldsOnButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oShieldsOnButton.Name = "m_oShieldsOnButton";
            this.m_oShieldsOnButton.Size = new System.Drawing.Size(70, 25);
            this.m_oShieldsOnButton.TabIndex = 70;
            this.m_oShieldsOnButton.Text = "Shields On";
            this.m_oShieldsOnButton.UseVisualStyleBackColor = true;
            // 
            // m_oShieldsOffButton
            // 
            this.m_oShieldsOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oShieldsOffButton.Location = new System.Drawing.Point(76, 14);
            this.m_oShieldsOffButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oShieldsOffButton.Name = "m_oShieldsOffButton";
            this.m_oShieldsOffButton.Size = new System.Drawing.Size(70, 25);
            this.m_oShieldsOffButton.TabIndex = 69;
            this.m_oShieldsOffButton.Text = "Shields Off";
            this.m_oShieldsOffButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_oHyperOnButton);
            this.groupBox4.Controls.Add(this.m_oHyperOffButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 50);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hyper";
            // 
            // m_oHyperOnButton
            // 
            this.m_oHyperOnButton.Enabled = false;
            this.m_oHyperOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oHyperOnButton.Location = new System.Drawing.Point(4, 14);
            this.m_oHyperOnButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oHyperOnButton.Name = "m_oHyperOnButton";
            this.m_oHyperOnButton.Size = new System.Drawing.Size(70, 25);
            this.m_oHyperOnButton.TabIndex = 72;
            this.m_oHyperOnButton.Text = "Hyper On";
            this.m_oHyperOnButton.UseVisualStyleBackColor = true;
            // 
            // m_oHyperOffButton
            // 
            this.m_oHyperOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oHyperOffButton.Location = new System.Drawing.Point(76, 14);
            this.m_oHyperOffButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oHyperOffButton.Name = "m_oHyperOffButton";
            this.m_oHyperOffButton.Size = new System.Drawing.Size(70, 25);
            this.m_oHyperOffButton.TabIndex = 71;
            this.m_oHyperOffButton.Text = "Hyper Off";
            this.m_oHyperOffButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_oAssembleButton);
            this.groupBox3.Controls.Add(this.m_oSaveEscortsButton);
            this.groupBox3.Controls.Add(this.m_oDetachButton);
            this.groupBox3.Controls.Add(this.m_oRecallEscortsButton);
            this.groupBox3.Controls.Add(this.m_oEscortButton);
            this.groupBox3.Controls.Add(this.m_oDeployEscortsButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 110);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escorts";
            // 
            // m_oAssembleButton
            // 
            this.m_oAssembleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oAssembleButton.Location = new System.Drawing.Point(76, 74);
            this.m_oAssembleButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oAssembleButton.Name = "m_oAssembleButton";
            this.m_oAssembleButton.Size = new System.Drawing.Size(70, 25);
            this.m_oAssembleButton.TabIndex = 78;
            this.m_oAssembleButton.Text = "Assemble";
            this.m_oAssembleButton.UseVisualStyleBackColor = true;
            // 
            // m_oSaveEscortsButton
            // 
            this.m_oSaveEscortsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oSaveEscortsButton.Location = new System.Drawing.Point(4, 14);
            this.m_oSaveEscortsButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oSaveEscortsButton.Name = "m_oSaveEscortsButton";
            this.m_oSaveEscortsButton.Size = new System.Drawing.Size(70, 25);
            this.m_oSaveEscortsButton.TabIndex = 75;
            this.m_oSaveEscortsButton.Text = "Save";
            this.m_oSaveEscortsButton.UseVisualStyleBackColor = true;
            // 
            // m_oDetachButton
            // 
            this.m_oDetachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oDetachButton.Location = new System.Drawing.Point(4, 74);
            this.m_oDetachButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oDetachButton.Name = "m_oDetachButton";
            this.m_oDetachButton.Size = new System.Drawing.Size(70, 25);
            this.m_oDetachButton.TabIndex = 77;
            this.m_oDetachButton.Text = "Detach";
            this.m_oDetachButton.UseVisualStyleBackColor = true;
            // 
            // m_oRecallEscortsButton
            // 
            this.m_oRecallEscortsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oRecallEscortsButton.Location = new System.Drawing.Point(76, 44);
            this.m_oRecallEscortsButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oRecallEscortsButton.Name = "m_oRecallEscortsButton";
            this.m_oRecallEscortsButton.Size = new System.Drawing.Size(70, 25);
            this.m_oRecallEscortsButton.TabIndex = 65;
            this.m_oRecallEscortsButton.Text = "Recall";
            this.m_oRecallEscortsButton.UseVisualStyleBackColor = true;
            // 
            // m_oEscortButton
            // 
            this.m_oEscortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oEscortButton.Location = new System.Drawing.Point(76, 14);
            this.m_oEscortButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oEscortButton.Name = "m_oEscortButton";
            this.m_oEscortButton.Size = new System.Drawing.Size(70, 25);
            this.m_oEscortButton.TabIndex = 76;
            this.m_oEscortButton.Text = "Escort";
            this.m_oEscortButton.UseVisualStyleBackColor = true;
            // 
            // m_oDeployEscortsButton
            // 
            this.m_oDeployEscortsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oDeployEscortsButton.Location = new System.Drawing.Point(4, 44);
            this.m_oDeployEscortsButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oDeployEscortsButton.Name = "m_oDeployEscortsButton";
            this.m_oDeployEscortsButton.Size = new System.Drawing.Size(70, 25);
            this.m_oDeployEscortsButton.TabIndex = 66;
            this.m_oDeployEscortsButton.Text = "Deploy";
            this.m_oDeployEscortsButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_oEqualizeMaintButton);
            this.groupBox2.Controls.Add(this.m_oEqualizeFuelButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 46);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equalize";
            // 
            // m_oEqualizeMaintButton
            // 
            this.m_oEqualizeMaintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oEqualizeMaintButton.Location = new System.Drawing.Point(4, 14);
            this.m_oEqualizeMaintButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oEqualizeMaintButton.Name = "m_oEqualizeMaintButton";
            this.m_oEqualizeMaintButton.Size = new System.Drawing.Size(70, 25);
            this.m_oEqualizeMaintButton.TabIndex = 62;
            this.m_oEqualizeMaintButton.Text = "Maint.";
            this.m_oEqualizeMaintButton.UseVisualStyleBackColor = true;
            // 
            // m_oEqualizeFuelButton
            // 
            this.m_oEqualizeFuelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oEqualizeFuelButton.Location = new System.Drawing.Point(76, 14);
            this.m_oEqualizeFuelButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oEqualizeFuelButton.Name = "m_oEqualizeFuelButton";
            this.m_oEqualizeFuelButton.Size = new System.Drawing.Size(70, 25);
            this.m_oEqualizeFuelButton.TabIndex = 63;
            this.m_oEqualizeFuelButton.Text = "Fuel";
            this.m_oEqualizeFuelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_oMissileLaunchButton);
            this.groupBox1.Controls.Add(this.m_oNoDefaultButton);
            this.groupBox1.Controls.Add(this.m_oNoConditionsButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(174, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 78);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TG Orders";
            // 
            // m_oMissileLaunchButton
            // 
            this.m_oMissileLaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oMissileLaunchButton.Location = new System.Drawing.Point(4, 13);
            this.m_oMissileLaunchButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oMissileLaunchButton.Name = "m_oMissileLaunchButton";
            this.m_oMissileLaunchButton.Size = new System.Drawing.Size(70, 25);
            this.m_oMissileLaunchButton.TabIndex = 74;
            this.m_oMissileLaunchButton.Text = "Msl Launch";
            this.m_oMissileLaunchButton.UseVisualStyleBackColor = true;
            // 
            // m_oNoDefaultButton
            // 
            this.m_oNoDefaultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oNoDefaultButton.Location = new System.Drawing.Point(4, 42);
            this.m_oNoDefaultButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oNoDefaultButton.Name = "m_oNoDefaultButton";
            this.m_oNoDefaultButton.Size = new System.Drawing.Size(70, 25);
            this.m_oNoDefaultButton.TabIndex = 68;
            this.m_oNoDefaultButton.Text = "No Default";
            this.m_oNoDefaultButton.UseVisualStyleBackColor = true;
            // 
            // m_oNoConditionsButton
            // 
            this.m_oNoConditionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_oNoConditionsButton.Location = new System.Drawing.Point(76, 13);
            this.m_oNoConditionsButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.m_oNoConditionsButton.Name = "m_oNoConditionsButton";
            this.m_oNoConditionsButton.Size = new System.Drawing.Size(70, 54);
            this.m_oNoConditionsButton.TabIndex = 59;
            this.m_oNoConditionsButton.Text = "No Conditions";
            this.m_oNoConditionsButton.UseVisualStyleBackColor = true;
            // 
            // m_oTaskGroupOrdersBox
            // 
            this.m_oTaskGroupOrdersBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oTaskGroupOrdersBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oTaskGroupSecondaryGroupBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oRepeatOrdersTextBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oRepeatOrderButton);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oCycleMovesCheckBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oOrderDelayTextBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oOrderDelayLabel);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oAutoRouteCheckBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oLoadAmtTextBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oOrbitalDistanceTextBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oLoadLimitLabel);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oOrbitalDistanceLabel);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oRemoveAllButton);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oRemoveButton);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oAddMoveButton);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oPlottedMoveLabel);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oActionsAvailableLabel);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oSystemLocationsLabel);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oPlottedMoveListBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oActionsAvailableListBox);
            this.m_oTaskGroupOrdersBox.Controls.Add(this.m_oSystemLocationsListBox);
            this.m_oTaskGroupOrdersBox.Location = new System.Drawing.Point(165, 68);
            this.m_oTaskGroupOrdersBox.MinimumSize = new System.Drawing.Size(800, 205);
            this.m_oTaskGroupOrdersBox.Name = "m_oTaskGroupOrdersBox";
            this.m_oTaskGroupOrdersBox.Size = new System.Drawing.Size(805, 355);
            this.m_oTaskGroupOrdersBox.TabIndex = 33;
            this.m_oTaskGroupOrdersBox.TabStop = false;
            // 
            // m_oRepeatOrdersTextBox
            // 
            this.m_oRepeatOrdersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oRepeatOrdersTextBox.Location = new System.Drawing.Point(765, 311);
            this.m_oRepeatOrdersTextBox.Name = "m_oRepeatOrdersTextBox";
            this.m_oRepeatOrdersTextBox.Size = new System.Drawing.Size(27, 20);
            this.m_oRepeatOrdersTextBox.TabIndex = 44;
            this.m_oRepeatOrdersTextBox.Text = "0";
            this.m_oRepeatOrdersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_oRepeatOrderButton
            // 
            this.m_oRepeatOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oRepeatOrderButton.Location = new System.Drawing.Point(690, 309);
            this.m_oRepeatOrderButton.Name = "m_oRepeatOrderButton";
            this.m_oRepeatOrderButton.Size = new System.Drawing.Size(61, 26);
            this.m_oRepeatOrderButton.TabIndex = 43;
            this.m_oRepeatOrderButton.Text = "Repeat";
            this.m_oRepeatOrderButton.UseVisualStyleBackColor = true;
            // 
            // m_oCycleMovesCheckBox
            // 
            this.m_oCycleMovesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oCycleMovesCheckBox.AutoSize = true;
            this.m_oCycleMovesCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oCycleMovesCheckBox.Location = new System.Drawing.Point(690, 279);
            this.m_oCycleMovesCheckBox.MaximumSize = new System.Drawing.Size(102, 17);
            this.m_oCycleMovesCheckBox.MinimumSize = new System.Drawing.Size(102, 17);
            this.m_oCycleMovesCheckBox.Name = "m_oCycleMovesCheckBox";
            this.m_oCycleMovesCheckBox.Size = new System.Drawing.Size(102, 17);
            this.m_oCycleMovesCheckBox.TabIndex = 21;
            this.m_oCycleMovesCheckBox.Text = "Cycle Moves";
            this.m_oCycleMovesCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oOrderDelayTextBox
            // 
            this.m_oOrderDelayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oOrderDelayTextBox.Location = new System.Drawing.Point(597, 312);
            this.m_oOrderDelayTextBox.Name = "m_oOrderDelayTextBox";
            this.m_oOrderDelayTextBox.Size = new System.Drawing.Size(77, 20);
            this.m_oOrderDelayTextBox.TabIndex = 42;
            this.m_oOrderDelayTextBox.Text = "0";
            this.m_oOrderDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_oOrderDelayLabel
            // 
            this.m_oOrderDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oOrderDelayLabel.AutoSize = true;
            this.m_oOrderDelayLabel.Location = new System.Drawing.Point(528, 315);
            this.m_oOrderDelayLabel.Name = "m_oOrderDelayLabel";
            this.m_oOrderDelayLabel.Size = new System.Drawing.Size(63, 13);
            this.m_oOrderDelayLabel.TabIndex = 41;
            this.m_oOrderDelayLabel.Text = "Order Delay";
            // 
            // m_oAutoRouteCheckBox
            // 
            this.m_oAutoRouteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oAutoRouteCheckBox.AutoSize = true;
            this.m_oAutoRouteCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oAutoRouteCheckBox.Location = new System.Drawing.Point(519, 279);
            this.m_oAutoRouteCheckBox.MaximumSize = new System.Drawing.Size(155, 17);
            this.m_oAutoRouteCheckBox.MinimumSize = new System.Drawing.Size(155, 17);
            this.m_oAutoRouteCheckBox.Name = "m_oAutoRouteCheckBox";
            this.m_oAutoRouteCheckBox.Size = new System.Drawing.Size(155, 17);
            this.m_oAutoRouteCheckBox.TabIndex = 21;
            this.m_oAutoRouteCheckBox.Text = "No auto-route jump check";
            this.m_oAutoRouteCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oLoadAmtTextBox
            // 
            this.m_oLoadAmtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oLoadAmtTextBox.Enabled = false;
            this.m_oLoadAmtTextBox.Location = new System.Drawing.Point(437, 315);
            this.m_oLoadAmtTextBox.Name = "m_oLoadAmtTextBox";
            this.m_oLoadAmtTextBox.Size = new System.Drawing.Size(56, 20);
            this.m_oLoadAmtTextBox.TabIndex = 40;
            this.m_oLoadAmtTextBox.Text = "0";
            this.m_oLoadAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_oOrbitalDistanceTextBox
            // 
            this.m_oOrbitalDistanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oOrbitalDistanceTextBox.Location = new System.Drawing.Point(437, 286);
            this.m_oOrbitalDistanceTextBox.Name = "m_oOrbitalDistanceTextBox";
            this.m_oOrbitalDistanceTextBox.Size = new System.Drawing.Size(56, 20);
            this.m_oOrbitalDistanceTextBox.TabIndex = 35;
            this.m_oOrbitalDistanceTextBox.Text = "0";
            this.m_oOrbitalDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_oLoadLimitLabel
            // 
            this.m_oLoadLimitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oLoadLimitLabel.AutoSize = true;
            this.m_oLoadLimitLabel.Enabled = false;
            this.m_oLoadLimitLabel.Location = new System.Drawing.Point(273, 318);
            this.m_oLoadLimitLabel.Name = "m_oLoadLimitLabel";
            this.m_oLoadLimitLabel.Size = new System.Drawing.Size(129, 13);
            this.m_oLoadLimitLabel.TabIndex = 39;
            this.m_oLoadLimitLabel.Text = "Maximum Amount to Load";
            // 
            // m_oOrbitalDistanceLabel
            // 
            this.m_oOrbitalDistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oOrbitalDistanceLabel.AutoSize = true;
            this.m_oOrbitalDistanceLabel.Location = new System.Drawing.Point(273, 289);
            this.m_oOrbitalDistanceLabel.Name = "m_oOrbitalDistanceLabel";
            this.m_oOrbitalDistanceLabel.Size = new System.Drawing.Size(114, 13);
            this.m_oOrbitalDistanceLabel.TabIndex = 38;
            this.m_oOrbitalDistanceLabel.Text = "Orbital Distance (k km)";
            // 
            // m_oRemoveAllButton
            // 
            this.m_oRemoveAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oRemoveAllButton.Location = new System.Drawing.Point(172, 303);
            this.m_oRemoveAllButton.Name = "m_oRemoveAllButton";
            this.m_oRemoveAllButton.Size = new System.Drawing.Size(82, 31);
            this.m_oRemoveAllButton.TabIndex = 37;
            this.m_oRemoveAllButton.Text = "Remove All";
            this.m_oRemoveAllButton.UseVisualStyleBackColor = true;
            // 
            // m_oRemoveButton
            // 
            this.m_oRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oRemoveButton.Location = new System.Drawing.Point(84, 303);
            this.m_oRemoveButton.Name = "m_oRemoveButton";
            this.m_oRemoveButton.Size = new System.Drawing.Size(82, 31);
            this.m_oRemoveButton.TabIndex = 36;
            this.m_oRemoveButton.Text = "Remove";
            this.m_oRemoveButton.UseVisualStyleBackColor = true;
            // 
            // m_oAddMoveButton
            // 
            this.m_oAddMoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_oAddMoveButton.Location = new System.Drawing.Point(1, 303);
            this.m_oAddMoveButton.Name = "m_oAddMoveButton";
            this.m_oAddMoveButton.Size = new System.Drawing.Size(78, 31);
            this.m_oAddMoveButton.TabIndex = 35;
            this.m_oAddMoveButton.Text = "Add Move";
            this.m_oAddMoveButton.UseVisualStyleBackColor = true;
            // 
            // m_oPlottedMoveLabel
            // 
            this.m_oPlottedMoveLabel.AutoSize = true;
            this.m_oPlottedMoveLabel.Location = new System.Drawing.Point(514, 14);
            this.m_oPlottedMoveLabel.Name = "m_oPlottedMoveLabel";
            this.m_oPlottedMoveLabel.Size = new System.Drawing.Size(70, 13);
            this.m_oPlottedMoveLabel.TabIndex = 31;
            this.m_oPlottedMoveLabel.Text = "Plotted Move";
            // 
            // m_oActionsAvailableLabel
            // 
            this.m_oActionsAvailableLabel.AutoSize = true;
            this.m_oActionsAvailableLabel.Location = new System.Drawing.Point(261, 14);
            this.m_oActionsAvailableLabel.Name = "m_oActionsAvailableLabel";
            this.m_oActionsAvailableLabel.Size = new System.Drawing.Size(88, 13);
            this.m_oActionsAvailableLabel.TabIndex = 30;
            this.m_oActionsAvailableLabel.Text = "Actions Available";
            // 
            // m_oSystemLocationsLabel
            // 
            this.m_oSystemLocationsLabel.AutoSize = true;
            this.m_oSystemLocationsLabel.Location = new System.Drawing.Point(6, 14);
            this.m_oSystemLocationsLabel.Name = "m_oSystemLocationsLabel";
            this.m_oSystemLocationsLabel.Size = new System.Drawing.Size(136, 13);
            this.m_oSystemLocationsLabel.TabIndex = 29;
            this.m_oSystemLocationsLabel.Text = "System Locations Available";
            // 
            // m_oPlottedMoveListBox
            // 
            this.m_oPlottedMoveListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_oPlottedMoveListBox.FormattingEnabled = true;
            this.m_oPlottedMoveListBox.Location = new System.Drawing.Point(517, 32);
            this.m_oPlottedMoveListBox.Name = "m_oPlottedMoveListBox";
            this.m_oPlottedMoveListBox.Size = new System.Drawing.Size(276, 238);
            this.m_oPlottedMoveListBox.TabIndex = 3;
            // 
            // m_oActionsAvailableListBox
            // 
            this.m_oActionsAvailableListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_oActionsAvailableListBox.FormattingEnabled = true;
            this.m_oActionsAvailableListBox.Location = new System.Drawing.Point(259, 32);
            this.m_oActionsAvailableListBox.Name = "m_oActionsAvailableListBox";
            this.m_oActionsAvailableListBox.Size = new System.Drawing.Size(245, 238);
            this.m_oActionsAvailableListBox.TabIndex = 2;
            // 
            // m_oSystemLocationsListBox
            // 
            this.m_oSystemLocationsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_oSystemLocationsListBox.FormattingEnabled = true;
            this.m_oSystemLocationsListBox.Location = new System.Drawing.Point(4, 32);
            this.m_oSystemLocationsListBox.Name = "m_oSystemLocationsListBox";
            this.m_oSystemLocationsListBox.Size = new System.Drawing.Size(245, 264);
            this.m_oSystemLocationsListBox.TabIndex = 1;
            // 
            // m_oCopyOrdersGroupBox
            // 
            this.m_oCopyOrdersGroupBox.Controls.Add(this.m_oIncCondOrdersCheckBox);
            this.m_oCopyOrdersGroupBox.Controls.Add(this.m_oIncDefaultCheckBox);
            this.m_oCopyOrdersGroupBox.Controls.Add(this.checkBox1);
            this.m_oCopyOrdersGroupBox.Controls.Add(this.m_oCopyOrdersButton);
            this.m_oCopyOrdersGroupBox.Location = new System.Drawing.Point(751, 3);
            this.m_oCopyOrdersGroupBox.MaximumSize = new System.Drawing.Size(219, 68);
            this.m_oCopyOrdersGroupBox.MinimumSize = new System.Drawing.Size(219, 68);
            this.m_oCopyOrdersGroupBox.Name = "m_oCopyOrdersGroupBox";
            this.m_oCopyOrdersGroupBox.Size = new System.Drawing.Size(219, 68);
            this.m_oCopyOrdersGroupBox.TabIndex = 33;
            this.m_oCopyOrdersGroupBox.TabStop = false;
            this.m_oCopyOrdersGroupBox.Text = "Copy Orders to Subordinate Formations";
            // 
            // m_oIncCondOrdersCheckBox
            // 
            this.m_oIncCondOrdersCheckBox.AutoSize = true;
            this.m_oIncCondOrdersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oIncCondOrdersCheckBox.Location = new System.Drawing.Point(132, 40);
            this.m_oIncCondOrdersCheckBox.MaximumSize = new System.Drawing.Size(82, 17);
            this.m_oIncCondOrdersCheckBox.MinimumSize = new System.Drawing.Size(82, 17);
            this.m_oIncCondOrdersCheckBox.Name = "m_oIncCondOrdersCheckBox";
            this.m_oIncCondOrdersCheckBox.Size = new System.Drawing.Size(82, 17);
            this.m_oIncCondOrdersCheckBox.TabIndex = 34;
            this.m_oIncCondOrdersCheckBox.Text = "Inc. Cond.";
            this.m_oIncCondOrdersCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oIncDefaultCheckBox
            // 
            this.m_oIncDefaultCheckBox.AutoSize = true;
            this.m_oIncDefaultCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oIncDefaultCheckBox.Location = new System.Drawing.Point(132, 19);
            this.m_oIncDefaultCheckBox.MaximumSize = new System.Drawing.Size(82, 17);
            this.m_oIncDefaultCheckBox.MinimumSize = new System.Drawing.Size(82, 17);
            this.m_oIncDefaultCheckBox.Name = "m_oIncDefaultCheckBox";
            this.m_oIncDefaultCheckBox.Size = new System.Drawing.Size(82, 17);
            this.m_oIncDefaultCheckBox.TabIndex = 33;
            this.m_oIncDefaultCheckBox.Text = "Inc. Default";
            this.m_oIncDefaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(62, 22);
            this.checkBox1.MaximumSize = new System.Drawing.Size(64, 35);
            this.checkBox1.MinimumSize = new System.Drawing.Size(64, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 35);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Match Speeds";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // m_oCopyOrdersButton
            // 
            this.m_oCopyOrdersButton.Location = new System.Drawing.Point(6, 25);
            this.m_oCopyOrdersButton.Name = "m_oCopyOrdersButton";
            this.m_oCopyOrdersButton.Size = new System.Drawing.Size(50, 27);
            this.m_oCopyOrdersButton.TabIndex = 32;
            this.m_oCopyOrdersButton.Text = "Copy";
            this.m_oCopyOrdersButton.UseVisualStyleBackColor = true;
            // 
            // m_oSystemDisplayOptionsBox
            // 
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oShowAllPopsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oOrderFilteringCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oExcludeSurveyedCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oSurveyLocationsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oWrecksCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oLifePodsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oCometsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oContactsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oWaypointCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oTaskGroupsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oAsteroidsCheckBox);
            this.m_oSystemDisplayOptionsBox.Controls.Add(this.m_oMoonsCheckBox);
            this.m_oSystemDisplayOptionsBox.Location = new System.Drawing.Point(165, 3);
            this.m_oSystemDisplayOptionsBox.MaximumSize = new System.Drawing.Size(585, 68);
            this.m_oSystemDisplayOptionsBox.MinimumSize = new System.Drawing.Size(585, 68);
            this.m_oSystemDisplayOptionsBox.Name = "m_oSystemDisplayOptionsBox";
            this.m_oSystemDisplayOptionsBox.Size = new System.Drawing.Size(585, 68);
            this.m_oSystemDisplayOptionsBox.TabIndex = 33;
            this.m_oSystemDisplayOptionsBox.TabStop = false;
            this.m_oSystemDisplayOptionsBox.Text = "System Location Display Options";
            // 
            // m_oShowAllPopsCheckBox
            // 
            this.m_oShowAllPopsCheckBox.AutoSize = true;
            this.m_oShowAllPopsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oShowAllPopsCheckBox.Location = new System.Drawing.Point(456, 42);
            this.m_oShowAllPopsCheckBox.MaximumSize = new System.Drawing.Size(122, 17);
            this.m_oShowAllPopsCheckBox.MinimumSize = new System.Drawing.Size(122, 17);
            this.m_oShowAllPopsCheckBox.Name = "m_oShowAllPopsCheckBox";
            this.m_oShowAllPopsCheckBox.Size = new System.Drawing.Size(122, 17);
            this.m_oShowAllPopsCheckBox.TabIndex = 20;
            this.m_oShowAllPopsCheckBox.Text = "Show All Pops";
            this.m_oShowAllPopsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oOrderFilteringCheckBox
            // 
            this.m_oOrderFilteringCheckBox.AutoSize = true;
            this.m_oOrderFilteringCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oOrderFilteringCheckBox.Checked = true;
            this.m_oOrderFilteringCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_oOrderFilteringCheckBox.Location = new System.Drawing.Point(456, 19);
            this.m_oOrderFilteringCheckBox.MaximumSize = new System.Drawing.Size(122, 17);
            this.m_oOrderFilteringCheckBox.MinimumSize = new System.Drawing.Size(122, 17);
            this.m_oOrderFilteringCheckBox.Name = "m_oOrderFilteringCheckBox";
            this.m_oOrderFilteringCheckBox.Size = new System.Drawing.Size(122, 17);
            this.m_oOrderFilteringCheckBox.TabIndex = 19;
            this.m_oOrderFilteringCheckBox.Text = "Order Filtering On";
            this.m_oOrderFilteringCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oExcludeSurveyedCheckBox
            // 
            this.m_oExcludeSurveyedCheckBox.AutoSize = true;
            this.m_oExcludeSurveyedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oExcludeSurveyedCheckBox.Location = new System.Drawing.Point(328, 42);
            this.m_oExcludeSurveyedCheckBox.MaximumSize = new System.Drawing.Size(122, 17);
            this.m_oExcludeSurveyedCheckBox.MinimumSize = new System.Drawing.Size(122, 17);
            this.m_oExcludeSurveyedCheckBox.Name = "m_oExcludeSurveyedCheckBox";
            this.m_oExcludeSurveyedCheckBox.Size = new System.Drawing.Size(122, 17);
            this.m_oExcludeSurveyedCheckBox.TabIndex = 18;
            this.m_oExcludeSurveyedCheckBox.Text = "Exclude Surveyed";
            this.m_oExcludeSurveyedCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oSurveyLocationsCheckBox
            // 
            this.m_oSurveyLocationsCheckBox.AutoSize = true;
            this.m_oSurveyLocationsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oSurveyLocationsCheckBox.Location = new System.Drawing.Point(328, 19);
            this.m_oSurveyLocationsCheckBox.MaximumSize = new System.Drawing.Size(122, 17);
            this.m_oSurveyLocationsCheckBox.MinimumSize = new System.Drawing.Size(122, 17);
            this.m_oSurveyLocationsCheckBox.Name = "m_oSurveyLocationsCheckBox";
            this.m_oSurveyLocationsCheckBox.Size = new System.Drawing.Size(122, 17);
            this.m_oSurveyLocationsCheckBox.TabIndex = 17;
            this.m_oSurveyLocationsCheckBox.Text = "Survey Locations";
            this.m_oSurveyLocationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oWrecksCheckBox
            // 
            this.m_oWrecksCheckBox.AutoSize = true;
            this.m_oWrecksCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oWrecksCheckBox.Location = new System.Drawing.Point(250, 42);
            this.m_oWrecksCheckBox.MaximumSize = new System.Drawing.Size(72, 17);
            this.m_oWrecksCheckBox.MinimumSize = new System.Drawing.Size(72, 17);
            this.m_oWrecksCheckBox.Name = "m_oWrecksCheckBox";
            this.m_oWrecksCheckBox.Size = new System.Drawing.Size(72, 17);
            this.m_oWrecksCheckBox.TabIndex = 16;
            this.m_oWrecksCheckBox.Text = "Wrecks";
            this.m_oWrecksCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oLifePodsCheckBox
            // 
            this.m_oLifePodsCheckBox.AutoSize = true;
            this.m_oLifePodsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oLifePodsCheckBox.Location = new System.Drawing.Point(250, 19);
            this.m_oLifePodsCheckBox.MaximumSize = new System.Drawing.Size(72, 17);
            this.m_oLifePodsCheckBox.MinimumSize = new System.Drawing.Size(72, 17);
            this.m_oLifePodsCheckBox.Name = "m_oLifePodsCheckBox";
            this.m_oLifePodsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.m_oLifePodsCheckBox.TabIndex = 15;
            this.m_oLifePodsCheckBox.Text = "Lifepods";
            this.m_oLifePodsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oCometsCheckBox
            // 
            this.m_oCometsCheckBox.AutoSize = true;
            this.m_oCometsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oCometsCheckBox.Location = new System.Drawing.Point(172, 42);
            this.m_oCometsCheckBox.MaximumSize = new System.Drawing.Size(72, 17);
            this.m_oCometsCheckBox.MinimumSize = new System.Drawing.Size(72, 17);
            this.m_oCometsCheckBox.Name = "m_oCometsCheckBox";
            this.m_oCometsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.m_oCometsCheckBox.TabIndex = 14;
            this.m_oCometsCheckBox.Text = "Comets";
            this.m_oCometsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oContactsCheckBox
            // 
            this.m_oContactsCheckBox.AutoSize = true;
            this.m_oContactsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oContactsCheckBox.Location = new System.Drawing.Point(172, 19);
            this.m_oContactsCheckBox.MaximumSize = new System.Drawing.Size(72, 17);
            this.m_oContactsCheckBox.MinimumSize = new System.Drawing.Size(72, 17);
            this.m_oContactsCheckBox.Name = "m_oContactsCheckBox";
            this.m_oContactsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.m_oContactsCheckBox.TabIndex = 13;
            this.m_oContactsCheckBox.Text = "Contacts";
            this.m_oContactsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oWaypointCheckBox
            // 
            this.m_oWaypointCheckBox.AutoSize = true;
            this.m_oWaypointCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oWaypointCheckBox.Location = new System.Drawing.Point(84, 42);
            this.m_oWaypointCheckBox.MaximumSize = new System.Drawing.Size(82, 17);
            this.m_oWaypointCheckBox.MinimumSize = new System.Drawing.Size(82, 17);
            this.m_oWaypointCheckBox.Name = "m_oWaypointCheckBox";
            this.m_oWaypointCheckBox.Size = new System.Drawing.Size(82, 17);
            this.m_oWaypointCheckBox.TabIndex = 12;
            this.m_oWaypointCheckBox.Text = "Waypoints";
            this.m_oWaypointCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oTaskGroupsCheckBox
            // 
            this.m_oTaskGroupsCheckBox.AutoSize = true;
            this.m_oTaskGroupsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oTaskGroupsCheckBox.Location = new System.Drawing.Point(84, 19);
            this.m_oTaskGroupsCheckBox.MaximumSize = new System.Drawing.Size(82, 17);
            this.m_oTaskGroupsCheckBox.MinimumSize = new System.Drawing.Size(82, 17);
            this.m_oTaskGroupsCheckBox.Name = "m_oTaskGroupsCheckBox";
            this.m_oTaskGroupsCheckBox.Size = new System.Drawing.Size(82, 17);
            this.m_oTaskGroupsCheckBox.TabIndex = 11;
            this.m_oTaskGroupsCheckBox.Text = "TaskGroups";
            this.m_oTaskGroupsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oAsteroidsCheckBox
            // 
            this.m_oAsteroidsCheckBox.AutoSize = true;
            this.m_oAsteroidsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oAsteroidsCheckBox.Location = new System.Drawing.Point(6, 42);
            this.m_oAsteroidsCheckBox.MaximumSize = new System.Drawing.Size(72, 17);
            this.m_oAsteroidsCheckBox.MinimumSize = new System.Drawing.Size(72, 17);
            this.m_oAsteroidsCheckBox.Name = "m_oAsteroidsCheckBox";
            this.m_oAsteroidsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.m_oAsteroidsCheckBox.TabIndex = 10;
            this.m_oAsteroidsCheckBox.Text = "Asteroids";
            this.m_oAsteroidsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oMoonsCheckBox
            // 
            this.m_oMoonsCheckBox.AutoSize = true;
            this.m_oMoonsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oMoonsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.m_oMoonsCheckBox.MaximumSize = new System.Drawing.Size(72, 17);
            this.m_oMoonsCheckBox.MinimumSize = new System.Drawing.Size(72, 17);
            this.m_oMoonsCheckBox.Name = "m_oMoonsCheckBox";
            this.m_oMoonsCheckBox.Size = new System.Drawing.Size(72, 17);
            this.m_oMoonsCheckBox.TabIndex = 9;
            this.m_oMoonsCheckBox.Text = "Moons";
            this.m_oMoonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oSpecialOrdersTabPage
            // 
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oTaskforceTrainingGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oSubordinateFormationGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.groupBox7);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oCondOrderAGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oSuperiorFormationGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oCombineTaskgroupGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oCondOrderBGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oDefaultOrderGroupBox);
            this.m_oSpecialOrdersTabPage.Controls.Add(this.m_oProtectThreatAxisGroupBox);
            this.m_oSpecialOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_oSpecialOrdersTabPage.Name = "m_oSpecialOrdersTabPage";
            this.m_oSpecialOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_oSpecialOrdersTabPage.Size = new System.Drawing.Size(983, 429);
            this.m_oSpecialOrdersTabPage.TabIndex = 1;
            this.m_oSpecialOrdersTabPage.Text = "Special Orders";
            this.m_oSpecialOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // m_oTaskforceTrainingGroupBox
            // 
            this.m_oTaskforceTrainingGroupBox.Controls.Add(this.m_oStartTaskforceTrainingButton);
            this.m_oTaskforceTrainingGroupBox.Location = new System.Drawing.Point(6, 345);
            this.m_oTaskforceTrainingGroupBox.Name = "m_oTaskforceTrainingGroupBox";
            this.m_oTaskforceTrainingGroupBox.Size = new System.Drawing.Size(320, 78);
            this.m_oTaskforceTrainingGroupBox.TabIndex = 7;
            this.m_oTaskforceTrainingGroupBox.TabStop = false;
            // 
            // m_oStartTaskforceTrainingButton
            // 
            this.m_oStartTaskforceTrainingButton.Location = new System.Drawing.Point(60, 31);
            this.m_oStartTaskforceTrainingButton.Name = "m_oStartTaskforceTrainingButton";
            this.m_oStartTaskforceTrainingButton.Size = new System.Drawing.Size(200, 25);
            this.m_oStartTaskforceTrainingButton.TabIndex = 0;
            this.m_oStartTaskforceTrainingButton.Text = "Start Task Force Training";
            this.m_oStartTaskforceTrainingButton.UseVisualStyleBackColor = true;
            // 
            // m_oSubordinateFormationGroupBox
            // 
            this.m_oSubordinateFormationGroupBox.Controls.Add(this.m_oSubordinateFormationsListBox);
            this.m_oSubordinateFormationGroupBox.Location = new System.Drawing.Point(6, 181);
            this.m_oSubordinateFormationGroupBox.Name = "m_oSubordinateFormationGroupBox";
            this.m_oSubordinateFormationGroupBox.Size = new System.Drawing.Size(320, 158);
            this.m_oSubordinateFormationGroupBox.TabIndex = 6;
            this.m_oSubordinateFormationGroupBox.TabStop = false;
            this.m_oSubordinateFormationGroupBox.Text = "Subordinate Formations";
            // 
            // m_oSubordinateFormationsListBox
            // 
            this.m_oSubordinateFormationsListBox.FormattingEnabled = true;
            this.m_oSubordinateFormationsListBox.Location = new System.Drawing.Point(6, 19);
            this.m_oSubordinateFormationsListBox.Name = "m_oSubordinateFormationsListBox";
            this.m_oSubordinateFormationsListBox.Size = new System.Drawing.Size(308, 134);
            this.m_oSubordinateFormationsListBox.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.m_oCopyConditionalCheckBox);
            this.groupBox7.Controls.Add(this.m_oCopyDefaultCheckBox);
            this.groupBox7.Controls.Add(this.m_oMatchSpeedsCheckBox);
            this.groupBox7.Controls.Add(this.m_oCopyOrdersToSubordinateButton);
            this.groupBox7.Location = new System.Drawing.Point(659, 232);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(312, 70);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Copy Orders to Subordinate Formation";
            // 
            // m_oCopyConditionalCheckBox
            // 
            this.m_oCopyConditionalCheckBox.AutoSize = true;
            this.m_oCopyConditionalCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oCopyConditionalCheckBox.Location = new System.Drawing.Point(227, 42);
            this.m_oCopyConditionalCheckBox.Name = "m_oCopyConditionalCheckBox";
            this.m_oCopyConditionalCheckBox.Size = new System.Drawing.Size(75, 17);
            this.m_oCopyConditionalCheckBox.TabIndex = 3;
            this.m_oCopyConditionalCheckBox.Text = "Inc. Cond.";
            this.m_oCopyConditionalCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oCopyDefaultCheckBox
            // 
            this.m_oCopyDefaultCheckBox.AutoSize = true;
            this.m_oCopyDefaultCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oCopyDefaultCheckBox.Location = new System.Drawing.Point(221, 19);
            this.m_oCopyDefaultCheckBox.Name = "m_oCopyDefaultCheckBox";
            this.m_oCopyDefaultCheckBox.Size = new System.Drawing.Size(81, 17);
            this.m_oCopyDefaultCheckBox.TabIndex = 2;
            this.m_oCopyDefaultCheckBox.Text = "Inc. Default";
            this.m_oCopyDefaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oMatchSpeedsCheckBox
            // 
            this.m_oMatchSpeedsCheckBox.AutoSize = true;
            this.m_oMatchSpeedsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oMatchSpeedsCheckBox.Location = new System.Drawing.Point(119, 19);
            this.m_oMatchSpeedsCheckBox.Name = "m_oMatchSpeedsCheckBox";
            this.m_oMatchSpeedsCheckBox.Size = new System.Drawing.Size(95, 17);
            this.m_oMatchSpeedsCheckBox.TabIndex = 1;
            this.m_oMatchSpeedsCheckBox.Text = "Match Speeds";
            this.m_oMatchSpeedsCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oCopyOrdersToSubordinateButton
            // 
            this.m_oCopyOrdersToSubordinateButton.Location = new System.Drawing.Point(38, 19);
            this.m_oCopyOrdersToSubordinateButton.Name = "m_oCopyOrdersToSubordinateButton";
            this.m_oCopyOrdersToSubordinateButton.Size = new System.Drawing.Size(75, 23);
            this.m_oCopyOrdersToSubordinateButton.TabIndex = 0;
            this.m_oCopyOrdersToSubordinateButton.Text = "Copy";
            this.m_oCopyOrdersToSubordinateButton.UseVisualStyleBackColor = true;
            // 
            // m_oCondOrderAGroupBox
            // 
            this.m_oCondOrderAGroupBox.Controls.Add(this.m_oCondAOrderLabel);
            this.m_oCondOrderAGroupBox.Controls.Add(this.m_oCondACondLabel);
            this.m_oCondOrderAGroupBox.Controls.Add(this.m_oCondAOrderComboBox);
            this.m_oCondOrderAGroupBox.Controls.Add(this.m_oCondAConditionComboBox);
            this.m_oCondOrderAGroupBox.Location = new System.Drawing.Point(333, 119);
            this.m_oCondOrderAGroupBox.Name = "m_oCondOrderAGroupBox";
            this.m_oCondOrderAGroupBox.Size = new System.Drawing.Size(320, 107);
            this.m_oCondOrderAGroupBox.TabIndex = 2;
            this.m_oCondOrderAGroupBox.TabStop = false;
            this.m_oCondOrderAGroupBox.Text = "Conditional Order A(act on order if condition is met)";
            // 
            // m_oCondAOrderLabel
            // 
            this.m_oCondAOrderLabel.AutoSize = true;
            this.m_oCondAOrderLabel.Location = new System.Drawing.Point(6, 61);
            this.m_oCondAOrderLabel.Name = "m_oCondAOrderLabel";
            this.m_oCondAOrderLabel.Size = new System.Drawing.Size(33, 13);
            this.m_oCondAOrderLabel.TabIndex = 5;
            this.m_oCondAOrderLabel.Text = "Order";
            // 
            // m_oCondACondLabel
            // 
            this.m_oCondACondLabel.AutoSize = true;
            this.m_oCondACondLabel.Location = new System.Drawing.Point(6, 26);
            this.m_oCondACondLabel.Name = "m_oCondACondLabel";
            this.m_oCondACondLabel.Size = new System.Drawing.Size(51, 13);
            this.m_oCondACondLabel.TabIndex = 4;
            this.m_oCondACondLabel.Text = "Condition";
            // 
            // m_oCondAOrderComboBox
            // 
            this.m_oCondAOrderComboBox.FormattingEnabled = true;
            this.m_oCondAOrderComboBox.Location = new System.Drawing.Point(75, 58);
            this.m_oCondAOrderComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oCondAOrderComboBox.Name = "m_oCondAOrderComboBox";
            this.m_oCondAOrderComboBox.Size = new System.Drawing.Size(235, 21);
            this.m_oCondAOrderComboBox.TabIndex = 3;
            // 
            // m_oCondAConditionComboBox
            // 
            this.m_oCondAConditionComboBox.FormattingEnabled = true;
            this.m_oCondAConditionComboBox.Location = new System.Drawing.Point(75, 23);
            this.m_oCondAConditionComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oCondAConditionComboBox.Name = "m_oCondAConditionComboBox";
            this.m_oCondAConditionComboBox.Size = new System.Drawing.Size(235, 21);
            this.m_oCondAConditionComboBox.TabIndex = 2;
            // 
            // m_oSuperiorFormationGroupBox
            // 
            this.m_oSuperiorFormationGroupBox.Controls.Add(this.m_oSaveFormationButton);
            this.m_oSuperiorFormationGroupBox.Controls.Add(this.m_oSuperiorFormationComboBox);
            this.m_oSuperiorFormationGroupBox.Location = new System.Drawing.Point(659, 119);
            this.m_oSuperiorFormationGroupBox.Name = "m_oSuperiorFormationGroupBox";
            this.m_oSuperiorFormationGroupBox.Size = new System.Drawing.Size(312, 107);
            this.m_oSuperiorFormationGroupBox.TabIndex = 4;
            this.m_oSuperiorFormationGroupBox.TabStop = false;
            this.m_oSuperiorFormationGroupBox.Text = "Superior Formation";
            // 
            // m_oSaveFormationButton
            // 
            this.m_oSaveFormationButton.Location = new System.Drawing.Point(119, 54);
            this.m_oSaveFormationButton.Name = "m_oSaveFormationButton";
            this.m_oSaveFormationButton.Size = new System.Drawing.Size(75, 23);
            this.m_oSaveFormationButton.TabIndex = 4;
            this.m_oSaveFormationButton.Text = "Save";
            this.m_oSaveFormationButton.UseVisualStyleBackColor = true;
            // 
            // m_oSuperiorFormationComboBox
            // 
            this.m_oSuperiorFormationComboBox.FormattingEnabled = true;
            this.m_oSuperiorFormationComboBox.Location = new System.Drawing.Point(10, 23);
            this.m_oSuperiorFormationComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oSuperiorFormationComboBox.Name = "m_oSuperiorFormationComboBox";
            this.m_oSuperiorFormationComboBox.Size = new System.Drawing.Size(292, 21);
            this.m_oSuperiorFormationComboBox.TabIndex = 3;
            // 
            // m_oCombineTaskgroupGroupBox
            // 
            this.m_oCombineTaskgroupGroupBox.Controls.Add(this.m_oSaveCombineButton);
            this.m_oCombineTaskgroupGroupBox.Controls.Add(this.m_oCombineTaskgroupsComboBox);
            this.m_oCombineTaskgroupGroupBox.Location = new System.Drawing.Point(659, 6);
            this.m_oCombineTaskgroupGroupBox.Name = "m_oCombineTaskgroupGroupBox";
            this.m_oCombineTaskgroupGroupBox.Size = new System.Drawing.Size(312, 107);
            this.m_oCombineTaskgroupGroupBox.TabIndex = 3;
            this.m_oCombineTaskgroupGroupBox.TabStop = false;
            this.m_oCombineTaskgroupGroupBox.Text = "Combine with other Task Group";
            // 
            // m_oSaveCombineButton
            // 
            this.m_oSaveCombineButton.Location = new System.Drawing.Point(118, 54);
            this.m_oSaveCombineButton.Name = "m_oSaveCombineButton";
            this.m_oSaveCombineButton.Size = new System.Drawing.Size(75, 23);
            this.m_oSaveCombineButton.TabIndex = 3;
            this.m_oSaveCombineButton.Text = "Save";
            this.m_oSaveCombineButton.UseVisualStyleBackColor = true;
            // 
            // m_oCombineTaskgroupsComboBox
            // 
            this.m_oCombineTaskgroupsComboBox.FormattingEnabled = true;
            this.m_oCombineTaskgroupsComboBox.Location = new System.Drawing.Point(10, 23);
            this.m_oCombineTaskgroupsComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oCombineTaskgroupsComboBox.Name = "m_oCombineTaskgroupsComboBox";
            this.m_oCombineTaskgroupsComboBox.Size = new System.Drawing.Size(292, 21);
            this.m_oCombineTaskgroupsComboBox.TabIndex = 2;
            // 
            // m_oCondOrderBGroupBox
            // 
            this.m_oCondOrderBGroupBox.Controls.Add(this.m_oCondBOrderLabel);
            this.m_oCondOrderBGroupBox.Controls.Add(this.m_oCondBCondLabel);
            this.m_oCondOrderBGroupBox.Controls.Add(this.m_oCondBOrderComboBox);
            this.m_oCondOrderBGroupBox.Controls.Add(this.m_oCondBConditionComboBox);
            this.m_oCondOrderBGroupBox.Location = new System.Drawing.Point(333, 232);
            this.m_oCondOrderBGroupBox.Name = "m_oCondOrderBGroupBox";
            this.m_oCondOrderBGroupBox.Size = new System.Drawing.Size(320, 107);
            this.m_oCondOrderBGroupBox.TabIndex = 3;
            this.m_oCondOrderBGroupBox.TabStop = false;
            this.m_oCondOrderBGroupBox.Text = "Conditional Order B(act on order if condition is met)";
            // 
            // m_oCondBOrderLabel
            // 
            this.m_oCondBOrderLabel.AutoSize = true;
            this.m_oCondBOrderLabel.Location = new System.Drawing.Point(6, 61);
            this.m_oCondBOrderLabel.Name = "m_oCondBOrderLabel";
            this.m_oCondBOrderLabel.Size = new System.Drawing.Size(33, 13);
            this.m_oCondBOrderLabel.TabIndex = 7;
            this.m_oCondBOrderLabel.Text = "Order";
            // 
            // m_oCondBCondLabel
            // 
            this.m_oCondBCondLabel.AutoSize = true;
            this.m_oCondBCondLabel.Location = new System.Drawing.Point(6, 24);
            this.m_oCondBCondLabel.Name = "m_oCondBCondLabel";
            this.m_oCondBCondLabel.Size = new System.Drawing.Size(51, 13);
            this.m_oCondBCondLabel.TabIndex = 6;
            this.m_oCondBCondLabel.Text = "Condition";
            // 
            // m_oCondBOrderComboBox
            // 
            this.m_oCondBOrderComboBox.FormattingEnabled = true;
            this.m_oCondBOrderComboBox.Location = new System.Drawing.Point(75, 58);
            this.m_oCondBOrderComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oCondBOrderComboBox.Name = "m_oCondBOrderComboBox";
            this.m_oCondBOrderComboBox.Size = new System.Drawing.Size(235, 21);
            this.m_oCondBOrderComboBox.TabIndex = 5;
            // 
            // m_oCondBConditionComboBox
            // 
            this.m_oCondBConditionComboBox.FormattingEnabled = true;
            this.m_oCondBConditionComboBox.Location = new System.Drawing.Point(75, 23);
            this.m_oCondBConditionComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oCondBConditionComboBox.Name = "m_oCondBConditionComboBox";
            this.m_oCondBConditionComboBox.Size = new System.Drawing.Size(235, 21);
            this.m_oCondBConditionComboBox.TabIndex = 4;
            // 
            // m_oDefaultOrderGroupBox
            // 
            this.m_oDefaultOrderGroupBox.Controls.Add(this.m_oDefaultSecondaryLabel);
            this.m_oDefaultOrderGroupBox.Controls.Add(this.m_oDefaultPrimaryLabel);
            this.m_oDefaultOrderGroupBox.Controls.Add(this.m_oSecondaryDefaultOrdersComboBox);
            this.m_oDefaultOrderGroupBox.Controls.Add(this.m_oPrimaryDefaultOrdersComboBox);
            this.m_oDefaultOrderGroupBox.Location = new System.Drawing.Point(333, 6);
            this.m_oDefaultOrderGroupBox.Name = "m_oDefaultOrderGroupBox";
            this.m_oDefaultOrderGroupBox.Size = new System.Drawing.Size(320, 105);
            this.m_oDefaultOrderGroupBox.TabIndex = 1;
            this.m_oDefaultOrderGroupBox.TabStop = false;
            this.m_oDefaultOrderGroupBox.Text = "Default Orders(if no other orders are set)";
            // 
            // m_oDefaultSecondaryLabel
            // 
            this.m_oDefaultSecondaryLabel.AutoSize = true;
            this.m_oDefaultSecondaryLabel.Location = new System.Drawing.Point(6, 61);
            this.m_oDefaultSecondaryLabel.Name = "m_oDefaultSecondaryLabel";
            this.m_oDefaultSecondaryLabel.Size = new System.Drawing.Size(58, 13);
            this.m_oDefaultSecondaryLabel.TabIndex = 3;
            this.m_oDefaultSecondaryLabel.Text = "Secondary";
            // 
            // m_oDefaultPrimaryLabel
            // 
            this.m_oDefaultPrimaryLabel.AutoSize = true;
            this.m_oDefaultPrimaryLabel.Location = new System.Drawing.Point(6, 26);
            this.m_oDefaultPrimaryLabel.Name = "m_oDefaultPrimaryLabel";
            this.m_oDefaultPrimaryLabel.Size = new System.Drawing.Size(41, 13);
            this.m_oDefaultPrimaryLabel.TabIndex = 2;
            this.m_oDefaultPrimaryLabel.Text = "Primary";
            // 
            // m_oSecondaryDefaultOrdersComboBox
            // 
            this.m_oSecondaryDefaultOrdersComboBox.FormattingEnabled = true;
            this.m_oSecondaryDefaultOrdersComboBox.Location = new System.Drawing.Point(75, 58);
            this.m_oSecondaryDefaultOrdersComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oSecondaryDefaultOrdersComboBox.Name = "m_oSecondaryDefaultOrdersComboBox";
            this.m_oSecondaryDefaultOrdersComboBox.Size = new System.Drawing.Size(235, 21);
            this.m_oSecondaryDefaultOrdersComboBox.TabIndex = 1;
            // 
            // m_oPrimaryDefaultOrdersComboBox
            // 
            this.m_oPrimaryDefaultOrdersComboBox.FormattingEnabled = true;
            this.m_oPrimaryDefaultOrdersComboBox.Location = new System.Drawing.Point(75, 23);
            this.m_oPrimaryDefaultOrdersComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.m_oPrimaryDefaultOrdersComboBox.Name = "m_oPrimaryDefaultOrdersComboBox";
            this.m_oPrimaryDefaultOrdersComboBox.Size = new System.Drawing.Size(235, 21);
            this.m_oPrimaryDefaultOrdersComboBox.TabIndex = 0;
            // 
            // m_oProtectThreatAxisGroupBox
            // 
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.m_oBearingThreatLabel);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.m_oOffsetthreatLabel);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.m_oThreatDistanceLabel);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.m_oTaskGroupThreatLabel);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.m_oThreatLabel);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.comboBox12);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.comboBox11);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.comboBox10);
            this.m_oProtectThreatAxisGroupBox.Controls.Add(this.comboBox9);
            this.m_oProtectThreatAxisGroupBox.Location = new System.Drawing.Point(6, 6);
            this.m_oProtectThreatAxisGroupBox.Name = "m_oProtectThreatAxisGroupBox";
            this.m_oProtectThreatAxisGroupBox.Size = new System.Drawing.Size(320, 169);
            this.m_oProtectThreatAxisGroupBox.TabIndex = 0;
            this.m_oProtectThreatAxisGroupBox.TabStop = false;
            this.m_oProtectThreatAxisGroupBox.Text = "Protect Threat Axis(Acts as Highest Priority default order)";
            // 
            // m_oBearingThreatLabel
            // 
            this.m_oBearingThreatLabel.AutoSize = true;
            this.m_oBearingThreatLabel.Location = new System.Drawing.Point(6, 144);
            this.m_oBearingThreatLabel.Name = "m_oBearingThreatLabel";
            this.m_oBearingThreatLabel.Size = new System.Drawing.Size(43, 13);
            this.m_oBearingThreatLabel.TabIndex = 12;
            this.m_oBearingThreatLabel.Text = "Bearing";
            // 
            // m_oOffsetthreatLabel
            // 
            this.m_oOffsetthreatLabel.AutoSize = true;
            this.m_oOffsetthreatLabel.Location = new System.Drawing.Point(6, 131);
            this.m_oOffsetthreatLabel.Name = "m_oOffsetthreatLabel";
            this.m_oOffsetthreatLabel.Size = new System.Drawing.Size(35, 13);
            this.m_oOffsetthreatLabel.TabIndex = 11;
            this.m_oOffsetthreatLabel.Text = "Offset";
            // 
            // m_oThreatDistanceLabel
            // 
            this.m_oThreatDistanceLabel.AutoSize = true;
            this.m_oThreatDistanceLabel.Location = new System.Drawing.Point(6, 96);
            this.m_oThreatDistanceLabel.Name = "m_oThreatDistanceLabel";
            this.m_oThreatDistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.m_oThreatDistanceLabel.TabIndex = 10;
            this.m_oThreatDistanceLabel.Text = "Distance";
            // 
            // m_oTaskGroupThreatLabel
            // 
            this.m_oTaskGroupThreatLabel.AutoSize = true;
            this.m_oTaskGroupThreatLabel.Location = new System.Drawing.Point(6, 59);
            this.m_oTaskGroupThreatLabel.Name = "m_oTaskGroupThreatLabel";
            this.m_oTaskGroupThreatLabel.Size = new System.Drawing.Size(58, 13);
            this.m_oTaskGroupThreatLabel.TabIndex = 9;
            this.m_oTaskGroupThreatLabel.Text = "Taskgroup";
            // 
            // m_oThreatLabel
            // 
            this.m_oThreatLabel.AutoSize = true;
            this.m_oThreatLabel.Location = new System.Drawing.Point(6, 26);
            this.m_oThreatLabel.Name = "m_oThreatLabel";
            this.m_oThreatLabel.Size = new System.Drawing.Size(38, 13);
            this.m_oThreatLabel.TabIndex = 8;
            this.m_oThreatLabel.Text = "Threat";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(75, 128);
            this.comboBox12.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(235, 21);
            this.comboBox12.TabIndex = 7;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(75, 93);
            this.comboBox11.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(235, 21);
            this.comboBox11.TabIndex = 6;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(75, 58);
            this.comboBox10.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(235, 21);
            this.comboBox10.TabIndex = 5;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(75, 23);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(235, 21);
            this.comboBox9.TabIndex = 4;
            // 
            // m_oOrganizationTabPage
            // 
            this.m_oOrganizationTabPage.Controls.Add(this.m_oShipMoveToTGGroupBox);
            this.m_oOrganizationTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_oOrganizationTabPage.Name = "m_oOrganizationTabPage";
            this.m_oOrganizationTabPage.Size = new System.Drawing.Size(983, 429);
            this.m_oOrganizationTabPage.TabIndex = 5;
            this.m_oOrganizationTabPage.Text = "Organization";
            this.m_oOrganizationTabPage.UseVisualStyleBackColor = true;
            // 
            // m_oShipMoveToTGGroupBox
            // 
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgSelectedTGListBox);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgCurrentTGListBox);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgSMModeButton);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgDivideTG);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgSplitTGButton);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgMoveLeftButton);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgMoveRightButton);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgSelectedTGComboBox);
            this.m_oShipMoveToTGGroupBox.Controls.Add(this.m_oOrgCurrentTGTextBox);
            this.m_oShipMoveToTGGroupBox.Location = new System.Drawing.Point(4, 4);
            this.m_oShipMoveToTGGroupBox.Name = "m_oShipMoveToTGGroupBox";
            this.m_oShipMoveToTGGroupBox.Size = new System.Drawing.Size(573, 422);
            this.m_oShipMoveToTGGroupBox.TabIndex = 0;
            this.m_oShipMoveToTGGroupBox.TabStop = false;
            this.m_oShipMoveToTGGroupBox.Text = "Move Ship Between Task Groups";
            // 
            // m_oOrgSelectedTGListBox
            // 
            this.m_oOrgSelectedTGListBox.FormattingEnabled = true;
            this.m_oOrgSelectedTGListBox.Location = new System.Drawing.Point(269, 45);
            this.m_oOrgSelectedTGListBox.Name = "m_oOrgSelectedTGListBox";
            this.m_oOrgSelectedTGListBox.Size = new System.Drawing.Size(297, 342);
            this.m_oOrgSelectedTGListBox.TabIndex = 8;
            // 
            // m_oOrgCurrentTGListBox
            // 
            this.m_oOrgCurrentTGListBox.FormattingEnabled = true;
            this.m_oOrgCurrentTGListBox.Location = new System.Drawing.Point(6, 45);
            this.m_oOrgCurrentTGListBox.Name = "m_oOrgCurrentTGListBox";
            this.m_oOrgCurrentTGListBox.Size = new System.Drawing.Size(226, 342);
            this.m_oOrgCurrentTGListBox.TabIndex = 7;
            // 
            // m_oOrgSMModeButton
            // 
            this.m_oOrgSMModeButton.Location = new System.Drawing.Point(491, 393);
            this.m_oOrgSMModeButton.Name = "m_oOrgSMModeButton";
            this.m_oOrgSMModeButton.Size = new System.Drawing.Size(75, 23);
            this.m_oOrgSMModeButton.TabIndex = 6;
            this.m_oOrgSMModeButton.Text = "SM Mode";
            this.m_oOrgSMModeButton.UseVisualStyleBackColor = true;
            // 
            // m_oOrgDivideTG
            // 
            this.m_oOrgDivideTG.Location = new System.Drawing.Point(157, 393);
            this.m_oOrgDivideTG.Name = "m_oOrgDivideTG";
            this.m_oOrgDivideTG.Size = new System.Drawing.Size(75, 23);
            this.m_oOrgDivideTG.TabIndex = 5;
            this.m_oOrgDivideTG.Text = "Divide TG";
            this.m_oOrgDivideTG.UseVisualStyleBackColor = true;
            // 
            // m_oOrgSplitTGButton
            // 
            this.m_oOrgSplitTGButton.Location = new System.Drawing.Point(5, 393);
            this.m_oOrgSplitTGButton.Name = "m_oOrgSplitTGButton";
            this.m_oOrgSplitTGButton.Size = new System.Drawing.Size(75, 23);
            this.m_oOrgSplitTGButton.TabIndex = 4;
            this.m_oOrgSplitTGButton.Text = "Split TG";
            this.m_oOrgSplitTGButton.UseVisualStyleBackColor = true;
            // 
            // m_oOrgMoveLeftButton
            // 
            this.m_oOrgMoveLeftButton.Location = new System.Drawing.Point(238, 202);
            this.m_oOrgMoveLeftButton.Name = "m_oOrgMoveLeftButton";
            this.m_oOrgMoveLeftButton.Size = new System.Drawing.Size(25, 25);
            this.m_oOrgMoveLeftButton.TabIndex = 3;
            this.m_oOrgMoveLeftButton.Text = "<-";
            this.m_oOrgMoveLeftButton.UseVisualStyleBackColor = true;
            // 
            // m_oOrgMoveRightButton
            // 
            this.m_oOrgMoveRightButton.Location = new System.Drawing.Point(238, 170);
            this.m_oOrgMoveRightButton.Name = "m_oOrgMoveRightButton";
            this.m_oOrgMoveRightButton.Size = new System.Drawing.Size(25, 25);
            this.m_oOrgMoveRightButton.TabIndex = 2;
            this.m_oOrgMoveRightButton.Text = "->";
            this.m_oOrgMoveRightButton.UseVisualStyleBackColor = true;
            // 
            // m_oOrgSelectedTGComboBox
            // 
            this.m_oOrgSelectedTGComboBox.FormattingEnabled = true;
            this.m_oOrgSelectedTGComboBox.Location = new System.Drawing.Point(269, 19);
            this.m_oOrgSelectedTGComboBox.Name = "m_oOrgSelectedTGComboBox";
            this.m_oOrgSelectedTGComboBox.Size = new System.Drawing.Size(297, 21);
            this.m_oOrgSelectedTGComboBox.TabIndex = 1;
            // 
            // m_oOrgCurrentTGTextBox
            // 
            this.m_oOrgCurrentTGTextBox.Enabled = false;
            this.m_oOrgCurrentTGTextBox.Location = new System.Drawing.Point(6, 19);
            this.m_oOrgCurrentTGTextBox.Name = "m_oOrgCurrentTGTextBox";
            this.m_oOrgCurrentTGTextBox.Size = new System.Drawing.Size(226, 20);
            this.m_oOrgCurrentTGTextBox.TabIndex = 0;
            // 
            // m_oHistoryTabPage
            // 
            this.m_oHistoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_oHistoryTabPage.Name = "m_oHistoryTabPage";
            this.m_oHistoryTabPage.Size = new System.Drawing.Size(983, 429);
            this.m_oHistoryTabPage.TabIndex = 2;
            this.m_oHistoryTabPage.Text = "History / Officers / Misc";
            this.m_oHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // m_oNavalOrgTabPage
            // 
            this.m_oNavalOrgTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_oNavalOrgTabPage.Name = "m_oNavalOrgTabPage";
            this.m_oNavalOrgTabPage.Size = new System.Drawing.Size(983, 429);
            this.m_oNavalOrgTabPage.TabIndex = 3;
            this.m_oNavalOrgTabPage.Text = "Naval Organization";
            this.m_oNavalOrgTabPage.UseVisualStyleBackColor = true;
            // 
            // m_oTaskGroupInfoTabPage
            // 
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oCargoFightersTroopsGroupBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oDefaultCondEscortOrdersGroupBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oOOBGroupBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oOrderTimeDistBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oOfficerBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oInitiativeBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oSurveyBox);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oCenterShowGF);
            this.m_oTaskGroupInfoTabPage.Controls.Add(this.m_oSpeedBox);
            this.m_oTaskGroupInfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_oTaskGroupInfoTabPage.Name = "m_oTaskGroupInfoTabPage";
            this.m_oTaskGroupInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_oTaskGroupInfoTabPage.Size = new System.Drawing.Size(983, 429);
            this.m_oTaskGroupInfoTabPage.TabIndex = 4;
            this.m_oTaskGroupInfoTabPage.Text = "Task Group Info";
            this.m_oTaskGroupInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // m_oCargoFightersTroopsGroupBox
            // 
            this.m_oCargoFightersTroopsGroupBox.Location = new System.Drawing.Point(408, 293);
            this.m_oCargoFightersTroopsGroupBox.MaximumSize = new System.Drawing.Size(348, 125);
            this.m_oCargoFightersTroopsGroupBox.MinimumSize = new System.Drawing.Size(348, 125);
            this.m_oCargoFightersTroopsGroupBox.Name = "m_oCargoFightersTroopsGroupBox";
            this.m_oCargoFightersTroopsGroupBox.Size = new System.Drawing.Size(348, 125);
            this.m_oCargoFightersTroopsGroupBox.TabIndex = 41;
            this.m_oCargoFightersTroopsGroupBox.TabStop = false;
            this.m_oCargoFightersTroopsGroupBox.Text = "Fighters, Ground Units or Cargo carried by TaskGroup";
            // 
            // m_oDefaultCondEscortOrdersGroupBox
            // 
            this.m_oDefaultCondEscortOrdersGroupBox.Location = new System.Drawing.Point(408, 162);
            this.m_oDefaultCondEscortOrdersGroupBox.MaximumSize = new System.Drawing.Size(348, 125);
            this.m_oDefaultCondEscortOrdersGroupBox.MinimumSize = new System.Drawing.Size(348, 125);
            this.m_oDefaultCondEscortOrdersGroupBox.Name = "m_oDefaultCondEscortOrdersGroupBox";
            this.m_oDefaultCondEscortOrdersGroupBox.Size = new System.Drawing.Size(348, 125);
            this.m_oDefaultCondEscortOrdersGroupBox.TabIndex = 40;
            this.m_oDefaultCondEscortOrdersGroupBox.TabStop = false;
            this.m_oDefaultCondEscortOrdersGroupBox.Text = "Default, Conditional or Escort Orders";
            // 
            // m_oOOBGroupBox
            // 
            this.m_oOOBGroupBox.Location = new System.Drawing.Point(408, 6);
            this.m_oOOBGroupBox.MaximumSize = new System.Drawing.Size(348, 250);
            this.m_oOOBGroupBox.MinimumSize = new System.Drawing.Size(348, 150);
            this.m_oOOBGroupBox.Name = "m_oOOBGroupBox";
            this.m_oOOBGroupBox.Size = new System.Drawing.Size(348, 150);
            this.m_oOOBGroupBox.TabIndex = 39;
            this.m_oOOBGroupBox.TabStop = false;
            this.m_oOOBGroupBox.Text = "Order of Battle";
            // 
            // m_oOrderTimeDistBox
            // 
            this.m_oOrderTimeDistBox.Controls.Add(this.m_oAllOrdersRadioButton);
            this.m_oOrderTimeDistBox.Controls.Add(this.m_oCurrentTDRadioButton);
            this.m_oOrderTimeDistBox.Controls.Add(this.m_oTimeDistTextBox);
            this.m_oOrderTimeDistBox.Location = new System.Drawing.Point(15, 219);
            this.m_oOrderTimeDistBox.MaximumSize = new System.Drawing.Size(362, 60);
            this.m_oOrderTimeDistBox.MinimumSize = new System.Drawing.Size(362, 60);
            this.m_oOrderTimeDistBox.Name = "m_oOrderTimeDistBox";
            this.m_oOrderTimeDistBox.Size = new System.Drawing.Size(362, 60);
            this.m_oOrderTimeDistBox.TabIndex = 38;
            this.m_oOrderTimeDistBox.TabStop = false;
            this.m_oOrderTimeDistBox.Text = "Time And Distance";
            // 
            // m_oAllOrdersRadioButton
            // 
            this.m_oAllOrdersRadioButton.AutoSize = true;
            this.m_oAllOrdersRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oAllOrdersRadioButton.Location = new System.Drawing.Point(284, 37);
            this.m_oAllOrdersRadioButton.MaximumSize = new System.Drawing.Size(74, 17);
            this.m_oAllOrdersRadioButton.MinimumSize = new System.Drawing.Size(74, 17);
            this.m_oAllOrdersRadioButton.Name = "m_oAllOrdersRadioButton";
            this.m_oAllOrdersRadioButton.Size = new System.Drawing.Size(74, 17);
            this.m_oAllOrdersRadioButton.TabIndex = 38;
            this.m_oAllOrdersRadioButton.Text = "All Orders";
            this.m_oAllOrdersRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_oCurrentTDRadioButton
            // 
            this.m_oCurrentTDRadioButton.AutoSize = true;
            this.m_oCurrentTDRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oCurrentTDRadioButton.Checked = true;
            this.m_oCurrentTDRadioButton.Location = new System.Drawing.Point(284, 14);
            this.m_oCurrentTDRadioButton.MaximumSize = new System.Drawing.Size(74, 17);
            this.m_oCurrentTDRadioButton.MinimumSize = new System.Drawing.Size(74, 17);
            this.m_oCurrentTDRadioButton.Name = "m_oCurrentTDRadioButton";
            this.m_oCurrentTDRadioButton.Size = new System.Drawing.Size(74, 17);
            this.m_oCurrentTDRadioButton.TabIndex = 37;
            this.m_oCurrentTDRadioButton.TabStop = true;
            this.m_oCurrentTDRadioButton.Text = "Current";
            this.m_oCurrentTDRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_oTimeDistTextBox
            // 
            this.m_oTimeDistTextBox.Enabled = false;
            this.m_oTimeDistTextBox.Location = new System.Drawing.Point(6, 23);
            this.m_oTimeDistTextBox.Name = "m_oTimeDistTextBox";
            this.m_oTimeDistTextBox.Size = new System.Drawing.Size(266, 20);
            this.m_oTimeDistTextBox.TabIndex = 32;
            // 
            // m_oOfficerBox
            // 
            this.m_oOfficerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_oOfficerBox.Controls.Add(this.m_oSeniorOfficerTextBox);
            this.m_oOfficerBox.Location = new System.Drawing.Point(15, 176);
            this.m_oOfficerBox.MaximumSize = new System.Drawing.Size(362, 37);
            this.m_oOfficerBox.MinimumSize = new System.Drawing.Size(362, 37);
            this.m_oOfficerBox.Name = "m_oOfficerBox";
            this.m_oOfficerBox.Size = new System.Drawing.Size(362, 37);
            this.m_oOfficerBox.TabIndex = 37;
            this.m_oOfficerBox.TabStop = false;
            this.m_oOfficerBox.Text = "Senior Officer";
            // 
            // m_oSeniorOfficerTextBox
            // 
            this.m_oSeniorOfficerTextBox.Enabled = false;
            this.m_oSeniorOfficerTextBox.Location = new System.Drawing.Point(6, 14);
            this.m_oSeniorOfficerTextBox.Name = "m_oSeniorOfficerTextBox";
            this.m_oSeniorOfficerTextBox.Size = new System.Drawing.Size(350, 20);
            this.m_oSeniorOfficerTextBox.TabIndex = 32;
            // 
            // m_oInitiativeBox
            // 
            this.m_oInitiativeBox.Controls.Add(this.m_oInitiativeButton);
            this.m_oInitiativeBox.Controls.Add(this.m_oCurrentInitTextBox);
            this.m_oInitiativeBox.Controls.Add(this.m_oCurrentInitLabel);
            this.m_oInitiativeBox.Controls.Add(this.m_oMaxInitLabel);
            this.m_oInitiativeBox.Controls.Add(this.m_oMaxInitTextBox);
            this.m_oInitiativeBox.Location = new System.Drawing.Point(13, 133);
            this.m_oInitiativeBox.MaximumSize = new System.Drawing.Size(200, 37);
            this.m_oInitiativeBox.MinimumSize = new System.Drawing.Size(200, 37);
            this.m_oInitiativeBox.Name = "m_oInitiativeBox";
            this.m_oInitiativeBox.Size = new System.Drawing.Size(200, 37);
            this.m_oInitiativeBox.TabIndex = 36;
            this.m_oInitiativeBox.TabStop = false;
            this.m_oInitiativeBox.Text = "Initiative";
            // 
            // m_oInitiativeButton
            // 
            this.m_oInitiativeButton.Location = new System.Drawing.Point(162, 12);
            this.m_oInitiativeButton.Name = "m_oInitiativeButton";
            this.m_oInitiativeButton.Size = new System.Drawing.Size(32, 20);
            this.m_oInitiativeButton.TabIndex = 32;
            this.m_oInitiativeButton.Text = "Set";
            this.m_oInitiativeButton.UseVisualStyleBackColor = true;
            // 
            // m_oCurrentInitTextBox
            // 
            this.m_oCurrentInitTextBox.Location = new System.Drawing.Point(124, 13);
            this.m_oCurrentInitTextBox.Name = "m_oCurrentInitTextBox";
            this.m_oCurrentInitTextBox.Size = new System.Drawing.Size(32, 20);
            this.m_oCurrentInitTextBox.TabIndex = 34;
            // 
            // m_oCurrentInitLabel
            // 
            this.m_oCurrentInitLabel.AutoSize = true;
            this.m_oCurrentInitLabel.Location = new System.Drawing.Point(80, 16);
            this.m_oCurrentInitLabel.Name = "m_oCurrentInitLabel";
            this.m_oCurrentInitLabel.Size = new System.Drawing.Size(41, 13);
            this.m_oCurrentInitLabel.TabIndex = 33;
            this.m_oCurrentInitLabel.Text = "Current";
            // 
            // m_oMaxInitLabel
            // 
            this.m_oMaxInitLabel.AutoSize = true;
            this.m_oMaxInitLabel.Location = new System.Drawing.Point(6, 16);
            this.m_oMaxInitLabel.Name = "m_oMaxInitLabel";
            this.m_oMaxInitLabel.Size = new System.Drawing.Size(27, 13);
            this.m_oMaxInitLabel.TabIndex = 29;
            this.m_oMaxInitLabel.Text = "Max";
            // 
            // m_oMaxInitTextBox
            // 
            this.m_oMaxInitTextBox.Enabled = false;
            this.m_oMaxInitTextBox.Location = new System.Drawing.Point(42, 13);
            this.m_oMaxInitTextBox.Name = "m_oMaxInitTextBox";
            this.m_oMaxInitTextBox.Size = new System.Drawing.Size(32, 20);
            this.m_oMaxInitTextBox.TabIndex = 32;
            // 
            // m_oSurveyBox
            // 
            this.m_oSurveyBox.Controls.Add(this.m_oGeoTextBox);
            this.m_oSurveyBox.Controls.Add(this.m_oGeoLabel);
            this.m_oSurveyBox.Controls.Add(this.m_oGravLabel);
            this.m_oSurveyBox.Controls.Add(this.m_oGravTextBox);
            this.m_oSurveyBox.Location = new System.Drawing.Point(13, 90);
            this.m_oSurveyBox.MaximumSize = new System.Drawing.Size(156, 37);
            this.m_oSurveyBox.MinimumSize = new System.Drawing.Size(156, 37);
            this.m_oSurveyBox.Name = "m_oSurveyBox";
            this.m_oSurveyBox.Size = new System.Drawing.Size(156, 37);
            this.m_oSurveyBox.TabIndex = 34;
            this.m_oSurveyBox.TabStop = false;
            this.m_oSurveyBox.Text = "Survey Points";
            // 
            // m_oGeoTextBox
            // 
            this.m_oGeoTextBox.Enabled = false;
            this.m_oGeoTextBox.Location = new System.Drawing.Point(113, 13);
            this.m_oGeoTextBox.Name = "m_oGeoTextBox";
            this.m_oGeoTextBox.Size = new System.Drawing.Size(32, 20);
            this.m_oGeoTextBox.TabIndex = 34;
            this.m_oGeoTextBox.Text = "0.0";
            this.m_oGeoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_oGeoLabel
            // 
            this.m_oGeoLabel.AutoSize = true;
            this.m_oGeoLabel.Location = new System.Drawing.Point(80, 16);
            this.m_oGeoLabel.Name = "m_oGeoLabel";
            this.m_oGeoLabel.Size = new System.Drawing.Size(27, 13);
            this.m_oGeoLabel.TabIndex = 33;
            this.m_oGeoLabel.Text = "Geo";
            // 
            // m_oGravLabel
            // 
            this.m_oGravLabel.AutoSize = true;
            this.m_oGravLabel.Location = new System.Drawing.Point(6, 16);
            this.m_oGravLabel.Name = "m_oGravLabel";
            this.m_oGravLabel.Size = new System.Drawing.Size(30, 13);
            this.m_oGravLabel.TabIndex = 29;
            this.m_oGravLabel.Text = "Grav";
            // 
            // m_oGravTextBox
            // 
            this.m_oGravTextBox.Enabled = false;
            this.m_oGravTextBox.Location = new System.Drawing.Point(42, 13);
            this.m_oGravTextBox.Name = "m_oGravTextBox";
            this.m_oGravTextBox.Size = new System.Drawing.Size(32, 20);
            this.m_oGravTextBox.TabIndex = 32;
            this.m_oGravTextBox.Text = "0.0";
            this.m_oGravTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_oCenterShowGF
            // 
            this.m_oCenterShowGF.Controls.Add(this.m_oShowGroundForces);
            this.m_oCenterShowGF.Controls.Add(this.m_oCenterMapCheckBox);
            this.m_oCenterShowGF.Location = new System.Drawing.Point(131, 10);
            this.m_oCenterShowGF.MaximumSize = new System.Drawing.Size(116, 68);
            this.m_oCenterShowGF.MinimumSize = new System.Drawing.Size(116, 68);
            this.m_oCenterShowGF.Name = "m_oCenterShowGF";
            this.m_oCenterShowGF.Size = new System.Drawing.Size(116, 68);
            this.m_oCenterShowGF.TabIndex = 33;
            this.m_oCenterShowGF.TabStop = false;
            // 
            // m_oShowGroundForces
            // 
            this.m_oShowGroundForces.AutoSize = true;
            this.m_oShowGroundForces.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oShowGroundForces.Location = new System.Drawing.Point(6, 42);
            this.m_oShowGroundForces.MaximumSize = new System.Drawing.Size(92, 17);
            this.m_oShowGroundForces.MinimumSize = new System.Drawing.Size(92, 17);
            this.m_oShowGroundForces.Name = "m_oShowGroundForces";
            this.m_oShowGroundForces.Size = new System.Drawing.Size(92, 17);
            this.m_oShowGroundForces.TabIndex = 10;
            this.m_oShowGroundForces.Text = "Show Ground";
            this.m_oShowGroundForces.UseVisualStyleBackColor = true;
            // 
            // m_oCenterMapCheckBox
            // 
            this.m_oCenterMapCheckBox.AutoSize = true;
            this.m_oCenterMapCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_oCenterMapCheckBox.Location = new System.Drawing.Point(6, 19);
            this.m_oCenterMapCheckBox.MaximumSize = new System.Drawing.Size(92, 17);
            this.m_oCenterMapCheckBox.MinimumSize = new System.Drawing.Size(92, 17);
            this.m_oCenterMapCheckBox.Name = "m_oCenterMapCheckBox";
            this.m_oCenterMapCheckBox.Size = new System.Drawing.Size(92, 17);
            this.m_oCenterMapCheckBox.TabIndex = 9;
            this.m_oCenterMapCheckBox.Text = "Center Map";
            this.m_oCenterMapCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_oSpeedBox
            // 
            this.m_oSpeedBox.Controls.Add(this.m_oMaxSpeedButton);
            this.m_oSpeedBox.Controls.Add(this.m_oSetSpeedButton);
            this.m_oSpeedBox.Controls.Add(this.m_oMaxSpeedBox);
            this.m_oSpeedBox.Controls.Add(this.m_oCurSpeedBox);
            this.m_oSpeedBox.Location = new System.Drawing.Point(9, 6);
            this.m_oSpeedBox.MaximumSize = new System.Drawing.Size(116, 78);
            this.m_oSpeedBox.MinimumSize = new System.Drawing.Size(116, 78);
            this.m_oSpeedBox.Name = "m_oSpeedBox";
            this.m_oSpeedBox.Size = new System.Drawing.Size(116, 78);
            this.m_oSpeedBox.TabIndex = 4;
            this.m_oSpeedBox.TabStop = false;
            this.m_oSpeedBox.Text = "Cur / Max Speed";
            // 
            // m_oMaxSpeedButton
            // 
            this.m_oMaxSpeedButton.Location = new System.Drawing.Point(55, 49);
            this.m_oMaxSpeedButton.Name = "m_oMaxSpeedButton";
            this.m_oMaxSpeedButton.Size = new System.Drawing.Size(47, 23);
            this.m_oMaxSpeedButton.TabIndex = 31;
            this.m_oMaxSpeedButton.Text = "Max";
            this.m_oMaxSpeedButton.UseVisualStyleBackColor = true;
            // 
            // m_oSetSpeedButton
            // 
            this.m_oSetSpeedButton.Location = new System.Drawing.Point(55, 22);
            this.m_oSetSpeedButton.Name = "m_oSetSpeedButton";
            this.m_oSetSpeedButton.Size = new System.Drawing.Size(47, 23);
            this.m_oSetSpeedButton.TabIndex = 4;
            this.m_oSetSpeedButton.Text = "Set";
            this.m_oSetSpeedButton.UseVisualStyleBackColor = true;
            // 
            // m_oMaxSpeedBox
            // 
            this.m_oMaxSpeedBox.Enabled = false;
            this.m_oMaxSpeedBox.Location = new System.Drawing.Point(6, 50);
            this.m_oMaxSpeedBox.Name = "m_oMaxSpeedBox";
            this.m_oMaxSpeedBox.Size = new System.Drawing.Size(43, 20);
            this.m_oMaxSpeedBox.TabIndex = 30;
            // 
            // m_oCurSpeedBox
            // 
            this.m_oCurSpeedBox.Location = new System.Drawing.Point(6, 23);
            this.m_oCurSpeedBox.Name = "m_oCurSpeedBox";
            this.m_oCurSpeedBox.Size = new System.Drawing.Size(43, 20);
            this.m_oCurSpeedBox.TabIndex = 29;
            // 
            // m_oButtonBox
            // 
            this.m_oButtonBox.Controls.Add(this.m_oDeleteTGButton);
            this.m_oButtonBox.Controls.Add(this.m_oOOBButton);
            this.m_oButtonBox.Controls.Add(this.m_oRenameTGButton);
            this.m_oButtonBox.Controls.Add(this.m_oAddColonyButton);
            this.m_oButtonBox.Controls.Add(this.m_oSystemMapButton);
            this.m_oButtonBox.Controls.Add(this.m_oNewTGButton);
            this.m_oButtonBox.Location = new System.Drawing.Point(5, 141);
            this.m_oButtonBox.MaximumSize = new System.Drawing.Size(240, 77);
            this.m_oButtonBox.MinimumSize = new System.Drawing.Size(240, 77);
            this.m_oButtonBox.Name = "m_oButtonBox";
            this.m_oButtonBox.Size = new System.Drawing.Size(240, 77);
            this.m_oButtonBox.TabIndex = 33;
            this.m_oButtonBox.TabStop = false;
            // 
            // m_oDeleteTGButton
            // 
            this.m_oDeleteTGButton.Location = new System.Drawing.Point(151, 42);
            this.m_oDeleteTGButton.Name = "m_oDeleteTGButton";
            this.m_oDeleteTGButton.Size = new System.Drawing.Size(65, 28);
            this.m_oDeleteTGButton.TabIndex = 50;
            this.m_oDeleteTGButton.Text = "&Delete TG";
            this.m_oDeleteTGButton.UseVisualStyleBackColor = true;
            // 
            // m_oOOBButton
            // 
            this.m_oOOBButton.Location = new System.Drawing.Point(162, 8);
            this.m_oOOBButton.Name = "m_oOOBButton";
            this.m_oOOBButton.Size = new System.Drawing.Size(60, 28);
            this.m_oOOBButton.TabIndex = 49;
            this.m_oOOBButton.Text = "OOB";
            this.m_oOOBButton.UseVisualStyleBackColor = true;
            // 
            // m_oRenameTGButton
            // 
            this.m_oRenameTGButton.Location = new System.Drawing.Point(70, 43);
            this.m_oRenameTGButton.Name = "m_oRenameTGButton";
            this.m_oRenameTGButton.Size = new System.Drawing.Size(75, 28);
            this.m_oRenameTGButton.TabIndex = 48;
            this.m_oRenameTGButton.Text = "Rename TG";
            this.m_oRenameTGButton.UseVisualStyleBackColor = true;
            // 
            // m_oAddColonyButton
            // 
            this.m_oAddColonyButton.Enabled = false;
            this.m_oAddColonyButton.Location = new System.Drawing.Point(85, 9);
            this.m_oAddColonyButton.Name = "m_oAddColonyButton";
            this.m_oAddColonyButton.Size = new System.Drawing.Size(70, 28);
            this.m_oAddColonyButton.TabIndex = 47;
            this.m_oAddColonyButton.Text = "Add Colony";
            this.m_oAddColonyButton.UseVisualStyleBackColor = true;
            // 
            // m_oSystemMapButton
            // 
            this.m_oSystemMapButton.Location = new System.Drawing.Point(4, 9);
            this.m_oSystemMapButton.Name = "m_oSystemMapButton";
            this.m_oSystemMapButton.Size = new System.Drawing.Size(75, 28);
            this.m_oSystemMapButton.TabIndex = 46;
            this.m_oSystemMapButton.Text = "System Map";
            this.m_oSystemMapButton.UseVisualStyleBackColor = true;
            // 
            // m_oNewTGButton
            // 
            this.m_oNewTGButton.Location = new System.Drawing.Point(4, 43);
            this.m_oNewTGButton.Name = "m_oNewTGButton";
            this.m_oNewTGButton.Size = new System.Drawing.Size(60, 28);
            this.m_oNewTGButton.TabIndex = 45;
            this.m_oNewTGButton.Text = "&New TG";
            this.m_oNewTGButton.UseVisualStyleBackColor = true;
            // 
            // m_oTaskGroupSecondaryGroupBox
            // 
            this.m_oTaskGroupSecondaryGroupBox.Controls.Add(this.m_oTaskgroupSecondaryListBox);
            this.m_oTaskGroupSecondaryGroupBox.Location = new System.Drawing.Point(517, 69);
            this.m_oTaskGroupSecondaryGroupBox.Name = "m_oTaskGroupSecondaryGroupBox";
            this.m_oTaskGroupSecondaryGroupBox.Size = new System.Drawing.Size(275, 201);
            this.m_oTaskGroupSecondaryGroupBox.TabIndex = 45;
            this.m_oTaskGroupSecondaryGroupBox.TabStop = false;
            this.m_oTaskGroupSecondaryGroupBox.Visible = false;
            // 
            // m_oTaskgroupSecondaryListBox
            // 
            this.m_oTaskgroupSecondaryListBox.FormattingEnabled = true;
            this.m_oTaskgroupSecondaryListBox.Location = new System.Drawing.Point(6, 19);
            this.m_oTaskgroupSecondaryListBox.Name = "m_oTaskgroupSecondaryListBox";
            this.m_oTaskgroupSecondaryListBox.Size = new System.Drawing.Size(263, 147);
            this.m_oTaskgroupSecondaryListBox.TabIndex = 0;
            this.m_oTaskgroupSecondaryListBox.Visible = false;
            // 
            // TaskGroup_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.AutoScrollMinSize = new System.Drawing.Size(995, 680);
            this.ClientSize = new System.Drawing.Size(1008, 691);
            this.Controls.Add(this.m_oButtonBox);
            this.Controls.Add(this.m_oTaskGroupTabControl);
            this.Controls.Add(this.m_oGeneralTGDetailsBox);
            this.Controls.Add(this.m_oShipsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TaskGroup_Panel";
            this.Text = "Task Groups";
            this.m_oGeneralTGDetailsBox.ResumeLayout(false);
            this.m_oGeneralTGDetailsBox.PerformLayout();
            this.m_oTaskGroupTabControl.ResumeLayout(false);
            this.m_oTaskGroupOrdersTabPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.m_oTaskGroupOrdersBox.ResumeLayout(false);
            this.m_oTaskGroupOrdersBox.PerformLayout();
            this.m_oCopyOrdersGroupBox.ResumeLayout(false);
            this.m_oCopyOrdersGroupBox.PerformLayout();
            this.m_oSystemDisplayOptionsBox.ResumeLayout(false);
            this.m_oSystemDisplayOptionsBox.PerformLayout();
            this.m_oSpecialOrdersTabPage.ResumeLayout(false);
            this.m_oTaskforceTrainingGroupBox.ResumeLayout(false);
            this.m_oSubordinateFormationGroupBox.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.m_oCondOrderAGroupBox.ResumeLayout(false);
            this.m_oCondOrderAGroupBox.PerformLayout();
            this.m_oSuperiorFormationGroupBox.ResumeLayout(false);
            this.m_oCombineTaskgroupGroupBox.ResumeLayout(false);
            this.m_oCondOrderBGroupBox.ResumeLayout(false);
            this.m_oCondOrderBGroupBox.PerformLayout();
            this.m_oDefaultOrderGroupBox.ResumeLayout(false);
            this.m_oDefaultOrderGroupBox.PerformLayout();
            this.m_oProtectThreatAxisGroupBox.ResumeLayout(false);
            this.m_oProtectThreatAxisGroupBox.PerformLayout();
            this.m_oOrganizationTabPage.ResumeLayout(false);
            this.m_oShipMoveToTGGroupBox.ResumeLayout(false);
            this.m_oShipMoveToTGGroupBox.PerformLayout();
            this.m_oTaskGroupInfoTabPage.ResumeLayout(false);
            this.m_oOrderTimeDistBox.ResumeLayout(false);
            this.m_oOrderTimeDistBox.PerformLayout();
            this.m_oOfficerBox.ResumeLayout(false);
            this.m_oOfficerBox.PerformLayout();
            this.m_oInitiativeBox.ResumeLayout(false);
            this.m_oInitiativeBox.PerformLayout();
            this.m_oSurveyBox.ResumeLayout(false);
            this.m_oSurveyBox.PerformLayout();
            this.m_oCenterShowGF.ResumeLayout(false);
            this.m_oCenterShowGF.PerformLayout();
            this.m_oSpeedBox.ResumeLayout(false);
            this.m_oSpeedBox.PerformLayout();
            this.m_oButtonBox.ResumeLayout(false);
            this.m_oTaskGroupSecondaryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox m_oTaskGroupName;
        private GroupBox m_oShipsBox;
        private GroupBox m_oGeneralTGDetailsBox;
        private Label m_oTaskGroupLabel;
        private ComboBox m_oFactionName;
        private Label m_oFactionLabel;
        private Label m_oLocationLabel;
        private TextBox m_oTGLocation;
        private ComboBox m_oTaskForceName;
        private Label m_oTFLabel;
        private TabControl m_oTaskGroupTabControl;
        private TabPage m_oTaskGroupOrdersTabPage;
        private TabPage m_oSpecialOrdersTabPage;
        private TabPage m_oHistoryTabPage;
        private TabPage m_oNavalOrgTabPage;
        private GroupBox m_oSystemDisplayOptionsBox;
        private CheckBox m_oShowAllPopsCheckBox;
        private CheckBox m_oOrderFilteringCheckBox;
        private CheckBox m_oExcludeSurveyedCheckBox;
        private CheckBox m_oSurveyLocationsCheckBox;
        private CheckBox m_oWrecksCheckBox;
        private CheckBox m_oLifePodsCheckBox;
        private CheckBox m_oCometsCheckBox;
        private CheckBox m_oContactsCheckBox;
        private CheckBox m_oWaypointCheckBox;
        private CheckBox m_oTaskGroupsCheckBox;
        private CheckBox m_oAsteroidsCheckBox;
        private CheckBox m_oMoonsCheckBox;
        private GroupBox m_oCopyOrdersGroupBox;
        private CheckBox m_oIncCondOrdersCheckBox;
        private CheckBox m_oIncDefaultCheckBox;
        private CheckBox checkBox1;
        private Button m_oCopyOrdersButton;
        private GroupBox m_oTaskGroupOrdersBox;
        private ListBox m_oPlottedMoveListBox;
        private ListBox m_oActionsAvailableListBox;
        private ListBox m_oSystemLocationsListBox;
        private Label m_oPlottedMoveLabel;
        private Label m_oActionsAvailableLabel;
        private Label m_oSystemLocationsLabel;
        private Button m_oRemoveAllButton;
        private Button m_oRemoveButton;
        private Button m_oAddMoveButton;
        private TextBox m_oLoadAmtTextBox;
        private TextBox m_oOrbitalDistanceTextBox;
        private Label m_oLoadLimitLabel;
        private Label m_oOrbitalDistanceLabel;
        private TextBox m_oRepeatOrdersTextBox;
        private Button m_oRepeatOrderButton;
        private CheckBox m_oCycleMovesCheckBox;
        private TextBox m_oOrderDelayTextBox;
        private Label m_oOrderDelayLabel;
        private CheckBox m_oAutoRouteCheckBox;
        private GroupBox m_oButtonBox;
        private Button m_oDeleteTGButton;
        private Button m_oOOBButton;
        private Button m_oRenameTGButton;
        private Button m_oAddColonyButton;
        private Button m_oSystemMapButton;
        private Button m_oNewTGButton;
        private TabPage m_oTaskGroupInfoTabPage;
        private GroupBox m_oCargoFightersTroopsGroupBox;
        private GroupBox m_oDefaultCondEscortOrdersGroupBox;
        private GroupBox m_oOOBGroupBox;
        private GroupBox m_oOrderTimeDistBox;
        private RadioButton m_oAllOrdersRadioButton;
        private RadioButton m_oCurrentTDRadioButton;
        private TextBox m_oTimeDistTextBox;
        private GroupBox m_oOfficerBox;
        private TextBox m_oSeniorOfficerTextBox;
        private GroupBox m_oInitiativeBox;
        private Button m_oInitiativeButton;
        private TextBox m_oCurrentInitTextBox;
        private Label m_oCurrentInitLabel;
        private Label m_oMaxInitLabel;
        private TextBox m_oMaxInitTextBox;
        private GroupBox m_oSurveyBox;
        private TextBox m_oGeoTextBox;
        private Label m_oGeoLabel;
        private Label m_oGravLabel;
        private TextBox m_oGravTextBox;
        private GroupBox m_oCenterShowGF;
        private CheckBox m_oShowGroundForces;
        private CheckBox m_oCenterMapCheckBox;
        private GroupBox m_oSpeedBox;
        private Button m_oMaxSpeedButton;
        private Button m_oSetSpeedButton;
        private TextBox m_oMaxSpeedBox;
        private TextBox m_oCurSpeedBox;
        private GroupBox groupBox6;
        private Button m_oReloadParaButton;
        private Button m_oLaunchParaButton;
        private Button m_oRecoverParaButton;
        private GroupBox groupBox5;
        private Button m_oShieldsOnButton;
        private Button m_oShieldsOffButton;
        private GroupBox groupBox4;
        private Button m_oHyperOnButton;
        private Button m_oHyperOffButton;
        private GroupBox groupBox3;
        private Button m_oAssembleButton;
        private Button m_oSaveEscortsButton;
        private Button m_oDetachButton;
        private Button m_oRecallEscortsButton;
        private Button m_oEscortButton;
        private Button m_oDeployEscortsButton;
        private GroupBox groupBox2;
        private Button m_oEqualizeMaintButton;
        private Button m_oEqualizeFuelButton;
        private GroupBox groupBox1;
        private Button m_oMissileLaunchButton;
        private Button m_oNoDefaultButton;
        private Button m_oNoConditionsButton;
        private TabPage m_oOrganizationTabPage;
        private GroupBox m_oShipMoveToTGGroupBox;
        private ListBox m_oOrgSelectedTGListBox;
        private ListBox m_oOrgCurrentTGListBox;
        private Button m_oOrgSMModeButton;
        private Button m_oOrgDivideTG;
        private Button m_oOrgSplitTGButton;
        private Button m_oOrgMoveLeftButton;
        private Button m_oOrgMoveRightButton;
        private ComboBox m_oOrgSelectedTGComboBox;
        private TextBox m_oOrgCurrentTGTextBox;
        private GroupBox m_oCombineTaskgroupGroupBox;
        private GroupBox m_oCondOrderBGroupBox;
        private GroupBox m_oCondOrderAGroupBox;
        private GroupBox m_oDefaultOrderGroupBox;
        private GroupBox m_oProtectThreatAxisGroupBox;
        private GroupBox m_oSuperiorFormationGroupBox;
        private GroupBox groupBox7;
        private GroupBox m_oSubordinateFormationGroupBox;
        private ComboBox m_oCondAOrderComboBox;
        private ComboBox m_oCondAConditionComboBox;
        private ComboBox m_oSuperiorFormationComboBox;
        private ComboBox m_oCombineTaskgroupsComboBox;
        private ComboBox m_oCondBOrderComboBox;
        private ComboBox m_oCondBConditionComboBox;
        private ComboBox m_oSecondaryDefaultOrdersComboBox;
        private ComboBox m_oPrimaryDefaultOrdersComboBox;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox9;
        private GroupBox m_oTaskforceTrainingGroupBox;
        private Button m_oStartTaskforceTrainingButton;
        private Button m_oCopyOrdersToSubordinateButton;
        private Button m_oSaveFormationButton;
        private Button m_oSaveCombineButton;
        private ListBox m_oSubordinateFormationsListBox;
        private CheckBox m_oCopyConditionalCheckBox;
        private CheckBox m_oCopyDefaultCheckBox;
        private CheckBox m_oMatchSpeedsCheckBox;
        private Label m_oCondAOrderLabel;
        private Label m_oCondACondLabel;
        private Label m_oCondBOrderLabel;
        private Label m_oCondBCondLabel;
        private Label m_oDefaultSecondaryLabel;
        private Label m_oDefaultPrimaryLabel;
        private Label m_oBearingThreatLabel;
        private Label m_oOffsetthreatLabel;
        private Label m_oThreatDistanceLabel;
        private Label m_oTaskGroupThreatLabel;
        private Label m_oThreatLabel;
        private GroupBox m_oTaskGroupSecondaryGroupBox;
        private ListBox m_oTaskgroupSecondaryListBox;
    }
}