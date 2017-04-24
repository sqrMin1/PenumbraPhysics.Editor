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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.welcomeUpdateControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.WelcomeUpdateControlSAMPLE();
            this.tabPagePPManipulation = new System.Windows.Forms.TabPage();
            this.buttonCloseManipulationSampleMessage = new System.Windows.Forms.Button();
            this.richTextBoxManipulationSample = new System.Windows.Forms.RichTextBox();
            this.penumbraPhysicsControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.Basic.PenumbraPhysicsControlSAMPLE();
            this.contextMenuStripPenumbraPhysicsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearPhysicsForces = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemResetAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPagePPPlacement = new System.Windows.Forms.TabPage();
            this.buttonCameraControl = new System.Windows.Forms.Button();
            this.placementControlSAMPLE1 = new PenumbraPhysics.Editor.Controls.Basic.Samples.PlacementControlSAMPLE();
            this.tabPageJustDraw = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButtonSettings = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItemShowFPS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowCursorPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowPhysicsDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonResetForces = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStripEditorFunctions = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCreateLight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResetCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageWelcome.SuspendLayout();
            this.tabPagePPManipulation.SuspendLayout();
            this.contextMenuStripPenumbraPhysicsMenu.SuspendLayout();
            this.tabPagePPPlacement.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStripEditorFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWelcome);
            this.tabControl1.Controls.Add(this.tabPagePPManipulation);
            this.tabControl1.Controls.Add(this.tabPagePPPlacement);
            this.tabControl1.Controls.Add(this.tabPageJustDraw);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 444);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.VisibleChanged += new System.EventHandler(this.tabControl1_VisibleChanged);
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
            this.tabPagePPManipulation.Controls.Add(this.buttonCloseManipulationSampleMessage);
            this.tabPagePPManipulation.Controls.Add(this.richTextBoxManipulationSample);
            this.tabPagePPManipulation.Controls.Add(this.penumbraPhysicsControlSAMPLE1);
            this.tabPagePPManipulation.Location = new System.Drawing.Point(4, 25);
            this.tabPagePPManipulation.Name = "tabPagePPManipulation";
            this.tabPagePPManipulation.Size = new System.Drawing.Size(641, 415);
            this.tabPagePPManipulation.TabIndex = 1;
            this.tabPagePPManipulation.Text = "Manipulation";
            this.tabPagePPManipulation.UseVisualStyleBackColor = true;
            // 
            // buttonCloseManipulationSampleMessage
            // 
            this.buttonCloseManipulationSampleMessage.Location = new System.Drawing.Point(562, 273);
            this.buttonCloseManipulationSampleMessage.Name = "buttonCloseManipulationSampleMessage";
            this.buttonCloseManipulationSampleMessage.Size = new System.Drawing.Size(79, 34);
            this.buttonCloseManipulationSampleMessage.TabIndex = 2;
            this.buttonCloseManipulationSampleMessage.Text = "Close";
            this.buttonCloseManipulationSampleMessage.UseVisualStyleBackColor = true;
            this.buttonCloseManipulationSampleMessage.Click += new System.EventHandler(this.buttonCloseManipulationSampleMessage_Click);
            // 
            // richTextBoxManipulationSample
            // 
            this.richTextBoxManipulationSample.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxManipulationSample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxManipulationSample.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxManipulationSample.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxManipulationSample.Location = new System.Drawing.Point(0, 310);
            this.richTextBoxManipulationSample.Name = "richTextBoxManipulationSample";
            this.richTextBoxManipulationSample.ReadOnly = true;
            this.richTextBoxManipulationSample.Size = new System.Drawing.Size(641, 105);
            this.richTextBoxManipulationSample.TabIndex = 1;
            this.richTextBoxManipulationSample.Text = resources.GetString("richTextBoxManipulationSample.Text");
            this.richTextBoxManipulationSample.ZoomFactor = 1.3F;
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
            this.physicsToolStripMenuItem});
            this.contextMenuStripPenumbraPhysicsMenu.Name = "contextMenuStripPenumbraPhysicsMenu";
            this.contextMenuStripPenumbraPhysicsMenu.Size = new System.Drawing.Size(149, 62);
            this.contextMenuStripPenumbraPhysicsMenu.Text = "PenumbraPhysics Menu";
            this.contextMenuStripPenumbraPhysicsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripPenumbraPhysicsMenu_Opening);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Enabled = false;
            this.editorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.editorToolStripMenuItem.Text = ".: Editor :.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClearPhysicsForces,
            this.toolStripSeparator1,
            this.ToolStripMenuItemResetAll});
            this.physicsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("physicsToolStripMenuItem.Image")));
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.physicsToolStripMenuItem.Text = "Physics";
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
            this.tabPagePPPlacement.Text = "Placement";
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
            this.tabPageJustDraw.Location = new System.Drawing.Point(4, 25);
            this.tabPageJustDraw.Name = "tabPageJustDraw";
            this.tabPageJustDraw.Size = new System.Drawing.Size(641, 415);
            this.tabPageJustDraw.TabIndex = 3;
            this.tabPageJustDraw.Text = "Just.Draw.";
            this.tabPageJustDraw.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonSettings});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(649, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripSplitButtonSettings
            // 
            this.toolStripSplitButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowFPS,
            this.toolStripMenuItemShowCursorPosition,
            this.toolStripMenuItemShowPhysicsDebug});
            this.toolStripSplitButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonSettings.Image")));
            this.toolStripSplitButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonSettings.Name = "toolStripSplitButtonSettings";
            this.toolStripSplitButtonSettings.RightToLeftAutoMirrorImage = true;
            this.toolStripSplitButtonSettings.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButtonSettings.Click += new System.EventHandler(this.toolStripSplitButtonSettings_Click);
            // 
            // toolStripMenuItemShowFPS
            // 
            this.toolStripMenuItemShowFPS.Checked = true;
            this.toolStripMenuItemShowFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowFPS.Name = "toolStripMenuItemShowFPS";
            this.toolStripMenuItemShowFPS.Size = new System.Drawing.Size(222, 26);
            this.toolStripMenuItemShowFPS.Text = "Show FPS";
            this.toolStripMenuItemShowFPS.Click += new System.EventHandler(this.toolStripMenuItemShowFPS_Click);
            // 
            // toolStripMenuItemShowCursorPosition
            // 
            this.toolStripMenuItemShowCursorPosition.Name = "toolStripMenuItemShowCursorPosition";
            this.toolStripMenuItemShowCursorPosition.Size = new System.Drawing.Size(222, 26);
            this.toolStripMenuItemShowCursorPosition.Text = "Show Cursor Position";
            this.toolStripMenuItemShowCursorPosition.Click += new System.EventHandler(this.toolStripMenuItemShowCursorPosition_Click);
            // 
            // toolStripMenuItemShowPhysicsDebug
            // 
            this.toolStripMenuItemShowPhysicsDebug.Name = "toolStripMenuItemShowPhysicsDebug";
            this.toolStripMenuItemShowPhysicsDebug.Size = new System.Drawing.Size(222, 26);
            this.toolStripMenuItemShowPhysicsDebug.Text = "Show Physics Debug";
            this.toolStripMenuItemShowPhysicsDebug.Click += new System.EventHandler(this.toolStripMenuItemShowPhysicsDebug_Click);
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
            this.toolStripMenuItemResetCamera});
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
            // toolStripMenuItemResetCamera
            // 
            this.toolStripMenuItemResetCamera.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemResetCamera.Image")));
            this.toolStripMenuItemResetCamera.Name = "toolStripMenuItemResetCamera";
            this.toolStripMenuItemResetCamera.Size = new System.Drawing.Size(132, 24);
            this.toolStripMenuItemResetCamera.Text = "Reset Camera";
            this.toolStripMenuItemResetCamera.Click += new System.EventHandler(this.toolStripMenuItemResetCamera_Click);
            // 
            // MainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 504);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPageWelcome.ResumeLayout(false);
            this.tabPagePPManipulation.ResumeLayout(false);
            this.contextMenuStripPenumbraPhysicsMenu.ResumeLayout(false);
            this.tabPagePPPlacement.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStripEditorFunctions.ResumeLayout(false);
            this.menuStripEditorFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabPagePPManipulation;
        private System.Windows.Forms.TabPage tabPagePPPlacement;
        private System.Windows.Forms.TabPage tabPageJustDraw;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowFPS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowCursorPosition;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowPhysicsDebug;
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
        private Controls.Basic.PenumbraPhysicsControlSAMPLE penumbraPhysicsControlSAMPLE1;
        private System.Windows.Forms.RichTextBox richTextBoxManipulationSample;
        private System.Windows.Forms.Button buttonCloseManipulationSampleMessage;
        private Controls.WelcomeUpdateControlSAMPLE welcomeUpdateControlSAMPLE1;
        private Controls.Basic.Samples.PlacementControlSAMPLE placementControlSAMPLE1;
        private System.Windows.Forms.MenuStrip menuStripEditorFunctions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateLight;
        private System.Windows.Forms.Button buttonCameraControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemResetCamera;
    }
}