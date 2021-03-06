﻿namespace PenumbraPhysics.Editor
{
    partial class MainEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditor));
            this.tabControlWelcome = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.welcomeUpdateControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.WelcomeUpdateControlSAMPLE();
            this.tabPagePPManipulation = new System.Windows.Forms.TabPage();
            this.penumbraPhysicsControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.Basic.Samples.PenumbraPhysicsControlSAMPLE();
            this.contextMenuStripPenumbraPhysicsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.penumbraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambientColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxHexColorIO = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripColorTrackBarRed = new PenumbraPhysics.Editor.Controls.Basic.ColorTrackBar.ToolStripColorTrackBar();
            this.toolStripColorTrackBarGreen = new PenumbraPhysics.Editor.Controls.Basic.ColorTrackBar.ToolStripColorTrackBar();
            this.toolStripColorTrackBarBlue = new PenumbraPhysics.Editor.Controls.Basic.ColorTrackBar.ToolStripColorTrackBar();
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowDebugPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowPerformanceGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowAABB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCenterOfMass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowContactPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowControllers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowJoints = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowPolygonPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.showPhysicsShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearPhysicsForces = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemResetAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPagePPPlacement = new System.Windows.Forms.TabPage();
            this.buttonCameraControl = new System.Windows.Forms.Button();
            this.placementControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.Basic.Samples.PlacementControlSAMPLE();
            this.tabPageJustDraw = new System.Windows.Forms.TabPage();
            this.drawControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.DrawControlSAMPLE();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNote = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonSettings = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItemShowFPS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowCursorPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowCameraPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonResetForces = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStripEditorFunctions = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCreateLight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateShadowHull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResetCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditSelectedObject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemListAllLights = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemListAllShadowCaster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemListAllObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSavePositions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveAllObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogBGColor = new System.Windows.Forms.ColorDialog();
            this.tabControlWelcome.SuspendLayout();
            this.tabPageWelcome.SuspendLayout();
            this.tabPagePPManipulation.SuspendLayout();
            this.contextMenuStripPenumbraPhysicsMenu.SuspendLayout();
            this.tabPagePPPlacement.SuspendLayout();
            this.tabPageJustDraw.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStripEditorFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWelcome
            // 
            this.tabControlWelcome.Controls.Add(this.tabPageWelcome);
            this.tabControlWelcome.Controls.Add(this.tabPagePPManipulation);
            this.tabControlWelcome.Controls.Add(this.tabPagePPPlacement);
            this.tabControlWelcome.Controls.Add(this.tabPageJustDraw);
            this.tabControlWelcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlWelcome.Location = new System.Drawing.Point(0, 34);
            this.tabControlWelcome.Name = "tabControlWelcome";
            this.tabControlWelcome.SelectedIndex = 0;
            this.tabControlWelcome.Size = new System.Drawing.Size(649, 444);
            this.tabControlWelcome.TabIndex = 1;
            // 
            // tabPageWelcome
            // 
            this.tabPageWelcome.Controls.Add(this.welcomeUpdateControlSAMPLE1);
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 25);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Size = new System.Drawing.Size(641, 415);
            this.tabPageWelcome.TabIndex = 0;
            this.tabPageWelcome.Text = "Welcome!";
            this.tabPageWelcome.UseVisualStyleBackColor = true;
            // 
            // welcomeUpdateControlSAMPLE1
            // 
            this.welcomeUpdateControlSAMPLE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeUpdateControlSAMPLE1.Location = new System.Drawing.Point(0, 0);
            this.welcomeUpdateControlSAMPLE1.Name = "welcomeUpdateControlSAMPLE1";
            this.welcomeUpdateControlSAMPLE1.Size = new System.Drawing.Size(641, 415);
            this.welcomeUpdateControlSAMPLE1.TabIndex = 0;
            this.welcomeUpdateControlSAMPLE1.Text = "welcomeUpdateControlSAMPLE1";
            this.welcomeUpdateControlSAMPLE1.VisibleChanged += new System.EventHandler(this.welcomeUpdateControlSAMPLE1_VisibleChanged);
            // 
            // tabPagePPManipulation
            // 
            this.tabPagePPManipulation.Controls.Add(this.penumbraPhysicsControlSAMPLE1);
            this.tabPagePPManipulation.Location = new System.Drawing.Point(4, 25);
            this.tabPagePPManipulation.Name = "tabPagePPManipulation";
            this.tabPagePPManipulation.Size = new System.Drawing.Size(641, 415);
            this.tabPagePPManipulation.TabIndex = 1;
            this.tabPagePPManipulation.Text = "Physics Manipulation";
            this.tabPagePPManipulation.UseVisualStyleBackColor = true;
            // 
            // penumbraPhysicsControlSAMPLE1
            // 
            this.penumbraPhysicsControlSAMPLE1.ContextMenuStrip = this.contextMenuStripPenumbraPhysicsMenu;
            this.penumbraPhysicsControlSAMPLE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penumbraPhysicsControlSAMPLE1.Location = new System.Drawing.Point(0, 0);
            this.penumbraPhysicsControlSAMPLE1.Name = "penumbraPhysicsControlSAMPLE1";
            this.penumbraPhysicsControlSAMPLE1.Size = new System.Drawing.Size(641, 415);
            this.penumbraPhysicsControlSAMPLE1.TabIndex = 0;
            this.penumbraPhysicsControlSAMPLE1.Text = "penumbraPhysicsControlSAMPLE1";
            this.penumbraPhysicsControlSAMPLE1.VisibleChanged += new System.EventHandler(this.penumbraPhysicsControlSAMPLE1_VisibleChanged_1);
            // 
            // contextMenuStripPenumbraPhysicsMenu
            // 
            this.contextMenuStripPenumbraPhysicsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPenumbraPhysicsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.toolStripSeparator2,
            this.penumbraToolStripMenuItem,
            this.physicsToolStripMenuItem});
            this.contextMenuStripPenumbraPhysicsMenu.Name = "contextMenuStripPenumbraPhysicsMenu";
            this.contextMenuStripPenumbraPhysicsMenu.Size = new System.Drawing.Size(180, 116);
            this.contextMenuStripPenumbraPhysicsMenu.Text = "PenumbraPhysics Menu";
            this.contextMenuStripPenumbraPhysicsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripPenumbraPhysicsMenu_Opening);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Enabled = false;
            this.editorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.editorToolStripMenuItem.Text = ".: Editor :.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // penumbraToolStripMenuItem
            // 
            this.penumbraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ambientColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.penumbraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("penumbraToolStripMenuItem.Image")));
            this.penumbraToolStripMenuItem.Name = "penumbraToolStripMenuItem";
            this.penumbraToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.penumbraToolStripMenuItem.Text = "Penumbra";
            // 
            // ambientColorToolStripMenuItem
            // 
            this.ambientColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxHexColorIO,
            this.toolStripColorTrackBarRed,
            this.toolStripColorTrackBarGreen,
            this.toolStripColorTrackBarBlue});
            this.ambientColorToolStripMenuItem.Name = "ambientColorToolStripMenuItem";
            this.ambientColorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.ambientColorToolStripMenuItem.Text = "Ambient Color";
            this.ambientColorToolStripMenuItem.DropDownOpening += new System.EventHandler(this.ambientColorToolStripMenuItem_DropDownOpening);
            // 
            // toolStripTextBoxHexColorIO
            // 
            this.toolStripTextBoxHexColorIO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBoxHexColorIO.Name = "toolStripTextBoxHexColorIO";
            this.toolStripTextBoxHexColorIO.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxHexColorIO.Text = "#HexColor";
            this.toolStripTextBoxHexColorIO.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBoxHexColorIO.TextChanged += new System.EventHandler(this.toolStripTextBoxHexColorIO_TextChanged);
            // 
            // toolStripColorTrackBarRed
            // 
            this.toolStripColorTrackBarRed.BackColor = System.Drawing.Color.White;
            this.toolStripColorTrackBarRed.Name = "toolStripColorTrackBarRed";
            this.toolStripColorTrackBarRed.Size = new System.Drawing.Size(100, 20);
            this.toolStripColorTrackBarRed.ValueChanged += new System.EventHandler(this.toolStripColorTrackBarRed_ValueChanged);
            // 
            // toolStripColorTrackBarGreen
            // 
            this.toolStripColorTrackBarGreen.BackColor = System.Drawing.Color.White;
            this.toolStripColorTrackBarGreen.Name = "toolStripColorTrackBarGreen";
            this.toolStripColorTrackBarGreen.Size = new System.Drawing.Size(100, 20);
            this.toolStripColorTrackBarGreen.ValueChanged += new System.EventHandler(this.toolStripColorTrackBarGreen_ValueChanged);
            // 
            // toolStripColorTrackBarBlue
            // 
            this.toolStripColorTrackBarBlue.BackColor = System.Drawing.Color.White;
            this.toolStripColorTrackBarBlue.Name = "toolStripColorTrackBarBlue";
            this.toolStripColorTrackBarBlue.Size = new System.Drawing.Size(100, 20);
            this.toolStripColorTrackBarBlue.ValueChanged += new System.EventHandler(this.toolStripColorTrackBarBlue_ValueChanged);
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugViewToolStripMenuItem,
            this.toolStripMenuItemClearPhysicsForces,
            this.toolStripSeparator1,
            this.ToolStripMenuItemResetAll});
            this.physicsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("physicsToolStripMenuItem.Image")));
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.physicsToolStripMenuItem.Text = "Physics";
            // 
            // debugViewToolStripMenuItem
            // 
            this.debugViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowDebugPanel,
            this.toolStripMenuItemShowPerformanceGraph,
            this.toolStripMenuItemShowAABB,
            this.toolStripMenuItemCenterOfMass,
            this.toolStripMenuItemShowContactPoints,
            this.toolStripMenuItemShowControllers,
            this.toolStripMenuItemShowJoints,
            this.toolStripMenuItemShowPolygonPoints,
            this.showPhysicsShapesToolStripMenuItem});
            this.debugViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("debugViewToolStripMenuItem.Image")));
            this.debugViewToolStripMenuItem.Name = "debugViewToolStripMenuItem";
            this.debugViewToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.debugViewToolStripMenuItem.Text = "DebugView";
            // 
            // toolStripMenuItemShowDebugPanel
            // 
            this.toolStripMenuItemShowDebugPanel.CheckOnClick = true;
            this.toolStripMenuItemShowDebugPanel.Name = "toolStripMenuItemShowDebugPanel";
            this.toolStripMenuItemShowDebugPanel.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowDebugPanel.Text = "Show Debug Panel";
            this.toolStripMenuItemShowDebugPanel.Click += new System.EventHandler(this.toolStripMenuItemShowDebugPanel_Click);
            // 
            // toolStripMenuItemShowPerformanceGraph
            // 
            this.toolStripMenuItemShowPerformanceGraph.CheckOnClick = true;
            this.toolStripMenuItemShowPerformanceGraph.Name = "toolStripMenuItemShowPerformanceGraph";
            this.toolStripMenuItemShowPerformanceGraph.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowPerformanceGraph.Text = "Show Performance Graph";
            this.toolStripMenuItemShowPerformanceGraph.Click += new System.EventHandler(this.toolStripMenuItemShowPerformanceGraph_Click);
            // 
            // toolStripMenuItemShowAABB
            // 
            this.toolStripMenuItemShowAABB.CheckOnClick = true;
            this.toolStripMenuItemShowAABB.Name = "toolStripMenuItemShowAABB";
            this.toolStripMenuItemShowAABB.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowAABB.Text = "Show AABB";
            this.toolStripMenuItemShowAABB.Click += new System.EventHandler(this.toolStripMenuItemShowAABB_Click);
            // 
            // toolStripMenuItemCenterOfMass
            // 
            this.toolStripMenuItemCenterOfMass.CheckOnClick = true;
            this.toolStripMenuItemCenterOfMass.Name = "toolStripMenuItemCenterOfMass";
            this.toolStripMenuItemCenterOfMass.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemCenterOfMass.Text = "Show Center of Mass";
            this.toolStripMenuItemCenterOfMass.Click += new System.EventHandler(this.toolStripMenuItemCenterOfMass_Click);
            // 
            // toolStripMenuItemShowContactPoints
            // 
            this.toolStripMenuItemShowContactPoints.CheckOnClick = true;
            this.toolStripMenuItemShowContactPoints.Name = "toolStripMenuItemShowContactPoints";
            this.toolStripMenuItemShowContactPoints.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowContactPoints.Text = "Show Contact Points";
            this.toolStripMenuItemShowContactPoints.Click += new System.EventHandler(this.toolStripMenuItemShowContactPoints_Click);
            // 
            // toolStripMenuItemShowControllers
            // 
            this.toolStripMenuItemShowControllers.CheckOnClick = true;
            this.toolStripMenuItemShowControllers.Name = "toolStripMenuItemShowControllers";
            this.toolStripMenuItemShowControllers.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowControllers.Text = "Show Controllers";
            this.toolStripMenuItemShowControllers.Click += new System.EventHandler(this.toolStripMenuItemShowControllers_Click);
            // 
            // toolStripMenuItemShowJoints
            // 
            this.toolStripMenuItemShowJoints.CheckOnClick = true;
            this.toolStripMenuItemShowJoints.Name = "toolStripMenuItemShowJoints";
            this.toolStripMenuItemShowJoints.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowJoints.Text = "Show Joints";
            this.toolStripMenuItemShowJoints.Click += new System.EventHandler(this.toolStripMenuItemShowJoints_Click);
            // 
            // toolStripMenuItemShowPolygonPoints
            // 
            this.toolStripMenuItemShowPolygonPoints.CheckOnClick = true;
            this.toolStripMenuItemShowPolygonPoints.Name = "toolStripMenuItemShowPolygonPoints";
            this.toolStripMenuItemShowPolygonPoints.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItemShowPolygonPoints.Text = "Show Polygon Points";
            this.toolStripMenuItemShowPolygonPoints.Click += new System.EventHandler(this.toolStripMenuItemShowPolygonPoints_Click);
            // 
            // showPhysicsShapesToolStripMenuItem
            // 
            this.showPhysicsShapesToolStripMenuItem.CheckOnClick = true;
            this.showPhysicsShapesToolStripMenuItem.Name = "showPhysicsShapesToolStripMenuItem";
            this.showPhysicsShapesToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.showPhysicsShapesToolStripMenuItem.Text = "Show Physics Shapes";
            this.showPhysicsShapesToolStripMenuItem.Click += new System.EventHandler(this.showPhysicsShapesToolStripMenuItem_Click);
            // 
            // toolStripMenuItemClearPhysicsForces
            // 
            this.toolStripMenuItemClearPhysicsForces.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemClearPhysicsForces.Image")));
            this.toolStripMenuItemClearPhysicsForces.Name = "toolStripMenuItemClearPhysicsForces";
            this.toolStripMenuItemClearPhysicsForces.Size = new System.Drawing.Size(164, 26);
            this.toolStripMenuItemClearPhysicsForces.Text = "Clear Forces";
            this.toolStripMenuItemClearPhysicsForces.Click += new System.EventHandler(this.toolStripMenuItemClearPhysicsForces_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // ToolStripMenuItemResetAll
            // 
            this.ToolStripMenuItemResetAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemResetAll.Image")));
            this.ToolStripMenuItemResetAll.Name = "ToolStripMenuItemResetAll";
            this.ToolStripMenuItemResetAll.Size = new System.Drawing.Size(164, 26);
            this.ToolStripMenuItemResetAll.Text = "Reset All";
            this.ToolStripMenuItemResetAll.Click += new System.EventHandler(this.ToolStripMenuItemResetAll_Click);
            // 
            // tabPagePPPlacement
            // 
            this.tabPagePPPlacement.Controls.Add(this.buttonCameraControl);
            this.tabPagePPPlacement.Controls.Add(this.placementControlSAMPLE1);
            this.tabPagePPPlacement.Location = new System.Drawing.Point(4, 25);
            this.tabPagePPPlacement.Name = "tabPagePPPlacement";
            this.tabPagePPPlacement.Size = new System.Drawing.Size(641, 415);
            this.tabPagePPPlacement.TabIndex = 2;
            this.tabPagePPPlacement.Text = "Editor Environment";
            this.tabPagePPPlacement.UseVisualStyleBackColor = true;
            // 
            // buttonCameraControl
            // 
            this.buttonCameraControl.Image = ((System.Drawing.Image)(resources.GetObject("buttonCameraControl.Image")));
            this.buttonCameraControl.Location = new System.Drawing.Point(511, 370);
            this.buttonCameraControl.Name = "buttonCameraControl";
            this.buttonCameraControl.Size = new System.Drawing.Size(127, 42);
            this.buttonCameraControl.TabIndex = 2;
            this.buttonCameraControl.Text = "Move Camera";
            this.buttonCameraControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCameraControl.UseVisualStyleBackColor = true;
            this.buttonCameraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCameraControl_MouseDown);
            this.buttonCameraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCameraControl_MouseMove);
            this.buttonCameraControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCameraControl_MouseUp);
            // 
            // placementControlSAMPLE1
            // 
            this.placementControlSAMPLE1.ContextMenuStrip = this.contextMenuStripPenumbraPhysicsMenu;
            this.placementControlSAMPLE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placementControlSAMPLE1.Location = new System.Drawing.Point(0, 0);
            this.placementControlSAMPLE1.Name = "placementControlSAMPLE1";
            this.placementControlSAMPLE1.Padding = new System.Windows.Forms.Padding(3);
            this.placementControlSAMPLE1.Size = new System.Drawing.Size(641, 415);
            this.placementControlSAMPLE1.TabIndex = 0;
            this.placementControlSAMPLE1.Text = "placementControlSAMPLE1";
            this.placementControlSAMPLE1.VisibleChanged += new System.EventHandler(this.placementControlSAMPLE1_VisibleChanged_1);
            // 
            // tabPageJustDraw
            // 
            this.tabPageJustDraw.Controls.Add(this.drawControlSAMPLE1);
            this.tabPageJustDraw.Location = new System.Drawing.Point(4, 25);
            this.tabPageJustDraw.Name = "tabPageJustDraw";
            this.tabPageJustDraw.Size = new System.Drawing.Size(641, 415);
            this.tabPageJustDraw.TabIndex = 3;
            this.tabPageJustDraw.Text = "Just.Draw.";
            this.tabPageJustDraw.UseVisualStyleBackColor = true;
            // 
            // drawControlSAMPLE1
            // 
            this.drawControlSAMPLE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawControlSAMPLE1.Location = new System.Drawing.Point(0, 0);
            this.drawControlSAMPLE1.Name = "drawControlSAMPLE1";
            this.drawControlSAMPLE1.Size = new System.Drawing.Size(641, 415);
            this.drawControlSAMPLE1.TabIndex = 0;
            this.drawControlSAMPLE1.Text = "drawControlSAMPLE1";
            this.drawControlSAMPLE1.VisibleChanged += new System.EventHandler(this.drawControlSAMPLE1_VisibleChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNote,
            this.toolStripStatusLabelSpacer,
            this.toolStripSplitButtonSettings});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(649, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelNote
            // 
            this.toolStripStatusLabelNote.Name = "toolStripStatusLabelNote";
            this.toolStripStatusLabelNote.Size = new System.Drawing.Size(42, 21);
            this.toolStripStatusLabelNote.Text = "Note";
            // 
            // toolStripStatusLabelSpacer
            // 
            this.toolStripStatusLabelSpacer.Name = "toolStripStatusLabelSpacer";
            this.toolStripStatusLabelSpacer.Size = new System.Drawing.Size(499, 21);
            this.toolStripStatusLabelSpacer.Spring = true;
            // 
            // toolStripSplitButtonSettings
            // 
            this.toolStripSplitButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowFPS,
            this.toolStripMenuItemShowCursorPosition,
            this.toolStripMenuItemShowCameraPosition});
            this.toolStripSplitButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonSettings.Image")));
            this.toolStripSplitButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonSettings.Name = "toolStripSplitButtonSettings";
            this.toolStripSplitButtonSettings.Size = new System.Drawing.Size(93, 24);
            this.toolStripSplitButtonSettings.Text = "Debug";
            this.toolStripSplitButtonSettings.Click += new System.EventHandler(this.toolStripSplitButtonSettings_Click);
            // 
            // toolStripMenuItemShowFPS
            // 
            this.toolStripMenuItemShowFPS.Checked = true;
            this.toolStripMenuItemShowFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowFPS.Name = "toolStripMenuItemShowFPS";
            this.toolStripMenuItemShowFPS.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItemShowFPS.Text = "Show FPS";
            this.toolStripMenuItemShowFPS.Click += new System.EventHandler(this.toolStripMenuItemShowFPS_Click);
            // 
            // toolStripMenuItemShowCursorPosition
            // 
            this.toolStripMenuItemShowCursorPosition.Name = "toolStripMenuItemShowCursorPosition";
            this.toolStripMenuItemShowCursorPosition.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItemShowCursorPosition.Text = "Show Cursor Position";
            this.toolStripMenuItemShowCursorPosition.Click += new System.EventHandler(this.toolStripMenuItemShowCursorPosition_Click);
            // 
            // toolStripMenuItemShowCameraPosition
            // 
            this.toolStripMenuItemShowCameraPosition.Name = "toolStripMenuItemShowCameraPosition";
            this.toolStripMenuItemShowCameraPosition.Size = new System.Drawing.Size(231, 26);
            this.toolStripMenuItemShowCameraPosition.Text = "Show Camera Position";
            this.toolStripMenuItemShowCameraPosition.Click += new System.EventHandler(this.toolStripMenuItemShowCameraPosition_Click);
            // 
            // buttonResetForces
            // 
            this.buttonResetForces.Location = new System.Drawing.Point(0, 0);
            this.buttonResetForces.Name = "buttonResetForces";
            this.buttonResetForces.Size = new System.Drawing.Size(75, 23);
            this.buttonResetForces.TabIndex = 0;
            this.buttonResetForces.Text = "Reset Forces";
            this.buttonResetForces.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStripEditorFunctions
            // 
            this.menuStripEditorFunctions.Enabled = false;
            this.menuStripEditorFunctions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEditorFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCreateLight,
            this.toolStripMenuItemCreateShadowHull,
            this.toolStripMenuItemResetCamera,
            this.toolStripMenuItemObjects});
            this.menuStripEditorFunctions.Location = new System.Drawing.Point(0, 0);
            this.menuStripEditorFunctions.Name = "menuStripEditorFunctions";
            this.menuStripEditorFunctions.Size = new System.Drawing.Size(649, 28);
            this.menuStripEditorFunctions.TabIndex = 3;
            this.menuStripEditorFunctions.Text = "menuStrip1";
            // 
            // toolStripMenuItemCreateLight
            // 
            this.toolStripMenuItemCreateLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCreateLight.Image")));
            this.toolStripMenuItemCreateLight.Name = "toolStripMenuItemCreateLight";
            this.toolStripMenuItemCreateLight.Size = new System.Drawing.Size(121, 24);
            this.toolStripMenuItemCreateLight.Text = "Create Light";
            this.toolStripMenuItemCreateLight.Click += new System.EventHandler(this.toolStripMenuItemCreateLight_Click);
            // 
            // toolStripMenuItemCreateShadowHull
            // 
            this.toolStripMenuItemCreateShadowHull.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCreateShadowHull.Image")));
            this.toolStripMenuItemCreateShadowHull.Name = "toolStripMenuItemCreateShadowHull";
            this.toolStripMenuItemCreateShadowHull.Size = new System.Drawing.Size(186, 24);
            this.toolStripMenuItemCreateShadowHull.Text = "Create Shadow Caster";
            this.toolStripMenuItemCreateShadowHull.Click += new System.EventHandler(this.toolStripMenuItemCreateShadowHull_Click);
            // 
            // toolStripMenuItemResetCamera
            // 
            this.toolStripMenuItemResetCamera.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemResetCamera.Image")));
            this.toolStripMenuItemResetCamera.Name = "toolStripMenuItemResetCamera";
            this.toolStripMenuItemResetCamera.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItemResetCamera.Text = "Reset Camera";
            this.toolStripMenuItemResetCamera.Click += new System.EventHandler(this.toolStripMenuItemResetCamera_Click);
            // 
            // toolStripMenuItemObjects
            // 
            this.toolStripMenuItemObjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditSelectedObject,
            this.toolStripSeparator3,
            this.toolStripMenuItemListAllLights,
            this.toolStripMenuItemListAllShadowCaster,
            this.toolStripMenuItemListAllObjects,
            this.toolStripSeparator4,
            this.toolStripMenuItemSavePositions,
            this.toolStripMenuItemRemoveAllObjects});
            this.toolStripMenuItemObjects.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemObjects.Image")));
            this.toolStripMenuItemObjects.Name = "toolStripMenuItemObjects";
            this.toolStripMenuItemObjects.Size = new System.Drawing.Size(91, 24);
            this.toolStripMenuItemObjects.Text = "Objects";
            // 
            // toolStripMenuItemEditSelectedObject
            // 
            this.toolStripMenuItemEditSelectedObject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditSelectedObject.Image")));
            this.toolStripMenuItemEditSelectedObject.Name = "toolStripMenuItemEditSelectedObject";
            this.toolStripMenuItemEditSelectedObject.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItemEditSelectedObject.Text = "Edit Selected Object";
            this.toolStripMenuItemEditSelectedObject.Click += new System.EventHandler(this.toolStripMenuItemEditSelectedObject_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // toolStripMenuItemListAllLights
            // 
            this.toolStripMenuItemListAllLights.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemListAllLights.Image")));
            this.toolStripMenuItemListAllLights.Name = "toolStripMenuItemListAllLights";
            this.toolStripMenuItemListAllLights.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItemListAllLights.Text = "List all Lights";
            this.toolStripMenuItemListAllLights.Click += new System.EventHandler(this.toolStripMenuItemListAllLights_Click);
            // 
            // toolStripMenuItemListAllShadowCaster
            // 
            this.toolStripMenuItemListAllShadowCaster.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemListAllShadowCaster.Image")));
            this.toolStripMenuItemListAllShadowCaster.Name = "toolStripMenuItemListAllShadowCaster";
            this.toolStripMenuItemListAllShadowCaster.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItemListAllShadowCaster.Text = "List all Shadow Caster";
            this.toolStripMenuItemListAllShadowCaster.Click += new System.EventHandler(this.toolStripMenuItemListAllShadowCaster_Click);
            // 
            // toolStripMenuItemListAllObjects
            // 
            this.toolStripMenuItemListAllObjects.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemListAllObjects.Image")));
            this.toolStripMenuItemListAllObjects.Name = "toolStripMenuItemListAllObjects";
            this.toolStripMenuItemListAllObjects.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItemListAllObjects.Text = "List all Objects";
            this.toolStripMenuItemListAllObjects.Click += new System.EventHandler(this.toolStripMenuItemListAllObjects_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(225, 6);
            // 
            // toolStripMenuItemSavePositions
            // 
            this.toolStripMenuItemSavePositions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemSavePositions.Image")));
            this.toolStripMenuItemSavePositions.Name = "toolStripMenuItemSavePositions";
            this.toolStripMenuItemSavePositions.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItemSavePositions.Text = "Save all Positions";
            this.toolStripMenuItemSavePositions.Click += new System.EventHandler(this.toolStripMenuItemSavePositions_Click);
            // 
            // toolStripMenuItemRemoveAllObjects
            // 
            this.toolStripMenuItemRemoveAllObjects.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemRemoveAllObjects.Image")));
            this.toolStripMenuItemRemoveAllObjects.Name = "toolStripMenuItemRemoveAllObjects";
            this.toolStripMenuItemRemoveAllObjects.Size = new System.Drawing.Size(228, 26);
            this.toolStripMenuItemRemoveAllObjects.Text = "Remove all Objects";
            this.toolStripMenuItemRemoveAllObjects.Click += new System.EventHandler(this.toolStripMenuItemRemoveAllObjects_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // colorDialogBGColor
            // 
            this.colorDialogBGColor.AnyColor = true;
            this.colorDialogBGColor.Color = System.Drawing.Color.CornflowerBlue;
            this.colorDialogBGColor.FullOpen = true;
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(649, 504);
            this.Controls.Add(this.tabControlWelcome);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripEditorFunctions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripEditorFunctions;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PenumbraPhysics.Editor";
            this.tabControlWelcome.ResumeLayout(false);
            this.tabPageWelcome.ResumeLayout(false);
            this.tabPagePPManipulation.ResumeLayout(false);
            this.contextMenuStripPenumbraPhysicsMenu.ResumeLayout(false);
            this.tabPagePPPlacement.ResumeLayout(false);
            this.tabPageJustDraw.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStripEditorFunctions.ResumeLayout(false);
            this.menuStripEditorFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlWelcome;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabPagePPManipulation;
        private System.Windows.Forms.TabPage tabPagePPPlacement;
        private System.Windows.Forms.TabPage tabPageJustDraw;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowFPS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowCursorPosition;
        private System.Windows.Forms.Button buttonResetForces;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPenumbraPhysicsMenu;
        private System.Windows.Forms.ToolStripMenuItem physicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemResetAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearPhysicsForces;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Controls.Basic.Samples.PenumbraPhysicsControlSAMPLE penumbraPhysicsControlSAMPLE1;
        private Controls.Basic.Samples.PlacementControlSAMPLE placementControlSAMPLE1;
        private System.Windows.Forms.MenuStrip menuStripEditorFunctions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateLight;
        private System.Windows.Forms.Button buttonCameraControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemResetCamera;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowCameraPosition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpacer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNote;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateShadowHull;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemObjects;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveAllObjects;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemListAllObjects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemListAllLights;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemListAllShadowCaster;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditSelectedObject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem penumbraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambientColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxHexColorIO;
        private Controls.Basic.ColorTrackBar.ToolStripColorTrackBar toolStripColorTrackBarRed;
        private Controls.Basic.ColorTrackBar.ToolStripColorTrackBar toolStripColorTrackBarGreen;
        private Controls.Basic.ColorTrackBar.ToolStripColorTrackBar toolStripColorTrackBarBlue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSavePositions;
        private System.Windows.Forms.ToolStripMenuItem debugViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPhysicsShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowPolygonPoints;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowJoints;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowControllers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowContactPoints;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCenterOfMass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowAABB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowPerformanceGraph;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowDebugPanel;
        private Controls.DrawControlSAMPLE drawControlSAMPLE1;
        private Controls.WelcomeUpdateControlSAMPLE welcomeUpdateControlSAMPLE1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogBGColor;
    }
}