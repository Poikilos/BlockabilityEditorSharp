/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 12/4/2015
 * Time: 6:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BlockabilityEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.storiesTabPage = new System.Windows.Forms.TabPage();
			this.worldsTabPage = new System.Windows.Forms.TabPage();
			this.statusTextBox = new System.Windows.Forms.TextBox();
			this.mainProgressBar = new System.Windows.Forms.ProgressBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tilesetsTabPage = new System.Windows.Forms.TabPage();
			this.spritesTabPage = new System.Windows.Forms.TabPage();
			this.framesTabPage = new System.Windows.Forms.TabPage();
			this.creditsTabPage = new System.Windows.Forms.TabPage();
			this.charactersTabPage = new System.Windows.Forms.TabPage();
			this.playersTabPage = new System.Windows.Forms.TabPage();
			this.mainTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.storiesTabPage);
			this.mainTabControl.Controls.Add(this.worldsTabPage);
			this.mainTabControl.Controls.Add(this.tilesetsTabPage);
			this.mainTabControl.Controls.Add(this.charactersTabPage);
			this.mainTabControl.Controls.Add(this.spritesTabPage);
			this.mainTabControl.Controls.Add(this.framesTabPage);
			this.mainTabControl.Controls.Add(this.playersTabPage);
			this.mainTabControl.Controls.Add(this.creditsTabPage);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Enabled = false;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(702, 251);
			this.mainTabControl.TabIndex = 0;
			// 
			// storiesTabPage
			// 
			this.storiesTabPage.Location = new System.Drawing.Point(4, 24);
			this.storiesTabPage.Name = "storiesTabPage";
			this.storiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.storiesTabPage.Size = new System.Drawing.Size(694, 223);
			this.storiesTabPage.TabIndex = 0;
			this.storiesTabPage.Text = "Stories";
			this.storiesTabPage.UseVisualStyleBackColor = true;
			// 
			// worldsTabPage
			// 
			this.worldsTabPage.Location = new System.Drawing.Point(4, 24);
			this.worldsTabPage.Name = "worldsTabPage";
			this.worldsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.worldsTabPage.Size = new System.Drawing.Size(694, 223);
			this.worldsTabPage.TabIndex = 1;
			this.worldsTabPage.Text = "Worlds";
			this.worldsTabPage.UseVisualStyleBackColor = true;
			// 
			// statusTextBox
			// 
			this.statusTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusTextBox.Location = new System.Drawing.Point(0, 278);
			this.statusTextBox.Name = "statusTextBox";
			this.statusTextBox.ReadOnly = true;
			this.statusTextBox.Size = new System.Drawing.Size(702, 23);
			this.statusTextBox.TabIndex = 1;
			// 
			// mainProgressBar
			// 
			this.mainProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mainProgressBar.Location = new System.Drawing.Point(0, 251);
			this.mainProgressBar.Name = "mainProgressBar";
			this.mainProgressBar.Size = new System.Drawing.Size(702, 27);
			this.mainProgressBar.TabIndex = 2;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tilesetsTabPage
			// 
			this.tilesetsTabPage.Location = new System.Drawing.Point(4, 24);
			this.tilesetsTabPage.Name = "tilesetsTabPage";
			this.tilesetsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.tilesetsTabPage.Size = new System.Drawing.Size(694, 223);
			this.tilesetsTabPage.TabIndex = 2;
			this.tilesetsTabPage.Text = "Tilesets";
			this.tilesetsTabPage.UseVisualStyleBackColor = true;
			// 
			// spritesTabPage
			// 
			this.spritesTabPage.Location = new System.Drawing.Point(4, 24);
			this.spritesTabPage.Name = "spritesTabPage";
			this.spritesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.spritesTabPage.Size = new System.Drawing.Size(694, 223);
			this.spritesTabPage.TabIndex = 3;
			this.spritesTabPage.Text = "Sprites";
			this.spritesTabPage.UseVisualStyleBackColor = true;
			// 
			// framesTabPage
			// 
			this.framesTabPage.Location = new System.Drawing.Point(4, 24);
			this.framesTabPage.Name = "framesTabPage";
			this.framesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.framesTabPage.Size = new System.Drawing.Size(694, 223);
			this.framesTabPage.TabIndex = 4;
			this.framesTabPage.Text = "Frames";
			this.framesTabPage.UseVisualStyleBackColor = true;
			// 
			// creditsTabPage
			// 
			this.creditsTabPage.Location = new System.Drawing.Point(4, 24);
			this.creditsTabPage.Name = "creditsTabPage";
			this.creditsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.creditsTabPage.Size = new System.Drawing.Size(694, 223);
			this.creditsTabPage.TabIndex = 5;
			this.creditsTabPage.Text = "Credits";
			this.creditsTabPage.UseVisualStyleBackColor = true;
			// 
			// charactersTabPage
			// 
			this.charactersTabPage.Location = new System.Drawing.Point(4, 24);
			this.charactersTabPage.Name = "charactersTabPage";
			this.charactersTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.charactersTabPage.Size = new System.Drawing.Size(694, 223);
			this.charactersTabPage.TabIndex = 6;
			this.charactersTabPage.Text = "Characters";
			this.charactersTabPage.UseVisualStyleBackColor = true;
			// 
			// playersTabPage
			// 
			this.playersTabPage.Location = new System.Drawing.Point(4, 24);
			this.playersTabPage.Name = "playersTabPage";
			this.playersTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.playersTabPage.Size = new System.Drawing.Size(694, 223);
			this.playersTabPage.TabIndex = 7;
			this.playersTabPage.Text = "Players";
			this.playersTabPage.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 301);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.mainProgressBar);
			this.Controls.Add(this.statusTextBox);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "BlockabilityEditor";
			this.mainTabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ProgressBar mainProgressBar;
		private System.Windows.Forms.TextBox statusTextBox;
		private System.Windows.Forms.TabPage creditsTabPage;
		private System.Windows.Forms.TabPage playersTabPage;
		private System.Windows.Forms.TabPage framesTabPage;
		private System.Windows.Forms.TabPage spritesTabPage;
		private System.Windows.Forms.TabPage charactersTabPage;
		private System.Windows.Forms.TabPage tilesetsTabPage;
		private System.Windows.Forms.TabPage worldsTabPage;
		private System.Windows.Forms.TabPage storiesTabPage;
		private System.Windows.Forms.TabControl mainTabControl;
	}
}
